using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Formlar.FrmDepartmanlar frm;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm == null || frm.IsDisposed) { 
                frm = new Formlar.FrmDepartmanlar();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersoneller frm2 = new Formlar.FrmPersoneller();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void BtnPersonelIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersonelIstatistik frm3 = new Formlar.FrmPersonelIstatistik();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Formlar.FrmGorevListesi frm4;
        private void BtnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm4 == null || frm4.IsDisposed) 
            { 
                frm4 = new Formlar.FrmGorevListesi();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }

        private void BtnGorevTanimla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorev fr = new Formlar.FrmGorev();
            fr.Show();
        }

        private void BtnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevDetay fr = new Formlar.FrmGorevDetay();
            fr.Show();
        }
    }
}
