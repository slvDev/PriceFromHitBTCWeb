using System;
using System.Net;
using Newtonsoft.Json;
using PriceFromHitBTCWeb.Models;

namespace PriceFromHitBTCWeb.Data
{
    public class CoinsRepository
    {

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
