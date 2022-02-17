using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_projesi.Entity;

namespace is_takip_projesi.Formlar
{
    public partial class FrmGorevListesi : Form
    {
        public FrmGorevListesi()
        {
            InitializeComponent();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        DbIsTakipEntities db = new DbIsTakipEntities();
        private void FrmGorevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGorevler
                                       select new
                                       {
                                           x.Acıklama
                                       }).ToList();

            LblAktifGorev.Text = db.TblGorevler.Where(x => x.Durum == true).Count().ToString();
            LblPasifGorev.Text = db.TblGorevler.Where(x => x.Durum == false).Count().ToString();
            LblToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();

            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(LblAktifGorev.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(LblPasifGorev.Text));


        }
    }
}
