using Application.Enums;
using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class DollarServices
    {
        private CurrencyResponseViewModel response;
        public CurrencyResponseViewModel DollarResponse(int Destination, double Amount) {

            switch (Destination)
            {
                case (int)EnumCurrency.Currency.Peso:
                    response = new()
                    {
                        ActualCurrency = "USD",
                        DestinationCurrency = "DOP",
                        Amount = Amount,
                        Total = Amount * 55
                    };
                    return response;

                case (int)EnumCurrency.Currency.Dollar:
                    response = new()
                    {
                        ActualCurrency = "USD",
                        DestinationCurrency = "USD",
                        Amount = Amount,
                        Total = Amount * 1
                    };
                    return response;

                case (int)EnumCurrency.Currency.Euro:
                    response = new()
                    {
                        ActualCurrency = "USD",
                        DestinationCurrency = "EUR",
                        Amount = Amount,
                        Total = Amount * 0.94
                    };
                    return response;
                default:
                    return new();
            }

            }
    }
}
