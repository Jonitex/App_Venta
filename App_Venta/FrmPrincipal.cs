using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Venta.venta;


namespace App_Venta
{
    public partial class FrmPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void barAgregarCliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmClientes fC = new FrmClientes();
            fC.MdiParent = this;
            fC.Show();
            barAddCliente = false;
        }

        public bool barAddCliente
        {
            set { barAgregarCliente.Enabled = value; }
        }
        public bool barAddProducto
        {
            set { barAgregarProductos.Enabled = value; }
        }
        public bool barAddCategoria
        {
            set { barAgregarCategoria.Enabled = value; }
        }
        public bool barAddVenta
        {
            set { barAgregarCategoria.Enabled = value; }
        }
        public bool barAddUsuarios
        {
            set { barUsuario.Enabled = value; }
        }

        private void barAgregarProductos_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmProductos fC = new FrmProductos();
            fC.MdiParent = this;
            fC.Show();
            barAddProducto = false;
        }

        private void barAgregarCategoria_ItemClick(object sender, ItemClickEventArgs e)
        {
            Categorias OCa = new Categorias();
            OCa.MdiParent = this;
            OCa.Show();
            barAddCategoria = false;
        }

        private void barAgrregarVentas_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmVenta oV = new FrmVenta();
            oV.MdiParent = this;
            oV.Show();
            barAddVenta = false;
        }

        private void barUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmUsuarios oV = new FrmUsuarios();
            oV.MdiParent = this;
            oV.Show();
            barAddUsuarios = false;
        }
    }
}