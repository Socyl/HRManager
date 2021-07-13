using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager
{
    class HourlyEmployee:Employee
    {
        public decimal HourlyRate { get; set; }

        public HourlyEmployee():base()
        {
            HourlyRate = 15.0M;
        }

        public override string PaySummary 
        {

            get { return "this employee is paid " + HourlyRate + " per hour"; }
        }
    }
}
