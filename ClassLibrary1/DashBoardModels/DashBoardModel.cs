using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DashBoardModels
{
   public  class DashBoardModel
    {
        public List<string> month { get; set; }
        public List<LineChartData> evolutionOfTicketsNbByMonths { get; set; }
        public List<PieChartData> nbTicketByStatus { get; set; }




    }
}
