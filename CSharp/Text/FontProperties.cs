using System.IO;

using Aspose.Slides;
using System.Drawing;
using Aspose.Slides.Export;

namespace Aspose.Slides.Examples.CSharp.Text
{
    public class FontProperties
    {
        public static void Run()
        {
            //ExStart:FontProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Text();

            // Instantiate a Presentation object that represents a PPTX file// Instantiate a Presentation object that represents a PPTX file
            using (Presentation pres = new Presentation(dataDir + "FontProperties.pptx"))
            {

                // Accessing a slide using its slide position
                ISlide slide = pres.Slides[0];

                // Accessing the first and second placeholder in the slide and typecasting it as AutoShape
                ITextFrame tf1 = ((IAutoShape)slide.Shapes[0]).TextFrame;
                ITextFrame tf2 = ((IAutoShape)slide.Shapes[1]).TextFrame;

                // Accessing the first Paragraph
                IParagraph para1 = tf1.Paragraphs[0];
                IParagraph para2 = tf2.Paragraphs[0];

                // Accessing the first portion
                IPortion port1 = para1.Portions[0];
                IPortion port2 = para2.Portions[0];

                // Define new fonts
                FontData fd1 = new FontData("Elephant");
                FontData fd2 = new FontData("Castellar");

                // Assign new fonts to portion
                port1.PortionFormat.LatinFont = fd1;
                port2.PortionFormat.LatinFont = fd2;

                // Set font to Bold
                port1.PortionFormat.FontBold = NullableBool.True;
                port2.PortionFormat.FontBold = NullableBool.True;

                // Set font to Italic
                port1.PortionFormat.FontItalic = NullableBool.True;
                port2.PortionFormat.FontItalic = NullableBool.True;

                // Set font color
                port1.PortionFormat.FillFormat.FillType = FillType.Solid;
                port1.PortionFormat.FillFormat.SolidFillColor.Color = Color.Purple;
                port2.PortionFormat.FillFormat.FillType = FillType.Solid;
                port2.PortionFormat.FillFormat.SolidFillColor.Color = Color.Peru;

                //Write the PPTX to disk
                pres.Save(dataDir + "WelcomeFont_out.pptx", SaveFormat.Pptx);
            }
            //ExEnd:FontProperties
        }
    }
}