using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer.DTO.Input
{
    [XmlType("Supplier")]
    public class SuplierInputModelDto
    {
        [XmlElement("name")]
        public string Name { get; set; }


        [XmlElement("isImporter")]
        public bool IsImporter { get; set; }
    }
}
