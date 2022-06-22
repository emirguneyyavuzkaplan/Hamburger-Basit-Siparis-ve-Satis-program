using System;
using System.Windows.Forms;

namespace _21_OOP_Hamburgerci
{
    public partial class frmMainMdi : Form
    {
        public frmMainMdi()
        {
            InitializeComponent();
        }


        private void siparisOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new frmSiparisOlustur());
        }

        private void siparisBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FrmSiparisBilgileri());
        }

        private void hamburgerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FrmHamburgerEkle());
        }

        private void extraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FrmExtraEkle());
        }

        public void ChildForm(Form _childForm)
        {
            this.Width = _childForm.Width + 25;
            this.Height = _childForm.Height + 75;

            bool durum = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();

                }
                else
                    frm.Close();
            }
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }


    }
}
