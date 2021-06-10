using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DashBoardModels
{
    public class LineChartData
    {
        //Monthes
        public DateTime X { get; set; }
       //ticket Number
        public decimal Y { get; set; }

        public LineChartData()
        {

        }

        public LineChartData(DateTime x, int y)
        {
            this.X = x;
            this.Y = y;
        }

    }
}
