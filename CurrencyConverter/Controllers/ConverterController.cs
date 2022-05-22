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
        public ConverterController()
        {
            info = new();
        }
        public IActionResult Index()
        {
            return View(info);
        }
        public PartialViewResult GetResponse(CurrencyInformationViewModel vm) {

            return PartialView("_GetResponse",vm);
        }
    }
}
