using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace XMLSandBox.Models
{
    public class CdList
    {
        public List<Cd> cdList { get; set; }
        public CdList()
        {
            cdList = new List<Cd>();
            initList();
        }
        public void initList()
        {
            string path = "Data/cd_catalog.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList xmlList = doc.GetElementsByTagName("CD");
            foreach (XmlElement e in xmlList)
            {
                XmlNodeList cdElements = e.ChildNodes;

                string title = e.GetElementsByTagName("TITLE")[0].InnerText;
                string artist = e.GetElementsByTagName("ARTIST")[0].InnerText;
                string country = e.GetElementsByTagName("COUNTRY")[0].InnerText;
                string price = e.GetElementsByTagName("PRICE")[0].InnerText;
                string year = e.GetElementsByTagName("YEAR")[0].InnerText;
                Cd cd = new Cd(title, artist, country, price, year);

                cdList.Add(cd);
            }
        }
    }
}
