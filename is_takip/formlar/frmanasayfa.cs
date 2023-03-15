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
    public partial class frmanasayfa : Form
    {
        public frmanasayfa()
        {
            InitializeComponent();
        }

        istakipEntities1 db = new istakipEntities1();

        private void frmanasayfa_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.gorevler
                                       select new
                                       {
                                           x.Aciklama,
                                           personel = x.personel.Ad + " " +x.personel.Soyad,
                                           x.Durum
                                       }).Where(y => y.Durum == true).ToList();
            gridView1.Columns["Durum"].Visible = false; 

            // bugün yapılan görevler----------------------------------------------------------------

            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            gridControl2.DataSource = (from x in db.gorevdetay
                                       select new
                                       {
                                           görev = x.gorevler.Aciklama,
                                           x.Aciklama,
                                           x.Tarih
                                       }).Where(x => x.Tarih == bugun).ToList();

            //çağrılar----------------------------------------------------------------------------------

            gridControl3.DataSource = (from x in db.cagrilar
                                       select new
                                       {
                                           x.firmalar.Ad,
                                           x.konu,
                                           x.tarih,
                                           x.durum
                                       }).Where(x => x.durum == true).ToList();
            gridView3.Columns["durum"].Visible = false;

            //Fihrist komutları------------------------------------------------------------------------

            gridControl4.DataSource = (from x in db.firmalar
                                       select new
                                       {
                                           x.Ad,
                                           x.Telefon,
                                           x.Mail
                                       }).ToList();

            // çağrı grafikleri ----------------------------------------------------------------------------

            int aktif_cagrilar = db.cagrilar.Where(x => x.durum == true).Count();
            int pasif_cagrilar = db.cagrilar.Where(x => x.durum == false).Count();

            chartControl1.Series["Series 1"].Points.AddPoint("aktif_cagrilar", aktif_cagrilar);
            chartControl1.Series["Series 1"].Points.AddPoint("pasif_cagrilar", pasif_cagrilar);



        }
    }
}
