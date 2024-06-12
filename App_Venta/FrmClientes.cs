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
using App_Venta.REPORTES;

namespace App_Venta
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void HabilitarControles(bool v)
        {
            btnNuevo.Enabled = !v;
            btnGuardar.Enabled = v;
            btnCancelar.Enabled = v;
            txtNombre.Enabled = v;
            txtApellido.Enabled = v;
            txtDireccion.Enabled = v;
            comboSexo.Enabled = v;
        }

        private void Limpiar (){
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            comboSexo.Text = string.Empty;
        }

        private bool CajasVacias()
        {
            if (txtNombre.Text.Trim().Length == 0 ||
                txtApellido.Text.Trim().Length == 0 ||
                txtDireccion.Text.Trim().Length == 0 ||
                comboSexo.Text.Trim().Length == 0){
                return true;
            }
            return false;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            HabilitarControles(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(false);
            Limpiar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControles(true);
            Limpiar();
           

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente oCl = new Cliente(sesionventa);

            try
            {
                if (CajasVacias())
                {
                    MessageBox.Show("Llenar todos los campos", "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                oCl.Nombre = txtNombre.Text;
                oCl.Apellido = txtApellido.Text;
                oCl.Direccion = txtDireccion.Text;
                oCl.Sexo = comboSexo.Text;
                oCl.Estado = true;

                oCl.Save();
                sesionventa.CommitChanges();
                MessageBox.Show("Registro Guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpClientes.Reload();

            }
            catch (Exception)
            {
                MessageBox.Show("Categoría no guardadada...", "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            HabilitarControles(false);
            Limpiar();
        }

        private void FrmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((FrmPrincipal)(this.MdiParent)).barAddCliente = true;
        }

        private void btnReporte_Cliente_Click(object sender, EventArgs e)
        {
            xrFrmClientecs ObCl = new xrFrmClientecs();
            ObCl.ShowDialog();
            
        }
    }
}
