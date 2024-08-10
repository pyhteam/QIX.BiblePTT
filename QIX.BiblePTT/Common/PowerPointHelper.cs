using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Drawing;
using QIX.BiblePTT.Common;
using QIX.BiblePTT.Models;
using System.Drawing;
using System.IO;
using System;

public class PowerPointHelper
{
    private ShowPPTX showPptx { get; set; }

    public PowerPointHelper(ShowPPTX showPptx)
    {
        this.showPptx = showPptx ?? throw new ArgumentNullException(nameof(showPptx));
    }

    public void CreatePresentation()
    {
        string pathSave = showPptx.FilePath;
        using (PresentationDocument presentationDoc = PresentationDocument.Create(pathSave, PresentationDocumentType.Presentation))
        {
            PresentationPart presentationPart = presentationDoc.AddPresentationPart();
            presentationPart.Presentation = new Presentation();

            CreatePresentationParts(presentationPart);

            foreach (var verse in showPptx.Verses)
            {
                SlidePart slidePart = CreateSlidePart(presentationPart);
                CreateSlideContent(slidePart, verse);
            }
        }
    }

    private void CreatePresentationParts(PresentationPart presentationPart)
    {
        SlideMasterPart slideMasterPart1 = CreateSlideMasterPart(presentationPart);
        SlideLayoutPart slideLayoutPart1 = CreateSlideLayoutPart(slideMasterPart1);
        ThemePart themePart1 = CreateThemePart(slideMasterPart1);

        slideMasterPart1.AddPart(slideLayoutPart1, "rId1");
        presentationPart.AddPart(slideMasterPart1, "rId1");
        presentationPart.AddPart(themePart1, "rId5");
    }

    private SlidePart CreateSlidePart(PresentationPart presentationPart)
    {
       SlidePart slidePart = presentationPart.AddNewPart<SlidePart>("rId" + Guid.NewGuid().ToString("N"));
        slidePart.Slide = new Slide(new CommonSlideData(new ShapeTree()));
        return slidePart;
    }

    private SlideLayoutPart CreateSlideLayoutPart(SlideMasterPart slideMasterPart1)
    {
        SlideLayoutPart slideLayoutPart = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId1");
        slideLayoutPart.SlideLayout = new SlideLayout(new CommonSlideData(new ShapeTree()));
        return slideLayoutPart;
    }

    private SlideMasterPart CreateSlideMasterPart(PresentationPart presentationPart)
    {
        SlideMasterPart slideMasterPart = presentationPart.AddNewPart<SlideMasterPart>("rId1");
        slideMasterPart.SlideMaster = new SlideMaster(new CommonSlideData(new ShapeTree()));
        return slideMasterPart;
    }

    private ThemePart CreateThemePart(SlideMasterPart slideMasterPart)
    {
        ThemePart themePart = slideMasterPart.AddNewPart<ThemePart>("rId5");
        themePart.Theme = new DocumentFormat.OpenXml.Drawing.Theme() { Name = "Office Theme" };
        return themePart;
    }

    private void CreateSlideContent(SlidePart slidePart, Verse verse)
    {
        Slide slide = slidePart.Slide;

        SetBackground(slidePart);

        ConfigView config = showPptx.Config ?? throw new InvalidOperationException("Config cannot be null");

        string fontFamily = config.FontFamily ?? "Arial";
        float fontSize = config.FontSize ?? 40;
        FontStyle fontStyle = config.FontStyle ?? FontStyle.Regular;
        int typeShow = config.TypeShow ?? 0;
        Color fontColor = config.Color != null
            ? Color.FromArgb(config.Color.Value.R, config.Color.Value.G, config.Color.Value.B)
            : Color.White;

        EnumValue<TextAnchoringTypeValues> textAlign = config.TextAlign?.ToString().ToUpper() switch
        {
            "TOP" => TextAnchoringTypeValues.Top,
            "BOTTOM" => TextAnchoringTypeValues.Bottom,
            "CENTER" => TextAnchoringTypeValues.Center,
            _ => TextAnchoringTypeValues.Center
        };

        string content = $"{verse.Label}. {verse.Content}";
        AddText(slide, content, fontFamily, fontSize, fontStyle, fontColor, textAlign, 100, 0);

        string title = typeShow == 0
            ? $"{showPptx.BookName} {showPptx.ChapterNumber}:{verse.Label}"
            : $"{showPptx.ChapterNumber} {showPptx.BookName}";

        AddText(slide, title, fontFamily, fontSize, fontStyle, Color.FromArgb(150, 150, 57), textAlign, 0, 0);
    }

    private void AddText(Slide slide, string text, string fontFamily, float fontSize, FontStyle fontStyle, Color fontColor, EnumValue<TextAnchoringTypeValues> alignment, int top, int left)
    {
        var runProperties = new DocumentFormat.OpenXml.Drawing.RunProperties
        {
            FontSize = (Int32Value)(fontSize * 100),
            Bold = fontStyle.HasFlag(FontStyle.Bold) ? new BooleanValue(true) : null,
            Italic = fontStyle.HasFlag(FontStyle.Italic) ? new BooleanValue(true) : null,
            Underline = fontStyle.HasFlag(FontStyle.Underline) ? TextUnderlineValues.Single : TextUnderlineValues.None
        };

        var latinFont = new DocumentFormat.OpenXml.Drawing.LatinFont { Typeface = fontFamily };
        var solidFill = new DocumentFormat.OpenXml.Drawing.SolidFill
        {
            RgbColorModelHex = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex
            {
                Val = fontColor.R.ToString("X2") + fontColor.G.ToString("X2") + fontColor.B.ToString("X2")
            }
        };

        runProperties.Append(latinFont);
        runProperties.Append(solidFill);

        var shape = new DocumentFormat.OpenXml.Presentation.Shape(
            new DocumentFormat.OpenXml.Presentation.NonVisualShapeProperties(
                new DocumentFormat.OpenXml.Presentation.NonVisualDrawingProperties { Id = (UInt32Value)2U, Name = "TextBox" },
                new DocumentFormat.OpenXml.Presentation.NonVisualShapeDrawingProperties(new ShapeLocks { NoGrouping = true }),
                new ApplicationNonVisualDrawingProperties(new PlaceholderShape())
            ),
            new DocumentFormat.OpenXml.Presentation.ShapeProperties(),
            new DocumentFormat.OpenXml.Presentation.TextBody(
                new BodyProperties { Anchor = alignment },
                new ListStyle(),
                new Paragraph(
                    new DocumentFormat.OpenXml.Drawing.Run(runProperties, new DocumentFormat.OpenXml.Drawing.Text { Text = text })
                )
            )
        );

        slide.CommonSlideData.ShapeTree.AppendChild(shape);
    }

    private void SetBackground(SlidePart slidePart)
    {
        ConfigView config = showPptx.Config ?? throw new InvalidOperationException("Config cannot be null");

        Image image = string.IsNullOrEmpty(config.ImageBase64)
            ? null
            : Image.FromStream(new MemoryStream(Convert.FromBase64String(config.ImageBase64)));

        if (image != null)
        {
            ImagePart imagePart = slidePart.AddImagePart(ImagePartType.Jpeg);
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Seek(0, SeekOrigin.Begin);
                imagePart.FeedData(stream);
            }
            AddImageToSlide(slidePart, slidePart.GetIdOfPart(imagePart));
        }
        else
        {
            Color backgroundColor = Color.White;
            using (Bitmap bmp = new Bitmap(1920, 1080))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(backgroundColor);
                }

                string tempImagePath = System.IO.Path.GetTempFileName();
                bmp.Save(tempImagePath, System.Drawing.Imaging.ImageFormat.Png);

                ImagePart imagePart = slidePart.AddImagePart(ImagePartType.Png);
                using (FileStream stream = new FileStream(tempImagePath, FileMode.Open))
                {
                    imagePart.FeedData(stream);
                }
                AddImageToSlide(slidePart, slidePart.GetIdOfPart(imagePart));

                File.Delete(tempImagePath);
            }
        }
    }

    private void AddImageToSlide(SlidePart slidePart, string relationshipId)
    {
        var slideSize = new SlideSize() { Cx = 9144000, Cy = 6858000, Type = SlideSizeValues.Screen4x3 };

        slidePart.Slide.CommonSlideData.ShapeTree.AppendChild(new DocumentFormat.OpenXml.Presentation.Picture(
            new DocumentFormat.OpenXml.Drawing.NonVisualPictureProperties(
                new DocumentFormat.OpenXml.Drawing.NonVisualDrawingProperties { Id = (UInt32Value)1U, Name = "Background Image" },
                new DocumentFormat.OpenXml.Drawing.NonVisualPictureDrawingProperties()
            ),
            new DocumentFormat.OpenXml.Drawing.BlipFill(new Blip { Embed = relationshipId }, new Stretch(new FillRectangle())),
            new DocumentFormat.OpenXml.Drawing.ShapeProperties(
                new Transform2D(
                    new Offset { X = 0L, Y = 0L },
                    new Extents { Cx = slideSize.Cx.Value, Cy = slideSize.Cy.Value }
                )
            )
        ));
    }
}
