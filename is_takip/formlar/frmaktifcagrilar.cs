using is_takip.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip.formlar
{
    public partial class frmaktifcagrilar : Form
    {
        public frmaktifcagrilar()
        {
            InitializeComponent();
        }

        private void frmaktifcagrilar_Load(object sender, EventArgs e)
        {
            istakipEntities1 db = new istakipEntities1();
            var degerler = (from x in db.cagrilar
                            select new
                            {
                                x.ID,
                                x.firmalar.Ad,
                                x.firmalar.Telefon,
                                x.konu,
                                x.aciklama,
                                personel = x.personel.Ad,
                                x.durum
                                
                            }).Where(y => y.durum == true).ToList();
            gridControl1.DataSource = degerler;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmcagriatama fr = new frmcagriatama();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
