using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ModernDesign.View
{
    public class LineSeriesViewModel
    {

        public ObservableCollection<ChartDataModel> LineData1 { get; set; }

        public ObservableCollection<ChartDataModel> LineData2 { get; set; }


        public LineSeriesViewModel()
        {
            LineData1 = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("Sun", 21),
                new ChartDataModel("Mon", 24),
                new ChartDataModel("Tue", 36),
                new ChartDataModel("Wed", 38),
                new ChartDataModel("Thu", 54),
                new ChartDataModel("Fri", 57),
                new ChartDataModel("Sat", 70)
            };

            LineData2 = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("Sun", 28),
                new ChartDataModel("Mon", 44),
                new ChartDataModel("Tue", 48),
                new ChartDataModel("Wed", 50),
                new ChartDataModel("Thu", 66),
                new ChartDataModel("Fri", 78),
                new ChartDataModel("Sat", 84)
            };
        }
    }
}
