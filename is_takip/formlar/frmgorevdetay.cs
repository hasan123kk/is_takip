using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity; //
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip.entity; //

namespace is_takip.formlar
{
    public partial class frmgorevdetay : Form
    {
        public frmgorevdetay()
        {
            InitializeComponent();
        }
        istakipEntities1 db = new istakipEntities1();
        private void frmgorevdetay_Load(object sender, EventArgs e)
        {
            db.gorevdetay.Load();
            bindingSource1.DataSource = db.gorevdetay.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }
    }
}
