using Currency_Converter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Currency_Converter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICurrencyConverter _currencyConverter;
        private readonly IAuditService _auditService;

        public HomeController(ILogger<HomeController> logger, ICurrencyConverter currencyConverter, IAuditService auditService)
        {
            _logger = logger;
            _currencyConverter = currencyConverter;
            _auditService = auditService;
        }

        public IActionResult Index(CurrencyModel currency, AuditModel audit)
        {
            if (ModelState.IsValid)
            {
                ViewBag.conversion = _currencyConverter.ConvertCurrencyAsync(currency, audit).Result;
                ViewBag.ticker = audit.CurrencyConvertedTo;
            } 

            return View();   
        }

        public IActionResult Audit(AuditModel audit)
        {

            if (ModelState.IsValid)
            {
                ViewBag.audit = _auditService.GetAudit(audit);
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
