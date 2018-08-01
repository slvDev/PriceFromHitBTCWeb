using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PriceFromHitBTCWeb.Data;
using PriceFromHitBTCWeb.Models;


namespace PriceFromHitBTCWeb.Controllers
{
    public class HomeController : Controller
    {

        private CoinsRepository _coinsRepository = null;

        public HomeController()
        {
            _coinsRepository = new CoinsRepository();
        }

        public IActionResult Index()
        {
            var returnPrice = _coinsRepository.GetCoinPrice();
            return View(returnPrice);

        }


    }
}
