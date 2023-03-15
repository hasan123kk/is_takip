namespace is_takip.personelgorev
{
    partial class frmpersonelformu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpersonelformu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnaktifgorevler = new DevExpress.XtraBars.BarButtonItem();
            this.btnpasifgorevler = new DevExpress.XtraBars.BarButtonItem();
            this.btncagrilistesi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.White;
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(46);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.btnaktifgorevler,
            this.btnpasifgorevler,
            this.btncagrilistesi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 515;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(1140, 183);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnaktifgorevler
            // 
            this.btnaktifgorevler.Caption = "Aktif Görevler";
            this.btnaktifgorevler.Id = 3;
            this.btnaktifgorevler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnaktifgorevler.ImageOptions.Image")));
            this.btnaktifgorevler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnaktifgorevler.ImageOptions.LargeImage")));
            this.btnaktifgorevler.Name = "btnaktifgorevler";
            this.btnaktifgorevler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnaktifgorevler_ItemClick);
            // 
            // btnpasifgorevler
            // 
            this.btnpasifgorevler.Caption = "Pasif Görevler";
            this.btnpasifgorevler.Id = 4;
            this.btnpasifgorevler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnpasifgorevler.ImageOptions.Image")));
            this.btnpasifgorevler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnpasifgorevler.ImageOptions.LargeImage")));
            this.btnpasifgorevler.Name = "btnpasifgorevler";
            this.btnpasifgorevler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnpasifgorevler_ItemClick);
            // 
            // btncagrilistesi
            // 
            this.btncagrilistesi.Caption = "Çağrı listesi";
            this.btncagrilistesi.Id = 5;
            this.btncagrilistesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btncagrilistesi.ImageOptions.Image")));
            this.btncagrilistesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btncagrilistesi.ImageOptions.LargeImage")));
            this.btncagrilistesi.Name = "btncagrilistesi";
            this.btncagrilistesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncagrilistesi_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ana sayfa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnaktifgorevler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnpasifgorevler);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btncagrilistesi);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmpersonelformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 673);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmpersonelformu";
            this.Text = "frmpersonelformu";
            this.Load += new System.EventHandler(this.frmpersonelformu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnaktifgorevler;
        private DevExpress.XtraBars.BarButtonItem btnpasifgorevler;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btncagrilistesi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}