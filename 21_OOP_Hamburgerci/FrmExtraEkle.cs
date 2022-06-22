using _21_OOP_Hamburgerci.Enums.Helpers;
using System;
using System.Windows.Forms;

namespace _21_OOP_Hamburgerci
{
    public partial class FrmExtraEkle : Form
    {
        public FrmExtraEkle()
        {
            InitializeComponent();
        }

        private void btnExtraKaydet_Click(object sender, EventArgs e)
        {
            frmSiparisOlustur.extralar.Add(new Models.Extra { ExtraAdi = txtExtraAdi.Text, Fiyat = nmrExtraFiyat.Value });
            Tools.Clean(this.Controls);
            MessageBox.Show("Menü eklendi");
        }
    }
}
