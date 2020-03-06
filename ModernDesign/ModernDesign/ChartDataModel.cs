using System;
using System.Collections.Generic;
using System.Text;

namespace ModernDesign
{
    public class ChartDataModel
    {
        public string Name { get; set; }

       
        public double Value { get; set; }

       

        public ChartDataModel(string name, double value)
        {
            Name = name;
            Value = value;
        }

       

       
       
    }
}
