using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PriceFromHitBTCWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var returnPrice = GetCoinPrice();
            return View(returnPrice);

        }

        public Coin GetCoinPrice()
        {

            var client = new WebClient();
            string jsonData = client.DownloadString("https://api.hitbtc.com/api/2/public/ticker/BTCUSD");

            var coin = new Coin();
            coin = JsonConvert.DeserializeObject<Coin>(jsonData);

            return coin;
        }

    }
}
