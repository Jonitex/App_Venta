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
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;



namespace App_Venta
{
   
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        #region Mis metodos
       private void Desc_Habilitar(bool v)
        {
            btnNuevo.Enabled = v;
            btneliminar.Enabled = v;
            btnCancelar.Enabled = !v;
            btnguardar.Enabled = !v;
            txtCategoria.Enabled = !v;
        }


        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Desc_Habilitar(false);
            txtCategoria.Clear();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            Desc_Habilitar(true);
            // Establecer el filtro activo para la columna `colEstado`
            //string colEstado = "colEstado"; // Reemplaza esto con el nombre exacto de tu columna
            //gridViewCategoria.ActiveFilterString = $"[{colEstado}] = 1";

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Categoria oCa = new Categoria(sesionventa);
            sesionventa.GetObjectByKey<Categoria>(1);

            try
            {

                if (txtCategoria.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe ingresar una categoría", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCategoria.Focus();
                    return;
                }

                oCa.Nombre = txtCategoria.Text;

                //capturar categoria
                oCa.Save();
                sesionventa.CommitChanges();
                xpCategoria.Reload();
                txtCategoria.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Categoría no guardadada...", "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Desc_Habilitar(true);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Desc_Habilitar(true);
            txtCategoria.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gridCateoria_Click(object sender, EventArgs e)
        {

        }

        private void Categorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((FrmPrincipal)(this.MdiParent)).barAddCategoria = true;

        }
    }
}
