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

namespace is_takip.personelgorev
{
    public partial class frmcagrilistesi : Form
    {
        public frmcagrilistesi()
        {
            InitializeComponent();
        }

        istakipEntities1 db = new istakipEntities1();
        public string mail2;

        private void frmcagrikabul_Load(object sender, EventArgs e)
        {
            var personelid = db.personel.Where(x => x.Mail == mail2).Select(y => y.ID).FirstOrDefault();
            gridControl1.DataSource = (from x in db.cagrilar
                                       select new
                                       {
                                           x.ID,
                                           x.firmalar.Ad,
                                           x.firmalar.Telefon,
                                           x.firmalar.Mail,
                                           x.aciklama,
                                           x.cagripersonel,
                                           x.durum
                                       }).Where(x => x.durum == true && x.cagripersonel == personelid).ToList();
            gridView1.Columns["durum"].Visible = false;
            gridView1.Columns["cagripersonel"].Visible = false;

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmcagridetaygirisi fr = new frmcagridetaygirisi();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
