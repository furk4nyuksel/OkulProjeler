using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KurGetir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument xDoc = new XmlDocument();
        private void Btngetir_Click(object sender, EventArgs e)
        {
            string url = "http://www.tcmb.gov.tr/kurlar/today.xml";

            WebClient wc = new WebClient(); //webclient açtık vriyi internetten almak için

            wc.Encoding = Encoding.UTF8;

            string xmlData = wc.DownloadString(url);

            xDoc.LoadXml(xmlData);

            XmlNodeList kur = xDoc.DocumentElement.ChildNodes;





            foreach (XmlNode veri in kur)
            {
                string kurlar = veri.ChildNodes[2].InnerText;

                cmbTur.Items.Add(kurlar); //kurları çektim

            }

        }

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTur.SelectedIndex != -1) ///seçildiginde çalış
            {

                XmlNode secilikur = xDoc.DocumentElement.SelectSingleNode(string.Format("Currency[CurrencyName='{0}']", cmbTur.SelectedItem)); //burada chechboxda çalışanı çağırcak






                if (secilikur == null)
                {
                    return;
                }

                //secili kura göre getiriyo
                lblkur.Text = secilikur.SelectSingleNode("Isim").InnerText;
                lblalis.Text = secilikur.SelectSingleNode("BanknoteBuying").InnerText;
                lblsatis.Text = secilikur.SelectSingleNode("BanknoteSelling").InnerText;


            }
        }
    }
}
