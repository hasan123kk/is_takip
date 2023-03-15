using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        // departman listesi butunu
        formlar.frmdepartman frm;
        private void btndeparrtmanlistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new formlar.frmdepartman();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        // personel listesi butonu
        formlar.frmpersoneller frm2;
        private void btnpersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new formlar.frmpersoneller();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        //personel istatistik butonu
        formlar.frmpersonelistatistik frm3;
        private void btnpersonelistatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new formlar.frmpersonelistatistik();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        // görev listesi butonu
        formlar.frmgorevlistesi frm4;
        private void btngorevlistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new formlar.frmgorevlistesi();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }

        //yeni görev butonu
        private void btnyenigorev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.frmyenigorev frm5 = new formlar.frmyenigorev();           
            frm5.Show();
        }

        // görev detay butonu
        private void btngorevdetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.frmgorevdetay frm6 = new formlar.frmgorevdetay();
            frm6.Show();
        }

        //ana sayfa butonu
        formlar.frmanasayfa frm6;
        private void btnanasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm6 == null || frm6.IsDisposed)
            {
                frm6 = new formlar.frmanasayfa();
                frm6.MdiParent = this;
                frm6.Show();
            }
        }

        // aktif çağrılar butonu
        formlar.frmaktifcagrilar frm7;    
        private void btnaktifcagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {
                frm7 = new formlar.frmaktifcagrilar();
                frm7.MdiParent = this;
                frm7.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
