using Application.Enums;
using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class EuroServices
    {
        private CurrencyResponseViewModel response;
        public CurrencyResponseViewModel EuroResponse(int Destination, double Amount)
        {

            switch (Destination)
            {
                case (int)EnumCurrency.Currency.Peso:
                    response = new()
                    {
                        ActualCurrency = "EUR",
                        DestinationCurrency = "DOP",
                        Amount = Amount,
                        Total = Amount * 58.37
                    };
                    return response;

                case (int)EnumCurrency.Currency.Dollar:
                    response = new()
                    {
                        ActualCurrency = "EUR",
                        DestinationCurrency = "USD",
                        Amount = Amount,
                        Total = Amount * 1.05
                    };
                    return response;

                case (int)EnumCurrency.Currency.Euro:
                    response = new()
                    {
                        ActualCurrency = "EUR",
                        DestinationCurrency = "EUR",
                        Amount = Amount,
                        Total = Amount * 1
                    };
                    return response;
                default:
                    return new();
            }
        }
    }
}
