using DevExpress.XtraReports.UI;
using sinema_bufe.Nesne;
using sinema_bufe.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_bufe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, cay, su, bilet,toplam;
            misir = Convert.ToInt16(txtMısır.Text);
            cay = Convert.ToInt16(txtCay.Text);
            su = Convert.ToInt16(txtSu.Text);
            bilet = Convert.ToInt16(txtBilet.Text);
            toplam = misir * 4 + su * 1 + cay * 2 + bilet * 8;
            lblSonuc.Text = toplam.ToString()+" TL";
            kasatutar += toplam;
            lblKasa.Text = kasatutar.ToString() + " TL";

            sinemaRaporu sinerapor = new sinemaRaporu();
            sinerapor.Parameters["mısır"].Value = txtMısır.Text;
            sinerapor.Parameters["cay"].Value = txtCay.Text;
            sinerapor.Parameters["su"].Value = txtSu.Text;
            sinerapor.Parameters["bilet"].Value = txtBilet.Text;
            sinerapor.Parameters["toplam"].Value = lblSonuc.Text;
            sinerapor.Parameters["qrCode"].Value = "05068897267";

            sinerapor.CreateDocument();
            sinerapor.Print();
            

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBilet.Text = "";
            txtCay.Text = "";
            txtMısır.Text = "";
            txtSu.Text = "";
            txtMısır.Focus();
        }
    }
}
