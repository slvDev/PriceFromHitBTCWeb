using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using PriceFromHitBTCWeb.Models;
using static PriceFromHitBTCWeb.Models.SymbolModel;

namespace PriceFromHitBTCWeb.Data
{
    public class CoinsRepository
    {

        public Coin GetCoinPrice(string symbol)
        {
            
            var client = new WebClient();
            string jsonData = client.DownloadString("https://api.hitbtc.com/api/2/public/ticker/" + symbol);

            var coin = JsonConvert.DeserializeObject<Coin>(jsonData);

            return coin;
        }

        public List<Symbol> GetAllSymbols()
        {
            var client = new WebClient();
            string jsonData = client.DownloadString("https://api.hitbtc.com/api/2/public/symbol/");

            var allSymbols = JsonConvert.DeserializeObject<List<Symbol>>(jsonData);

            return allSymbols;
        }

    }
}
