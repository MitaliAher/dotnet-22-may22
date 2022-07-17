using System;
using System.Collections.Generic;

#nullable disable

namespace EStockMarket.Models
{
    public partial class ComReg
    {
        public int CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCeo { get; set; }
        public int? CompanyTurnover { get; set; }
        public string CompanyWebsite { get; set; }
        public string StockExchange { get; set; }
    }
}
