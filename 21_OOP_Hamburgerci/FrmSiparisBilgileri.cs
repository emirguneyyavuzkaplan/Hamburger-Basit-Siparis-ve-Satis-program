using _21_OOP_Hamburgerci.Models;
using System;
using System.Windows.Forms;

namespace _21_OOP_Hamburgerci
{
    public partial class FrmSiparisBilgileri : Form
    {
        public FrmSiparisBilgileri()
        {
            InitializeComponent();
        }

        private void FrmSiparisBilgileri_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal extraMAlzemeGeliri = 0;
            int satısAdedi = 0;
            foreach (Siparis item in frmSiparisOlustur.siparisler)
            {
                ciro += item.ToplamTutar;
                decimal itemExtras = 0;
                foreach (Extra ex in item.Extralar)
                    itemExtras += ex.Fiyat;

                extraMAlzemeGeliri += itemExtras * item.Adet;
                satısAdedi += item.Adet;
                lstSiparisler.Items.Add(item);
            }
            lblCiro.Text = ciro.ToString("C2");
            lblToplamSiparisAdedi.Text = lstSiparisler.Items.Count.ToString();
            lblExtraMalzemeGeliri.Text = extraMAlzemeGeliri.ToString("C2");
            lblSatılanUrunAdedi.Text = satısAdedi.ToString();

        }
    }
}
