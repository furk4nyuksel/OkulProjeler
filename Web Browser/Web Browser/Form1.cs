using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhabergetir_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(txturl.Text)) ///url boşmu dolumu ona bakıyoz
            {
                MessageBox.Show("Url Bilgisi Boş Geçilemez");
            }
            else
            {
                Rss_Read reader = new Rss_Read(txturl.Text);

                foreach (haber veri in reader.GetNews())
                {
                    ListViewItem lvitem = new ListViewItem();

                    lvitem.Text = veri.Link;
                    lvitem.SubItems.Add(veri.HaberBasligi);

                    listView1.Items.Add(lvitem);

                }
                
                
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                webBrowser1.Navigate(item.SubItems[0].Text);
            }
        }

        private void txturl_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
