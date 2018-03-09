﻿using Aspose.Slides.Charts;
using Aspose.Slides.Export;
using Aspose.Slides;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Slides.Examples.CSharp.Charts
{
    public class SetCategoryAxisLabelDistance
    {
        public static void Run()
        {
            //ExStart:SetCategoryAxisLabelDistance
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Charts();

            Presentation presentation = new Presentation();

            // Get reference of the slide
            ISlide sld = presentation.Slides[0];

            // Adding a chart on slide
            IChart ch = sld.Shapes.AddChart(ChartType.ClusteredColumn, 20, 20, 500, 300);

            // Setting the position of label from axis
            ch.Axes.HorizontalAxis.LabelOffset = 500;

            // Write the presentation file to disk
            presentation.Save(dataDir + "SetCategoryAxisLabelDistance_out.pptx", SaveFormat.Pptx);
            //ExEnd:SetCategoryAxisLabelDistance
        }
    }
}