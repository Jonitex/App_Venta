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
using DevExpress.DataAccess.Sql;
using DevExpress.Utils.Extensions;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace App_Venta
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();


        }

        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            Producto p;

            if (editar)
            {
                p = pe;
            }
            else
            {
                p = new Producto(sesionventa);
            }

            try
            {

                if (string.IsNullOrEmpty(searchCategorias.Text))
                {
                    MessageBox.Show("Debe de ingresar un nombre", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchCategorias.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Debe de ingresar un nombre", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(txtFecha.Text))
                {
                    MessageBox.Show("Debe de seleccionar la fecha", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFecha.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Debe de ingresar precio del producto", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrecio.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(txtEstante.Text))
                {
                    MessageBox.Show("Debe ingresar el número de estante", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEstante.Focus();
                    return;
                }

                p.Nombre = txtNombre.Text;
                p.Fecha_Vencimiento = txtFecha.DateTime;
                p.Precio = float.Parse(txtPrecio.Text);
                p.Estante = int.Parse(txtEstante.Text);

                //capturar categoria

                if (editar)
                {
                    p.Idcategoria = ca;
                }
                else
                {
                    p.Idcategoria = (Categoria)searchCategoriaView.GetFocusedRow();
                }

                p.Save();
                sesionventa.CommitChanges();
                xpProductos.Reload();
                if (editar)
                {
                    MessageBox.Show("Producto actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show("Producto guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Producto no guardado... La causa de este error es porque el producto ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                p = null;
                pe = null;
                ca = null;
                editar = false;
            }
        }

        Producto pe;
        Categoria ca;
        bool editar = false;
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            pe = (Producto)gridViewproductos.GetFocusedRow();

            if (pe != null)
            {
                txtNombre.Text = pe.Nombre;
                txtPrecio.Text = pe.Precio.ToString();
                txtEstante.Text = pe.Estante.ToString();
                txtFecha.Text = pe.Fecha_Vencimiento.ToShortDateString();
                ca = (Categoria)sesionventa.GetObjectByKey<Categoria>(pe.Idcategoria.Idcategoria);
                searchCategorias.EditValue = ca.Idcategoria;

                editar = true;
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            

            pe = (Producto)gridViewproductos.GetFocusedRow();

            DialogResult Respuesta;
            Respuesta = MessageBox.Show("Estas seguro que quieres eliminar este producto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Respuesta == DialogResult.Yes)
            {
                pe.Estado = false ;
                pe.Save();
                sesionventa.CommitChanges();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void FrmProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((FrmPrincipal)(this.MdiParent)).barAddProducto = true;

        }
    }
}