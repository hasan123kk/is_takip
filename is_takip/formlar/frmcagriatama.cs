using DevExpress.XtraEditors;
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
    public partial class frmcagriatama : Form
    {
        public frmcagriatama()
        {
            InitializeComponent();
        }
        istakipEntities1 db = new istakipEntities1();
        public int id;
        private void frmcagriatama_Load(object sender, EventArgs e)
        {
            //lookupedit için verilerin listelenmesi----------------------------------

            var degerler = (from x in db.personel
                            select new
                            {
                                x.ID,
                                adsoyad = x.Ad + " " + x.Soyad
                            }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "adsoyad";
            lookUpEdit1.Properties.DataSource = degerler;

            //------------------------------------------------------------------------

            txtcagriid.Text = id.ToString();
            var gelenveri = db.cagrilar.Find(id);
            txtaciklama.Text = gelenveri.aciklama;
            txttarih.Text = gelenveri.tarih.ToString();
            txtkonu.Text = gelenveri.konu;
            

        }

        // ekle butonu
        private void btnekle_Click(object sender, EventArgs e)
        {
            var gelenveri = db.cagrilar.Find(id);
            gelenveri.konu = txtkonu.Text;
            gelenveri.tarih = Convert.ToDateTime(txttarih.Text);
            gelenveri.aciklama = txtaciklama.Text;
            gelenveri.cagripersonel = int.Parse(lookUpEdit1.EditValue.ToString());
            XtraMessageBox.Show("Çağrı detayı sisteme başarılı bir şekilde eklendi...");

        }
    }
}
