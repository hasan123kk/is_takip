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
    public partial class frmpasifgorevler : Form
    {
        public frmpasifgorevler()
        {
            InitializeComponent();
        }

        istakipEntities1 db = new istakipEntities1();
        public string mail2;

        private void frmpasifgorevler_Load(object sender, EventArgs e)
        {
            var personelid = db.personel.Where(x => x.Mail == mail2).Select(y => y.ID).FirstOrDefault();
            var degerler = (from x in db.gorevler
                           select new
                           {
                               x.ID,
                               x.Aciklama,
                               x.Tarih,
                               x.GorevAlan,
                               x.Durum
                           }).Where(x => x.GorevAlan == personelid && x.Durum == false).ToList();
            gridControl1.DataSource = degerler;
            gridView1.Columns["GorevAlan"].Visible = false;
            gridView1.Columns["Durum"].Visible = false;
        }
    }
}
