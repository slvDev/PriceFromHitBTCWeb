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
            return View();

        }

        [HttpPost]
        public IActionResult Index(Coin coin)
        {
            var returnCoin = _coinsRepository.GetCoinPrice(coin.Symbol);
            ViewBag.Price = returnCoin.Last;
            return View(returnCoin);

        }
    }
}
