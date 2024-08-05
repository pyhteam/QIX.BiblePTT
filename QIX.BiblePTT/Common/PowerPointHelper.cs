namespace QIX.BiblePTT.Common;

using QIX.BiblePTT.Models;
using Spire.Presentation;
using Spire.Presentation.Drawing;
using System;
using System.Drawing;
using System.IO;

public static class PowerPointHelper
{
    public static void CreatePresentation(ShowPPTX showPTTX)
    {
        Presentation presentation = new Presentation();

        foreach (var verse in showPTTX.Verses)
        {
            AddSlide(presentation, showPTTX.Config, showPTTX.BookName, showPTTX.ChapterNumber, verse, showPTTX.Verses.Count);
        }

        presentation.SaveToFile(showPTTX.FilePath, FileFormat.Pptx2013);
        presentation.Dispose();

        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
        {
            FileName = showPTTX.FilePath,
            UseShellExecute = true
        });
    }

  private static void AddSlide(Presentation presentation, ConfigView config, string bookName, int chapterNumber, Verse verse, int verseCount)
{
    ISlide slide = presentation.Slides.Append();

    if (string.IsNullOrEmpty(config?.ImageBase64))
    {
        slide.SlideBackground.Fill.FillType = FillFormatType.Solid;
        slide.SlideBackground.Fill.SolidColor.Color = Color.Black;
        // set background color
        slide.DisplaySlideBackground.Fill.FillType = FillFormatType.Gradient;
    }
    else
    {
        byte[] imageBytes = Convert.FromBase64String(config.ImageBase64);
        using (MemoryStream ms = new MemoryStream(imageBytes))
        {
            IImageData image = presentation.Images.Append(ms);
            slide.SlideBackground.Fill.FillType = FillFormatType.Picture;
            slide.SlideBackground.Fill.PictureFill.Picture.EmbedImage = image;
        }
    }

    AddTitle(slide, bookName, chapterNumber, verse, verseCount);

    if (config != null)
    {
        AddVerseContent(slide, verse, config);
    }
    else
    {
        // Handle the case where config is null, if necessary
        // For example, you could log a warning or use default values
    }
}
    private static void AddTitle(ISlide slide, string bookName, int chapterNumber, Verse verse, int verseCount)
    {
        string titleText;
        titleText = $"{bookName} {chapterNumber}:{verse.Label}";
        

        IAutoShape titleShape = slide.Shapes.AppendShape(ShapeType.Rectangle, new RectangleF(10, 10, 700, 50));
        titleShape.Fill.FillType = FillFormatType.None;
        titleShape.TextFrame.Text = titleText;
        titleShape.TextFrame.TextRange.Fill.FillType = FillFormatType.Solid;
        titleShape.TextFrame.TextRange.Fill.SolidColor.Color = Color.Blue;
        titleShape.TextFrame.TextRange.FontHeight = 20;
        titleShape.TextFrame.TextRange.LatinFont = new TextFont("Arial");
    }

    private static void AddVerseContent(ISlide slide, Verse verse, ConfigView config)
    {
        // Verse Content
        IAutoShape contentShape = slide.Shapes.AppendShape(ShapeType.Rectangle, new RectangleF(10, 60, 700, 440));
        contentShape.Fill.FillType = FillFormatType.None;
        contentShape.TextFrame.Text = verse.Content;
        contentShape.TextFrame.TextRange.Fill.FillType = FillFormatType.Solid;
        contentShape.TextFrame.TextRange.Fill.SolidColor.Color = config?.Color ?? Color.White;
        contentShape.TextFrame.TextRange.FontHeight = config?.FontSize ?? 40;
        contentShape.TextFrame.TextRange.LatinFont = new TextFont(config?.FontFamily ?? "Arial");
    }
}
