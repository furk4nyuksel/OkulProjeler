using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Web_Browser
{
  public class Rss_Read
    {

        ///evde tekrar yap ve webbrowserdan aktar
        private string siteURL;
        private XmlDocument xDoc;
        public Rss_Read(string _url)//_ sadece bu metodda kullanılacaksa yazılırmış ncapsulationmuş bu
        {

            this.siteURL = _url;///üstteki degişken degeri burdan çekcek diyoruz
            xDoc = new XmlDocument();///instance aldık unutma

        }

        private void GetRssNews()
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            string XmlData = wc.DownloadString(siteURL);
            xDoc.LoadXml(XmlData);
            //okuduk

        }

        public List<haber> GetNews()
            
        { //liste haline getirdik
           
            List<haber> haberlistesi = new List<haber>();
            GetRssNews();

            XmlNodeList nodlar = xDoc.DocumentElement.GetElementsByTagName("item");//xmldeki item tagını aldık

            foreach (XmlNode veriler in nodlar)
            {
              

                try
                {
                    haber h = new haber();

                    h.HaberBasligi = veriler.SelectSingleNode("title").InnerText; //başlık
                    h.Link = veriler.SelectSingleNode("link").InnerText;//linki aldk
                    haberlistesi.Add(h); //haberlistsine ekledik

                } 
                catch (Exception ex )
                {
                    continue;
                  ///  System.Windows.Forms.MessageBox.Show(ex.Message);
                }



            }
            return haberlistesi;
        }
    }
}
