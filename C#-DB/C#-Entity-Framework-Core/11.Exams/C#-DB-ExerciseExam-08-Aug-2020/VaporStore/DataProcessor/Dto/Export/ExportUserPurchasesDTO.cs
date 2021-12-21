using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace VaporStore.DataProcessor.Dto.Export
{
    [XmlType("User")]
    public class ExportUserPurchasesDTO
    {
        [XmlAttribute("username")]
        [Required]
        public string Username { get; set; }

        [XmlArray("Purchases")]
        public ExportPurchaseDTO[] Purchases { get; set; }

        public decimal TotalSpent { get; set; }
    }     
}
