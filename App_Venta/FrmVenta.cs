using App_Venta.venta;
using DevExpress.XtraGrid.Blending;
using DevExpress.XtraGrid.Design;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.Utils;
using DevExpress.Data.Filtering;
using DevExpress.DataAccess.Excel;
using DevExpress.Xpo;
using App_Venta.REPORTES;



namespace App_Venta
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }
        #region Mis metodos

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Habilitar_De(bool v)
        {
            btnNuevo.Enabled = !v;
            btnAgregar.Enabled = v;
            btnGuardar.Enabled = v;
            btnCancelar.Enabled = v;
            searchLookCliente.Enabled = v;
            searchLookUpProducto.Enabled = v;
            txtCantidad.Enabled = v;
            txtDescuento.Enabled = v;
            txtFecha.Enabled = v;

        }
        private void limpiar()
        {
            searchLookCliente.EditValue = null;
            searchLookUpProducto.EditValue = null;
            txtCantidad.Clear();
            txtDescuento.Clear();
            txtSubTotal.Text = "0.00";
            txtPrecio.Text = "0.00";
            txtMontoTotal.Text = "0.00";
            griddetalle.DataSource = null;

        }
        private bool CajasVacias()
        {
            if (
                txtMontoTotal.Text.Trim().Length == 0 ||
                searchLookCliente.EditValue == null ||
                txtPrecio.Text.Trim().Length == 0 ||
                txtFecha.Text.Trim().Length == 0)
            {
                return true;
            }
            return false;
        }

        private void gridDetalle ()
        {
            gridViewDetalleVenta.Columns[0].Visible = false;
            gridViewDetalleVenta.Columns[3].Visible = false;
            gridViewDetalleVenta.Columns[5].Visible = false;
            gridViewDetalleVenta.Columns[6].Visible = false;

            gridViewDetalleVenta.Columns[1].VisibleIndex = 1;
            gridViewDetalleVenta.Columns[2].VisibleIndex = 2;
            gridViewDetalleVenta.Columns[4].VisibleIndex = 0;

            gridViewDetalleVenta.Columns[1].Caption = "CANTIDAD";
            gridViewDetalleVenta.Columns[2].Caption = "SUB-TOTAL";
            gridViewDetalleVenta.Columns[4].Caption = "PRODUCTO";

            gridViewDetalleVenta.Columns[1].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridViewDetalleVenta.Columns[2].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridViewDetalleVenta.Columns[4].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
           
            gridViewDetalleVenta.Columns[4].FieldName = "Producto_Id.Nombre";

        }
        private bool GridDetalleVacio()
        {
            var gridView = griddetalle.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            return gridView == null || gridView.RowCount == 0;
        }

        #endregion
        #region Mis variables
        Venta venta;
        double auxMonto;
        int cantidadPro = 0;

        #endregion

        private void txtDescuento_EditValueChanged(object sender, EventArgs e)
        {

            if (txtDescuento.Text.Trim().Length == 0)
                return;

            int PorDes = Convert.ToInt32(txtDescuento.Text); //Obtiene el porcentaje de descuento
            double Subtotal = Convert.ToDouble(txtSubTotal.Text); //Obtiene la multiplicacion de la cantidad por el precio del producto
            double Descuento = ((0.01 * PorDes) * Subtotal);//Se calcula el descuento
            double MontoTotal = Subtotal - Descuento;
            txtMontoTotal.Text = Convert.ToString(MontoTotal + auxMonto);

        }

        private void txtCantidad_EditValueChanged(object sender, EventArgs e)
        {
            Producto oPr = (Producto)searchProducto.GetFocusedRow();
            if (oPr == null)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtCantidad.Text.Trim().Length == 0)
               return;

            int Cantidad = Convert.ToInt32(txtCantidad.Text);
            auxMonto = Convert.ToDouble(txtMontoTotal.Text);//Obtiene el valor actual del monto total para luego ser evaluado


            // oPr = (Producto)searchLookUpProducto.GetSelectedDataRow();
            txtPrecio.Text = (oPr.Precio).ToString();
            txtSubTotal.Text = (Cantidad * oPr.Precio).ToString();
            
            //Verificamos que el campo txtDescuento este vacio o en cero
            if (txtDescuento.Text.Trim().Length == 0)
                txtDescuento.Text = "0";//Si esta vacio lo igualamos a cero

            int PorDes = Convert.ToInt32(txtDescuento.Text); //Obtiene el porcentaje de descuento
            double Subtotal = Convert.ToDouble(txtSubTotal.Text); //Obtiene la multiplicacion de la cantidad por el precio del producto
            double Descuento = ((0.01 * PorDes) * Subtotal);//Se calcula el descuento
            double MontoTotal = Subtotal - Descuento;
            txtMontoTotal.Text = Convert.ToString(MontoTotal + auxMonto);


        }
        //PROCESO PARA AGRAGAR PRODUCTOS AL DETALLE DEL GRIDCONTROL
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Detalle_venta detalle = new Detalle_venta(sesionventa);
                detalle.Producto_Id = (Producto) searchProducto.GetFocusedRow();//Obtenemos los datos del registro seleccionado en el gridcontrol
                detalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                detalle.Subtotal = float.Parse(txtSubTotal.Text);
                cantidadPro++;
                detalle.Save();
                venta.detalle_ventas.Add(detalle);
                griddetalle.RefreshDataSource();

                //Limpiamos los campos para agregar un nuevo producto al detalle
                searchLookUpProducto.EditValue = null;
                txtCantidad.Clear();
                txtDescuento.Clear();
                txtPrecio.Text = "0.00";
                txtSubTotal.Text = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se puede agregar el detalle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void FrmVenta_Load(object sender, EventArgs e)
        { 
            Habilitar_De(false);
            txtFecha.Text = DateTime.Today.ToString();
            griddetalle.DataSource = null;
            gridDetalle();
       
        }

        // PROCESO PARA EL GUARDADO DE UNA NUEVA VENTA.

        /*private void BindVentaData(Venta venta, UnitOfWork sesion)
        {
            venta.Fecha = DateTime.Parse(txtFecha.Text);
            venta.Descuento = txtDescuento.Text;
            venta.Cantidad = cantidadPro;
            venta.Monto_total = float.Parse(txtMontoTotal.Text);
            venta.Cliente_codigo = sesion.GetObjectByKey<Cliente>(((Cliente)searchCliente.GetFocusedRow()).Codigo);
            venta.Estado = true;
        }*/


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region Codigo comentado anterior en desuso
            
           /* try
            {
                if (CajasVacias() || GridDetalleVacio())
                {
                    MessageBox.Show("Debe llenar todos los campos o agregar al menos un registro al detalle de venta", "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               
                venta.Fecha = DateTime.Parse(txtFecha.Text);
                venta.Descuento = txtDescuento.Text;
                venta.Cantidad = cantidadPro;
                venta.onto_total = float.Parse(txtMontoTotal.Text);
                venta.Cliente_codigo = (Cliente)searchCliente.GetFocusedRow();
                venta.EstaMdo = true;
                venta.Save();

                sesionventa.CommitChanges();

                MessageBox.Show("Venta guardada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se puede realizar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                griddetalle.DataSource = null;
            }

            limpiar();
            venta = null;
            griddetalle.DataSource = null;
            griddetalle.Refresh();

            Habilitar_De(false);*/

            #endregion
            
            try
            {
                //Validamos que las cajas no esten vacías
                if (CajasVacias() || GridDetalleVacio())
                {
                    MessageBox.Show("Debe llenar todos los campos o agregar al menos un registro al detalle de venta", "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //Creamos una nueva sesion a la base de datos y al finalizar de destruye
                using (UnitOfWork sesion = new UnitOfWork(sesionventa.DataLayer))
                {
                    // Crear una nueva instancia de Venta en la nueva sesión
                    Venta nVenta = new Venta(sesion)
                    {
                        Fecha = DateTime.Parse(txtFecha.Text),
                        Descuento = txtDescuento.Text,
                        Cantidad = cantidadPro,
                        Monto_total = float.Parse(txtMontoTotal.Text),
                        Cliente_codigo = sesion.GetObjectByKey<Cliente>(((Cliente)searchCliente.GetFocusedRow()).Codigo),
                        Estado = true
                    };
                    
                    //Recorremos la lista del detalle de venta
                    foreach (var detalle in venta.detalle_ventas)
                    {
                        // Crear una nueva instancia de Detalle_venta en la nueva sesión
                        Detalle_venta nuevoDetalle = new Detalle_venta(sesion)
                        {
                            Producto_Id = sesion.GetObjectByKey<Producto>(detalle.Producto_Id.Id),
                            Cantidad = detalle.Cantidad,
                            Subtotal = detalle.Subtotal
                        };
                        nuevoDetalle.Save();
                        nVenta.detalle_ventas.Add(nuevoDetalle);
                    }

                    nVenta.Save();
                    sesion.CommitChanges();

                    // Recargar la colección vinculada al GridControl
                    xpDetalleVenta.Reload();

                    ShowSuccessMessage("Venta guardada correctamente");
                }
                Habilitar_De(false);
                limpiar();
                venta = new Venta(sesionventa); //Inicializar una nueva instancia de venta si es necesario
                griddetalle.DataSource = null;
                griddetalle.Refresh();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"No se puede realizar la venta: {ex.Message}");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            Habilitar_De(true);
            venta = new Venta(sesionventa);
            griddetalle.DataSource = null;
            griddetalle.Refresh();
            griddetalle.DataSource = venta.detalle_ventas;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        { 
            limpiar();
            Habilitar_De(false);
        }

        private void FrmVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((FrmPrincipal)(this.MdiParent)).barAddVenta = true;

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void griddetalle_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ReporteVenta ObV = new ReporteVenta();
            ObV.ShowDialog();
        }
    }
}
