using _21_OOP_Hamburgerci.Enums.Helpers;
using System;
using System.Windows.Forms;

namespace _21_OOP_Hamburgerci
{
    public partial class FrmHamburgerEkle : Form
    {
        public FrmHamburgerEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frmSiparisOlustur.menuler.Add(new Models.Menu { MenuAdi = txtMenuAdi.Text, Fiyat = nmrFiyat.Value });
            Tools.Clean(this.Controls);
            MessageBox.Show("Menü eklendi");
        }
    }
}
