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
    public partial class frmdepartman : Form
    {
        public frmdepartman()
        {
            InitializeComponent();
        }


        istakipEntities1 db = new istakipEntities1();


        void listele() // listele
        {
            
            var degerler =(from x in db.departmanlar
                           select new
                           {
                               x.ID,
                               x.Ad,
                           }
                           ).ToList();
            gridControl1.DataSource = degerler;
        }

        private void btnlistele_Click(object sender, EventArgs e) 
        {
            listele();  
        }

        private void btnekle_Click(object sender, EventArgs e) // ekle
        {
            departmanlar t = new departmanlar();
            t.Ad = txtad.Text;  
            db.departmanlar.Add(t); 
            db.SaveChanges();  
            XtraMessageBox.Show("Departman başarılı bir şekilde kaydedildi","Bilgi", 
                MessageBoxButtons.OK, MessageBoxIcon.Information); 
            listele();  

        }

        private void btnsil_Click(object sender, EventArgs e) // sil
        {
            int x =int.Parse(txtid.Text);
            var deger = db.departmanlar.Find(x);    
            db.departmanlar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde silindi","Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Stop); 
            listele();

        }

        //satırı textboxa gönderme
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e) // güncelle
        {
            int x = int.Parse(txtid.Text);
            var deger = db.departmanlar.Find(x);
            deger.Ad = txtad.Text;       
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde güncellendi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listele();
        }

        private void frmdepartman_Load(object sender, EventArgs e)
        {

        }
    }
}
