namespace App_Venta
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barAgregarCliente = new DevExpress.XtraBars.BarButtonItem();
            this.barAgregarProductos = new DevExpress.XtraBars.BarButtonItem();
            this.barAgregarCategoria = new DevExpress.XtraBars.BarButtonItem();
            this.barAgrregarVentas = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ContenedorFormulario = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.barUsuario = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContenedorFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barAgregarCliente,
            this.barAgregarProductos,
            this.barAgregarCategoria,
            this.barAgrregarVentas,
            this.barUsuario});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.Size = new System.Drawing.Size(1013, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barAgregarCliente
            // 
            this.barAgregarCliente.Caption = "AGREGAR CLIENTES";
            this.barAgregarCliente.Id = 1;
            this.barAgregarCliente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAgregarCliente.ImageOptions.Image")));
            this.barAgregarCliente.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barAgregarCliente.ImageOptions.LargeImage")));
            this.barAgregarCliente.Name = "barAgregarCliente";
            this.barAgregarCliente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barAgregarCliente_ItemClick);
            // 
            // barAgregarProductos
            // 
            this.barAgregarProductos.Caption = "AGREGAR PRODUCTO";
            this.barAgregarProductos.Id = 2;
            this.barAgregarProductos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAgregarProductos.ImageOptions.Image")));
            this.barAgregarProductos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barAgregarProductos.ImageOptions.LargeImage")));
            this.barAgregarProductos.Name = "barAgregarProductos";
            this.barAgregarProductos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barAgregarProductos_ItemClick);
            // 
            // barAgregarCategoria
            // 
            this.barAgregarCategoria.Caption = "AGREGAR CATEGORIA";
            this.barAgregarCategoria.Id = 3;
            this.barAgregarCategoria.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAgregarCategoria.ImageOptions.Image")));
            this.barAgregarCategoria.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barAgregarCategoria.ImageOptions.LargeImage")));
            this.barAgregarCategoria.Name = "barAgregarCategoria";
            this.barAgregarCategoria.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barAgregarCategoria_ItemClick);
            // 
            // barAgrregarVentas
            // 
            this.barAgrregarVentas.Caption = "AGREGAR VENTA";
            this.barAgrregarVentas.Id = 4;
            this.barAgrregarVentas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAgrregarVentas.ImageOptions.Image")));
            this.barAgrregarVentas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barAgrregarVentas.ImageOptions.LargeImage")));
            this.barAgrregarVentas.Name = "barAgrregarVentas";
            this.barAgrregarVentas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barAgrregarVentas_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "CLientes";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barAgregarCliente);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "GESTIONAR CLIENTES";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "PRODUCTOS";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barAgregarProductos);
            this.ribbonPageGroup2.ItemLinks.Add(this.barAgregarCategoria);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "GESTIONAR PRODUCTOS";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "VENTAS";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barAgrregarVentas);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "GESTIONAR VENTAS";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "USUARIOS";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barUsuario);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "GESTIONAR USUARIOS";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 557);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1013, 24);
            // 
            // ContenedorFormulario
            // 
            this.ContenedorFormulario.MdiParent = this;
            this.ContenedorFormulario.MenuManager = this.ribbon;
            this.ContenedorFormulario.View = this.tabbedView1;
            this.ContenedorFormulario.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // barUsuario
            // 
            this.barUsuario.Caption = "Usuarios";
            this.barUsuario.Id = 5;
            this.barUsuario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barUsuario.ImageOptions.Image")));
            this.barUsuario.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barUsuario.ImageOptions.LargeImage")));
            this.barUsuario.Name = "barUsuario";
            this.barUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barUsuario_ItemClick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 581);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FasMarket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContenedorFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barAgregarCliente;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Docking2010.DocumentManager ContenedorFormulario;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem barAgregarProductos;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barAgregarCategoria;
        private DevExpress.XtraBars.BarButtonItem barAgrregarVentas;
        private DevExpress.XtraBars.BarButtonItem barUsuario;
    }
}