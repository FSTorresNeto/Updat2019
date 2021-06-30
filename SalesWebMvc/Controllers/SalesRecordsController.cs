using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
   
    public class SalesRecordsController : Controller
    {
        private readonly SallesrecordService _sallesrecordService;

        public SalesRecordsController(SallesrecordService sallesrecordService)
        {
            _sallesrecordService = sallesrecordService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public  async Task<ActionResult> SimpleSearch(DateTime? midDate, DateTime? maxDate)
        {
            var result  = await _sallesrecordService.FindDataAsync(midDate, maxDate);
            return View();
        }

        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}
