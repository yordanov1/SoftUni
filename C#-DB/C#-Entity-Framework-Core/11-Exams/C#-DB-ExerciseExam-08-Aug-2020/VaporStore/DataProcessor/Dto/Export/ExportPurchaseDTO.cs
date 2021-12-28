using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace VaporStore.DataProcessor.Dto.Export
{
    [XmlType("Purchase")]
    public class ExportPurchaseDTO
    {
        [XmlElement("Card")]
        [Required]
        public string Card { get; set; }

        [XmlElement("Cvc")]
        [Required]
        public string Cvc { get; set; }

        [XmlElement("Date")]
        [Required]
        public string Date { get; set; }

        [XmlElement("Game")]
        public ExportGameDTO Game { get; set; }

    }
}
