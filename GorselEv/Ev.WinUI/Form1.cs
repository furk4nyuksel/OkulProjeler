using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ev.BLL;
using Ev.DAL;
namespace Ev.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ShippersRepository sr = new ShippersRepository();
        Shippers gelen;
        
        public void gelenuser()
        {
            dataGridView1.DataSource = sr.SelectAll();
        }



        private void btnkargo_Click(object sender, EventArgs e)
        {
            gelenuser();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcompany.Text) && string.IsNullOrEmpty(txtphone.Text))
            {
                MessageBox.Show("Hatalı Koçum boş bırakma");
                return;
            }
            gelen = new Shippers();

            gelen.CompanyName = txtcompany.Text;
            gelen.Phone = txtphone.Text;
            sr.Insert(gelen);
            gelenuser();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcompany.Text) && string.IsNullOrEmpty(txtphone.Text))
            {
                MessageBox.Show("Gelen veriler boş");
                return;
            }
            ///sorma sorma boş ver boş ver
            gelen.CompanyName = txtcompany.Text;
            gelen.Phone = txtphone.Text;
            sr.Update(gelen);

            gelenuser();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count < 0)
            {
                MessageBox.Show("Hatalı");
                return;
            }

            int gelenid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value); ///tabloya çift tıkladıgında veriler textboxa gelecek;


            gelen = sr.SelectByID(gelenid);

            txtcompany.Text = gelen.CompanyName;
            txtphone.Text = gelen.Phone;

            gelenuser();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 0)
            {
                MessageBox.Show("Seçim yok");
                return;
            }

            int gelenid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            sr.Delete(gelenid);

            gelenuser();



        }

        private void txtkargoismi_TextChanged(object sender, EventArgs e)
        {
         dataGridView1.DataSource=sr.SearchCargo(txtkargoismi.Text);
           
        }
    }
}
