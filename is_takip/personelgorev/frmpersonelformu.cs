using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip.personelgorev
{
    public partial class frmpersonelformu : Form
    {
        public frmpersonelformu()
        {
            InitializeComponent();
        }

        public string mail;


        // aktif görevler
        private void btnaktifgorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            personelgorev.frmaktifgorevler frm = new personelgorev.frmaktifgorevler();
            frm.MdiParent = this;
            frm.Mail2 = mail;
            frm.Show();
        }

        // pasif görevler
        private void btnpasifgorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            personelgorev.frmpasifgorevler frm = new personelgorev.frmpasifgorevler();
            frm.MdiParent = this;
            frm.mail2 = mail;
            frm.Show();
        }

        // çağrı listesi
        private void btncagrilistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            personelgorev.frmcagrilistesi frm2 = new personelgorev.frmcagrilistesi();
            frm2.MdiParent = this;
            frm2.mail2 = mail;
            frm2.Show();
        }

        private void frmpersonelformu_Load(object sender, EventArgs e)
        {
            this.Text = "Personel Paneli";
        }
    }
}
