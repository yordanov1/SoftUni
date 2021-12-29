using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.DTO
{
    public class ExportCarPartsDto
    {
        [JsonProperty("car")]
        public ExportCarDto Car { get; set; }

        [JsonProperty("parts")]
        public ICollection<ExportPartDto> Parts { get; set; }
    }
}
