using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DashBoardModels
{
    public class PieChartData
    {
        //represents tickets status
        public string Label { get; set; }
        //nb tickets
        public decimal Value { get; set; }

        public PieChartData()
        {

        }

        public PieChartData(string label, decimal value)
        {
            Label = label;

            Value = Math.Round(value, 2);
        }




    }
}
