using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class CurrencyResponseViewModel
    {
        public string ActualCurrency { get; set; }
        public string DestinationCurrency { get; set; }
        public double Total { get; set; }
    }
}
