namespace QIX.BiblePTT.Common;

using System;
using System.Collections.Generic;
using System.Drawing;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using QIX.BiblePTT.Models;
using A = DocumentFormat.OpenXml.Drawing;
using P = DocumentFormat.OpenXml.Presentation;

public static class PowerPointHelper
{
    public static void CreatePresentation(ShowPPTX showPPTX)
    {
        if (showPPTX == null || showPPTX.Verses == null || showPPTX.Verses.Count == 0)
            throw new ArgumentNullException(nameof(showPPTX), "ShowPPTX or its Verses cannot be null or empty.");

        using (PresentationDocument presentationDocument = PresentationDocument.Create(showPPTX.FilePath ?? "presentation.pptx", PresentationDocumentType.Presentation))
        {
            // Create the presentation part
            PresentationPart presentationPart = presentationDocument.AddPresentationPart();
            presentationPart.Presentation = new P.Presentation();

            // Create the slide master part
            SlideMasterPart slideMasterPart = presentationPart.AddNewPart<SlideMasterPart>();
            slideMasterPart.SlideMaster = new P.SlideMaster(new P.CommonSlideData(new P.ShapeTree()));

            // Create the slide layout part
            SlideLayoutPart slideLayoutPart = slideMasterPart.AddNewPart<SlideLayoutPart>();
            slideLayoutPart.SlideLayout = new P.SlideLayout(new P.CommonSlideData(new P.ShapeTree()));

            // Create the slide part for each verse
            int slideIndex = 1;
            foreach (var verse in showPPTX.Verses)
            {
                CreateSlide(presentationPart, slideLayoutPart, slideIndex++, verse, showPPTX);
            }

            // Save the presentation
            presentationPart.Presentation.Save();
        }
    }

    private static void CreateSlide(PresentationPart presentationPart, SlideLayoutPart slideLayoutPart, int slideIndex, Verse verse, ShowPPTX showPPTX)
    {
        SlidePart slidePart = presentationPart.AddNewPart<SlidePart>($"rId{slideIndex}");
        slidePart.Slide = new P.Slide(new P.CommonSlideData(new P.ShapeTree()));

        // Set slide background
        SetSlideBackground(slidePart, showPPTX.Config?.ImagePath);

        // Create the title shape
        CreateTitleShape(slidePart, showPPTX.BookName, showPPTX.ChapterNumber, showPPTX.Verses, showPPTX.Config?.FontFamily, showPPTX.Config?.FontSize ?? 40);

        // Create the content shape for the verse
        CreateContentShape(slidePart, verse, showPPTX.Config);

        slidePart.AddPart(slideLayoutPart);
    }

    private static void SetSlideBackground(SlidePart slidePart, string? imagePath)
    {
        P.Background background = new P.Background();
        P.BackgroundProperties backgroundProperties = new P.BackgroundProperties();

        if (string.IsNullOrEmpty(imagePath))
        {
            A.SolidFill solidFill = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex = new A.RgbColorModelHex() { Val = "000000" }; // Black background
            solidFill.Append(rgbColorModelHex);
            backgroundProperties.Append(solidFill);
        }
        else
        {
            // Add image background if imagePath is provided
            A.BlipFill blipFill = new A.BlipFill();
            A.Blip blip = new A.Blip() { Embed = slidePart.GetIdOfPart(slidePart.AddImagePart(ImagePartType.Jpeg)) };
            blipFill.Append(blip);
            backgroundProperties.Append(blipFill);
        }

        background.Append(backgroundProperties);
        slidePart.Slide.CommonSlideData.Append(background);
    }

    private static void CreateTitleShape(SlidePart slidePart, string? bookName, int chapterNumber, List<Verse> verses, string? fontFamily, float fontSize)
    {
        P.Shape titleShape = new P.Shape();
        P.NonVisualShapeProperties nonVisualShapeProperties = new P.NonVisualShapeProperties(
            new P.NonVisualDrawingProperties() { Id = 1, Name = "Title" },
            new P.NonVisualShapeDrawingProperties(new A.ShapeLocks() { NoGrouping = true }),
            new P.ApplicationNonVisualDrawingProperties(new P.PlaceholderShape() { Type = P.PlaceholderValues.Title }));

        P.ShapeProperties shapeProperties = new P.ShapeProperties();
        P.TextBody textBody = new P.TextBody(new A.BodyProperties(), new A.ListStyle());

        A.Paragraph paragraph = new A.Paragraph();
        A.Run run = new A.Run();
        A.Text text = new A.Text();

        if (verses.Count > 1)
        {
            text.Text = $"{bookName} {chapterNumber}:{verses[0].Label}-{verses[^1].Label}";
        }
        else
        {
            text.Text = $"{bookName} {chapterNumber} {verses[0].Label}";
        }

        run.Append(text);
        paragraph.Append(run);
        textBody.Append(paragraph);

        A.ParagraphProperties paragraphProperties = new A.ParagraphProperties();
        paragraphProperties.Append(new A.SolidFill(new A.RgbColorModelHex() { Val = "0000FF" })); // Blue color
        textBody.Append(paragraphProperties);

        titleShape.Append(nonVisualShapeProperties);
        titleShape.Append(shapeProperties);
        titleShape.Append(textBody);

        slidePart.Slide.CommonSlideData.ShapeTree.Append(titleShape);
    }

    private static void CreateContentShape(SlidePart slidePart, Verse verse, ConfigView? config)
    {
        P.Shape contentShape = new P.Shape();
        P.NonVisualShapeProperties nonVisualShapeProperties = new P.NonVisualShapeProperties(
            new P.NonVisualDrawingProperties() { Id = 2, Name = "Content" },
            new P.NonVisualShapeDrawingProperties(new A.ShapeLocks() { NoGrouping = true }),
            new P.ApplicationNonVisualDrawingProperties());

        P.ShapeProperties shapeProperties = new P.ShapeProperties();
        P.TextBody textBody = new P.TextBody(new A.BodyProperties(), new A.ListStyle());

        A.Paragraph paragraph = new A.Paragraph();
        A.Run labelRun = new A.Run();
        A.Text labelText = new A.Text() { Text = verse.Label };
        labelRun.Append(labelText);

        // Set label color to blue
        A.ParagraphProperties labelParagraphProperties = new A.ParagraphProperties();
        labelParagraphProperties.Append(new A.SolidFill(new A.RgbColorModelHex() { Val = "0000FF" })); // Blue color
        paragraph.Append(labelParagraphProperties);
        paragraph.Append(labelRun);

        // Append content
        A.Run contentRun = new A.Run();
        A.Text contentText = new A.Text() { Text = verse.Content };
        contentRun.Append(contentText);

        // Set content formatting
        A.ParagraphProperties contentParagraphProperties = new A.ParagraphProperties();
        if (config != null)
        {
            contentRun.RunProperties = new A.RunProperties()
            {
                //FontFamily = config.FontFamily,
                FontSize = (int)(config.FontSize * 100), // FontSize in EMU
                Bold = (config.FontStyle & FontStyle.Bold) != 0,
                Italic = (config.FontStyle & FontStyle.Italic) != 0,
                Underline = (config.FontStyle & FontStyle.Underline) != 0 ? A.TextUnderlineValues.Single : A.TextUnderlineValues.None,
                //Color = new A.SolidFill(new A.RgbColorModelHex() { Val = ColorTranslator.ToHtml(config.Color).Replace("#", "") })
            };

            switch (config.TextAlign?.ToLower())
            {
                case "center":
                    contentParagraphProperties.Alignment = A.TextAlignmentTypeValues.Center;
                    break;
                case "right":
                    contentParagraphProperties.Alignment = A.TextAlignmentTypeValues.Right;
                    break;
                default:
                    contentParagraphProperties.Alignment = A.TextAlignmentTypeValues.Left;
                    break;
            }
        }
        else
        {
            // Default content formatting
            contentRun.RunProperties = new A.RunProperties()
            {
               // FontFamily = "Arial",
                FontSize = 40 * 100, // 40pt
               // Color = new A.SolidFill(new A.RgbColorModelHex() { Val = "FFFFFF" }) // White color
            };
            contentParagraphProperties.Alignment = A.TextAlignmentTypeValues.Left;
        }

        paragraph.Append(contentParagraphProperties);
        paragraph.Append(contentRun);
        textBody.Append(paragraph);

        contentShape.Append(nonVisualShapeProperties);
        contentShape.Append(shapeProperties);
        contentShape.Append(textBody);

        slidePart.Slide.CommonSlideData.ShapeTree.Append(contentShape);
    }
}

