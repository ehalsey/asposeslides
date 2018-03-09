﻿using Aspose.Slides.SmartArt;
using Aspose.Slides.Export;
using Aspose.Slides;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Slides.Examples.CSharp.SmartArts
{
    class ChangeTextOnSmartArtNode
    {
        public static void Run()
        {
            //ExStart:ChangeTextOnSmartArtNode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_SmartArts();

            using (Presentation presentation = new Presentation())
            {
                // Add SmartArt BasicProcess 
                ISmartArt smart = presentation.Slides[0].Shapes.AddSmartArt(10, 10, 400, 300, SmartArtLayoutType.BasicCycle);

                // Obtain the reference of a node by using its Index  
                ISmartArtNode node = smart.Nodes[1]; // select second root node

                // Setting the text of the TextFrame 
                node.TextFrame.Text = "Second root node";

                // Saving Presentation
                presentation.Save(dataDir + "ChangeText_On_SmartArt_Node_out.pptx", SaveFormat.Pptx);
            }
            //ExEnd:ChangeTextOnSmartArtNode
        }
    }
}
