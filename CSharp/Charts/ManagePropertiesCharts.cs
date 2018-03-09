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
    public class ManagePropertiesCharts
    {
        public static void Run()
        {
            //ExStart:ManagePropertiesCharts
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Charts();

            // Create an instance of Presentation class
            Presentation presentation = new Presentation();
           
            // Access first slide
            ISlide slide = presentation.Slides[0];

            // Add chart with default data
            IChart chart = slide.Shapes.AddChart(ChartType.StackedColumn3D, 0, 0, 500, 500);

            // Setting the index of chart data sheet
            int defaultWorksheetIndex = 0;

            // Getting the chart data worksheet
            IChartDataWorkbook fact = chart.ChartData.ChartDataWorkbook;

            // Add series
            chart.ChartData.Series.Add(fact.GetCell(defaultWorksheetIndex, 0, 1, "Series 1"), chart.Type);
            chart.ChartData.Series.Add(fact.GetCell(defaultWorksheetIndex, 0, 2, "Series 2"), chart.Type);

            // Add Catrgories
            chart.ChartData.Categories.Add(fact.GetCell(defaultWorksheetIndex, 1, 0, "Caetegoty 1"));
            chart.ChartData.Categories.Add(fact.GetCell(defaultWorksheetIndex, 2, 0, "Caetegoty 2"));
            chart.ChartData.Categories.Add(fact.GetCell(defaultWorksheetIndex, 3, 0, "Caetegoty 3"));

            // Set Rotation3D properties
            chart.Rotation3D.RightAngleAxes = true;
            chart.Rotation3D.RotationX = 40;
            chart.Rotation3D.RotationY = 270;
            chart.Rotation3D.DepthPercents = 150;

            // Take second chart series
            IChartSeries series = chart.ChartData.Series[1];

            // Now populating series data
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 1, 1, 20));
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 2, 1, 50));
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 3, 1, 30));
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 1, 2, 30));
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 2, 2, 10));
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 3, 2, 60));

            // Set OverLap value
            series.ParentSeriesGroup.Overlap = 100;         

            // Write presentation to disk
            presentation.Save(dataDir + "Rotation3D_out.pptx", SaveFormat.Pptx);
            //ExEnd:ManagePropertiesCharts
        }
    }
}