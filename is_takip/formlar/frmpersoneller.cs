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
using DevExpress.XtraEditors;

namespace is_takip.formlar
{
    public partial class frmpersoneller : Form
    {
        public frmpersoneller()
        {
            InitializeComponent();
        }

        istakipEntities1 db = new istakipEntities1();

        void personel()
        {
            var degerler = from x in db.personel
                           select new
                           {
                               x.ID,
                               x.Ad,
                               x.Soyad,
                               x.Mail,
                               Departman = x.departmanlar.Ad,
                               x.Durum

                           };
            gridControl1.DataSource = degerler.Where(x=>x.Durum==true).ToList();
        }
        private void frmpersoneller_Load(object sender, EventArgs e)
        {
            personel();

            var departmanlar = (from x in db.departmanlar
                                select new
                                {
                                    x.ID,
                                    x.Ad
                                }).ToList();
            
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Ad";
            lookUpEdit1.Properties.DataSource = departmanlar;   
                
        }

        private void btnlistele_Click(object sender, EventArgs e)//listele
        {
            personel();
        }

        private void btnekle_Click(object sender, EventArgs e)// ekle
        {
            personel t = new personel();
            t.Ad = txtad.Text;
            t.Soyad = txtsoyad.Text;    
            t.Mail = txtmail.Text;  
            t.Gorsel = txtgorsel.Text;  
            t.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            db.personel.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Personel başarıllı bir şekilde eklendi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            personel();

        }

        private void btnsil_Click(object sender, EventArgs e) // sil
        {
            var x = int.Parse(txtid.Text);
            var deger = db.personel.Find(x);
            deger.Durum = false;
            db.SaveChanges();
            XtraMessageBox.Show("Personel başarılı bir şekilde silindi","Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            personel();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtsoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            txtmail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            //txtgorsel.Text = gridView1.GetFocusedRowCellValue("Gorsel").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Departman").ToString();

        }

        private void btnguncelle_Click(object sender, EventArgs e)// güncelle
        {
            int x = int.Parse(txtid.Text);
            var deger = db.personel.Find(x);
            deger.Ad=txtad.Text;
            deger.Soyad=txtsoyad.Text;
            deger.Mail=txtmail.Text;
            deger.Gorsel=txtgorsel.Text;
            deger.Departman=int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Personel başarılı bir şekilde güncellendi", "Bilgi",
               MessageBoxButtons.OK, MessageBoxIcon.Question);
            personel();

        }
    }
}
