using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XMLSandBox.Models
{
    public class Cd
    {
        public string TITLE { get; set; }
        public string ARTIST { get; set; }
        public string COUNTRY { get; set; }
        public string PRICE { get; set; }
        public string YEAR { get; set; }
        public Cd(string title, string artist, string country, string price, string year)
        {
            TITLE = title;
            ARTIST = artist;
            COUNTRY = country;
            PRICE = price;
            YEAR = year;
        }
      
    }

}
