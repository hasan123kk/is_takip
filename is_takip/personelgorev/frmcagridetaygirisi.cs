using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip.entity;

namespace is_takip.personelgorev
{
    public partial class frmcagridetaygirisi : Form
    {
        public frmcagridetaygirisi()
        {
            InitializeComponent();
        }

        istakipEntities1 db = new istakipEntities1();

        public int id;
        //vazgeç butonu
        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //form yüklendiğinde
        private void frmcagridetaygirisi_Load(object sender, EventArgs e)
        {
            txtcagriID.Enabled = false;
            txtcagriID.Text = id.ToString();

            string saat, tarih;

            tarih = DateTime.Now.ToShortDateString();
            saat = DateTime.Now.ToShortTimeString();
            txttarih.Text = tarih;
            txtsaat.Text = saat;
        }

        //kaydet butonu
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            cagridetaylar t = new cagridetaylar(); 
            t.Cagri = int.Parse(txtcagriID.Text);
            t.saat = txtsaat.Text;
            t.Tarih = DateTime.Parse(txttarih.Text);
            t.Aciklama = txtaciklama.Text;
            db.cagridetaylar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Çağrı detayı sisteme başarılı bir şekilde eklendi...");

        }
    }
}
