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

namespace is_takip.formlar
{
    public partial class frmyenigorev : Form
    {
        public frmyenigorev()
        {
            InitializeComponent();
        }

        istakipEntities1 db = new istakipEntities1();

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            gorevler t = new gorevler();     
            t.Aciklama = txtaciklama.Text;
            t.Durum = true;
            t.GorevAlan = int.Parse(lookUpEdit1.EditValue.ToString()); 
            t.Tarih = DateTime.Parse(txttarih.Text);
            t.GorevVeren = 1;
            db.gorevler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Görev başarılı bir şekilde eklendi...", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmyenigorev_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.personel
                            select new
                            {
                                x.ID,
                                adsoyad = x.Ad + " " + x.Soyad
                            }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "adsoyad";
            lookUpEdit1.Properties.DataSource = degerler;

        }
    }
}
