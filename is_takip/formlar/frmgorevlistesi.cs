using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip.entity;

namespace is_takip.formlar
{
    public partial class frmgorevlistesi : Form
    {
        public frmgorevlistesi()
        {
            InitializeComponent();
        }

        istakipEntities1 db = new istakipEntities1();

        private void frmgorevlistesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.gorevler select new
            {              
                x.Aciklama
            }).ToList();

            lblAktifgorevsayisi.Text = db.gorevler.Where(x => x.Durum == true).Count().ToString();
            lblPasifgorevsayisi.Text = db.gorevler.Where(x => x.Durum == false).Count().ToString();
            lblToplamdepartman.Text = db.departmanlar.Count().ToString();

            chartControl1.Series["Durum"].Points.AddPoint("Aktif görevler", int.Parse(lblAktifgorevsayisi.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif görevler", int.Parse(lblPasifgorevsayisi.Text));
        }
    }
}
