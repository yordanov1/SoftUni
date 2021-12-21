using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace VaporStore.DataProcessor.Dto.Export
{
    [XmlType("Game")]
    public class ExportGameDTO
    {
        [XmlAttribute("title")]
        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        public decimal Price { get; set; }
    }
}
