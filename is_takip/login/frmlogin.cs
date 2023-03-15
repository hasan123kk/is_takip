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

namespace is_takip.login
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        istakipEntities1 db = new istakipEntities1();
      

        //ADMİN GİRİŞİ -------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            var adminvalue = db.Admin.Where(x => x.Kullanici == txtkullanici.Text && x.Sifre == txtsifre.Text).FirstOrDefault();
            if (adminvalue != null)
            {
                XtraMessageBox.Show("Hoşgeldiniz");
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı giriş");
            }
            
        }

        //PERSONEL GİRİŞİ ------------------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {
            var personelvalue = db.personel.Where(x => x.Mail == txtkullanici.Text && x.Sifre == txtsifre.Text).FirstOrDefault();
            if(personelvalue != null)
            {
                XtraMessageBox.Show("Hoşgeldiniz");
                personelgorev.frmpersonelformu fr1 = new personelgorev.frmpersonelformu();
                fr1.mail = txtkullanici.Text;
                fr1.Show();
                this.Hide();

            }
            else
            {
                XtraMessageBox.Show("Hatalı giriş");
            }
            
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            panel3.BackColor =SystemColors.Control;
        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
        }
    }
}
