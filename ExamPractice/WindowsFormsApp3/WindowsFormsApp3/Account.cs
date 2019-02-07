using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{

    public enum PaymentPeriod
    {
        Annual = 1, 
        BiAnnual, 
        Quarterly, 
        Monthly

    }

    class Account
    {
        public int AccountId { get; set; }
        public string Eircode { get; set; }
        public PaymentPeriod PaymentPeriod { get; set; }
        public int ArrearsCount { get; set; }
    }
}
