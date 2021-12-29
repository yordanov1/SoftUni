using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.DTO
{
    public class ExportCustomerSaleDto
    {

        [JsonProperty("car")]
        public ExportCarDto Car { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        public decimal Discount { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("priceWithDiscount")]
        public decimal PriceWithDiscount { get; set; }

    }
}
