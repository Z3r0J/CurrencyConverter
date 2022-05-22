using Application.Enums;
using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PesoServices
    {
        private CurrencyResponseViewModel response;

        public CurrencyResponseViewModel PesoResponse(int Destination, double Amount)
        {
                    switch (Destination)
                    {
                        case (int)EnumCurrency.Currency.Peso:
                            response = new()
                            {
                                ActualCurrency = "DOP",
                                DestinationCurrency = "DOP",
                                Amount = Amount,
                                Total = Amount * 1
                            };
                            return response;

                        case (int)EnumCurrency.Currency.Dollar:
                            response = new()
                            {
                                ActualCurrency = "DOP",
                                DestinationCurrency = "USD",
                                Amount = Amount,
                                Total = Amount * 0.018
                            };
                            return response;

                        case (int)EnumCurrency.Currency.Euro:
                            response = new()
                            {
                                ActualCurrency = "DOP",
                                DestinationCurrency = "EUR",
                                Amount = Amount,
                                Total = Amount * 0.017
                            };
                            return response;
                        default:
                    return response = new();
                    }
            }
        }
    }
