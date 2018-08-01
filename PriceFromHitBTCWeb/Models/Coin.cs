using System;
namespace PriceFromHitBTCWeb.Models
{
    public class Coin
    {
        public string Ask { get; set; }
        public string Bid { get; set; }
        public string Last { get; set; }
        public string Open { get; set; }
        public string Low { get; set; }
        public string High { get; set; }
        public string Volume { get; set; }
        public string VolumeQuote { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Symbol { get; set; }

    }
}
