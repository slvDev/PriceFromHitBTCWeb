using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceFromHitBTCWeb.Models
{
    public class SymbolModel
    {   
        public class Symbol
        {
            public string Id { get; set; }
            public string BaseCurrency { get; set; }
            public string QuoteCurrency { get; set; }
            public string QuantityIncrement { get; set; }
            public string TickSize { get; set; }
            public string TakeLiquidityRate { get; set; }
            public string ProvideLiquidityRate { get; set; }
            public string FeeCurrency { get; set; }
        }

    }
}
