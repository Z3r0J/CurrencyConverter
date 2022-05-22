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
                    var convertPeso = new PesoServices();
                    return convertPeso.PesoResponse(vm.DestinationCurrency, vm.Amount);

                case (int)EnumCurrency.Currency.Dollar:
                    var convertDollar = new DollarServices();
                    return convertDollar.DollarResponse(vm.DestinationCurrency, vm.Amount);

                case (int)EnumCurrency.Currency.Euro:
                    var convertEuro = new EuroServices();
                    return convertEuro.EuroResponse(vm.DestinationCurrency, vm.Amount);
                        default:
                    return new();
                    }
            }
        }
    }
