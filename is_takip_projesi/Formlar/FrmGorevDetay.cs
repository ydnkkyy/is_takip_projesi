using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_projesi.Entity;

namespace is_takip_projesi.Formlar
{
    public partial class FrmGorevDetay : Form
    {
        public FrmGorevDetay()
        {
            InitializeComponent();
        }

        DbIsTakipEntities db = new DbIsTakipEntities();
        private void FrmGorevDetay_Load(object sender, EventArgs e)
        {
            db.TblGorevDetaylar.Load();
            bindingSource1.DataSource = db.TblGorevDetaylar.Local;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void görevDetaySilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
