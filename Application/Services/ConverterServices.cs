using Application.Enums;
using Application.ViewModel;

namespace Application.Services
{
    public class ConverterServices
    {
        private CurrencyResponseViewModel response;
        public CurrencyResponseViewModel Converter(CurrencyInformationViewModel vm)
        {
            switch (vm.ActualCurrency)
            {
                #region PesoDominicano
                case (int)EnumCurrency.Currency.Peso:
                    switch (vm.DestinationCurrency)
                    {
                        case (int)EnumCurrency.Currency.Peso:
                            response = new()
                            {
                                ActualCurrency = "DOP",
                                DestinationCurrency = "DOP",
                                Total = vm.Amount * 1
                            };
                            return response;

                        case (int)EnumCurrency.Currency.Dollar:
                           response = new()
                            {
                                ActualCurrency = "DOP",
                                DestinationCurrency = "USD",
                                Total = vm.Amount * 0.018
                           };
                            return response;

                        case (int)EnumCurrency.Currency.Euro:
                            response = new()
                            {
                                ActualCurrency = "DOP",
                                DestinationCurrency = "EUR",
                                Total = vm.Amount * 0.017
                            };
                            return response;
                        default:
                            break;
                    }
                    break;
                #endregion

                default:
                    break;
            }

            return new();
        }
    }
}
