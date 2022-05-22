using Application.Enums;
using Application.ViewModel;

namespace Application.Services
{
    public class ConverterServices
    {
        public CurrencyResponseViewModel Converter(CurrencyInformationViewModel vm)
        {
            switch (vm.ActualCurrency)
            {
                case (int)EnumCurrency.Currency.Peso:
                    var convertpeso = new PesoServices();
                    return convertpeso.PesoResponse(vm.DestinationCurrency, vm.Amount);

                #region UnitedStateDollar
                case (int)EnumCurrency.Currency.Dollar:
                    break;
                #endregion

                #region Euro
                case (int)EnumCurrency.Currency.Euro:
                    switch (vm.DestinationCurrency)
                    {
                        case (int)EnumCurrency.Currency.Peso:
                            response = new()
                            {
                                ActualCurrency = "EUR",
                                DestinationCurrency = "DOP",
                                Amount = vm.Amount,
                                Total = vm.Amount * 58
                            };
                            return response;

                        case (int)EnumCurrency.Currency.Dollar:
                            response = new()
                            {
                                ActualCurrency = "EUR",
                                DestinationCurrency = "USD",
                                Amount = vm.Amount,
                                Total = vm.Amount * 1.05
                            };
                            return response;

                        case (int)EnumCurrency.Currency.Euro:
                            response = new()
                            {
                                ActualCurrency = "EUR",
                                DestinationCurrency = "EUR",
                                Amount = vm.Amount,
                                Total = vm.Amount * 1
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
