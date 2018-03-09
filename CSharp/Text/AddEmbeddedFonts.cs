﻿using Aspose.Slides.Export;
using Aspose.Slides;
using System.Linq;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Slides.Examples.CSharp.Text
{
    class AddEmbeddedFonts
    {
        public static void Run()
        {
            //ExStart:AddEmbeddedFonts
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Text();

            // Load presentation
            Presentation presentation = new Presentation(dataDir + "Fonts.pptx");

            // Load source font to be replaced
            IFontData sourceFont = new FontData("Arial");


            IFontData[] allFonts = presentation.FontsManager.GetFonts();
            IFontData[] embeddedFonts = presentation.FontsManager.GetEmbeddedFonts();
            foreach (IFontData font in allFonts)
            {
                if (!embeddedFonts.Contains(font))
                {
                    presentation.FontsManager.AddEmbeddedFont(font, EmbedFontCharacters.All);
                }
            }

            // Save the presentation
            presentation.Save(dataDir + "AddEmbeddedFont_out.pptx", SaveFormat.Pptx);
            //ExEnd:AddEmbeddedFonts
        }
    }
}