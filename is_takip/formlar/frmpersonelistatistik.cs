using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using is_takip.entity;
using System.Windows.Forms;

namespace is_takip.formlar
{
    public partial class frmpersonelistatistik : Form
    {
        public frmpersonelistatistik()
        {
            InitializeComponent();
        }

        istakipEntities1 db = new istakipEntities1();

        private void frmpersonelistatistik_Load(object sender, EventArgs e)
        {
            lbltoplamdepartman.Text = db.departmanlar.Count().ToString();

            lbltoplamfirma.Text = db.firmalar.Count().ToString();

            lbltoplampersonel.Text = db.personel.Count().ToString();

            lblaktifis.Text = db.gorevler.Count(x => x.Durum == true).ToString();
            lblpasifis.Text = db.gorevler.Count(x => x.Durum == false).ToString();

            lblsongorev.Text = db.gorevdetay.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault(); 
            
            lblsogorevtarihi.Text = db.gorevler.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();

            lblsehirsayisi.Text = db.firmalar.Select(x => x.il).Distinct().Count().ToString();

            lblsektorsayisi.Text = db.firmalar.Select(x => x.Sektor).Distinct().Count().ToString();

            DateTime bugun = DateTime.Today;
            lblbugünkügorevler.Text = db.gorevler.Count(x => x.Tarih == bugun).ToString();

            var d1 =  db.gorevler.GroupBy(x => x.GorevAlan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            lblayinpersoneli.Text = db.personel.Where(x => x.ID == d1).Select(y => y.Ad +" "+ y.Soyad).FirstOrDefault().ToString();

            lblayindepartmani.Text = db.departmanlar.Where(x => x.ID == db.personel.Where(t => t.ID == d1).Select(z => z.Departman).FirstOrDefault()).Select(y => y.Ad).FirstOrDefault().ToString();

        }
    }
}
