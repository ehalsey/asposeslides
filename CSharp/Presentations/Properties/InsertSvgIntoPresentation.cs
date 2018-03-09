using Aspose.Slides.Export;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/


namespace Aspose.Slides.Examples.CSharp.Presentations
{
    public class InsertSvgIntoPresentation
    {
        public static void Run()
        {
            //ExStart:InsertSvgIntoPresentation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PresentationProperties();
            using (var p = new Presentation())
         {
            var svgContent = File.ReadAllText(svgPath);
            var emfImage = p.Images.AddFromSvg(svgContent);
            p.Slides[0].Shapes.AddPictureFrame(ShapeType.Rectangle, 0, 0, emfImage.Width, emfImage.Height, emfImage);
            p.Save(outPptxPath, SaveFormat.Pptx);

           
            }
            //ExEnd:InsertSvgIntoPresentation
        }
    }
}