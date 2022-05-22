using Application;
using Application.Services;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Controllers
{
    public class ConverterController : Controller
    {
        private readonly CurrencyInformationViewModel info;
        private readonly ConverterServices services;
        public ConverterController()
        {
            info = new();
            services = new();
        }
        public IActionResult Index()
        {
            return View(info);
        }
        public PartialViewResult GetResponse(CurrencyInformationViewModel vm) {
            var response = services.Converter(vm);
            return PartialView("_GetResponse",response);
        }
    }
}
