using App_Venta.venta;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Venta
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        #region Mis metodos
        private void Habilitar_De(bool v)
        {
            btnNuevo.Enabled = !v;
            btnguardar.Enabled = v;
            btnActualizar.Enabled = !v;
            btnEliminar.Enabled = !v;
            btnCancelar.Enabled = v;
            //searchCategoriaUsuario.Enabled = v;
            //textUsuario.Enabled = v;
            //textContraseña.Enabled = v;
        }

        private void limpiar()
        {
            searchCategoriaUsuario.EditValue = null;
            textContraseña.Clear();
            textUsuario.Clear();
        }

        private bool CajasVacias()
        {
            if (searchCategoriaUsuario.EditValue == null ||
                textUsuario.Text.Trim().Length == 0 ||
                textContraseña.Text.Trim().Length == 0)
            {
                return true;
            }
            return false;
        }

        #endregion

        Usuario uSr;
        Categoria_usuario cUser;

        private void FrmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
           // ((FrmPrincipal)(this.MdiParent)).barAddUsuarios = true;

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
           Habilitar_De(false);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar_De(true);
            limpiar();
            //uSr = new Usuario(sesionventa);

        }

        private void btnguardar_Click(object sender, EventArgs e)
        { 
            try
            {
                if (CajasVacias())
                {
                    MessageBox.Show("Llenar todos los campos", "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Crear una nueva unidad de trabajo
                using (UnitOfWork sesion = new UnitOfWork(sesionventa.DataLayer))
                {
                    // Validar unicidad del campo Usuario1
                    var existingUser = sesion.FindObject<Usuario>(CriteriaOperator.Parse("Usuario1 == ?", textUsuario.Text));
                    if (existingUser != null)
                    {
                        MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Crear un nuevo usuario
                    Usuario u = new Usuario(sesion)
                    {
                        Usuario1 = textUsuario.Text,
                        Password = textContraseña.Text,
                        Idcategoria_usuario = sesion.GetObjectByKey<Categoria_usuario>(((Categoria_usuario)searchLookCategoriaUser.GetFocusedRow()).Idcategoria_usuario),
                        Estado = true
                    };

                    // Guardar el nuevo usuario en la base de datos
                    u.Save();
                    sesion.CommitChanges();

                    // Recargar los datos de la vista
                    xpUsuarios.Reload();
                    gridViewUsuario.RefreshData();

                    // Limpiar y deshabilitar controles
                    limpiar();
                    Habilitar_De(false);

                    MessageBox.Show("Usuario Guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se puede agregar registro de usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            Habilitar_De(false);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            uSr = (Usuario) gridViewUsuario.GetFocusedRow();

            DialogResult Respuesta;
            Respuesta = MessageBox.Show("Estas seguro de eliminar este usuario", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Respuesta == DialogResult.Yes)
            {
                uSr.Estado = false;
                uSr.Save();
                sesionventa.CommitChanges();
                
            }
        }

        private void gridUsuario_DoubleClick(object sender, EventArgs e)
        {
            uSr = (Usuario)gridViewUsuario.GetFocusedRow();

            if (uSr != null)
            {
                cUser = (Categoria_usuario) sesionventa.GetObjectByKey<Categoria_usuario>(uSr.Idcategoria_usuario.Idcategoria_usuario);
                searchCategoriaUsuario.EditValue = cUser.Idcategoria_usuario;
                textUsuario.Text = uSr.Usuario1;
                textContraseña.Text = uSr.Password;

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (UnitOfWork sesion = new UnitOfWork(sesionventa.DataLayer))
            {
                Usuario u = uSr;
                try
                {
                    if (CajasVacias())
                    {
                        MessageBox.Show("Seleccione un registro para actualizar.", "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Recuperar el objeto completo en la nueva sesión
                    u = sesion.GetObjectByKey<Usuario>(u.IdUsuario);

                    // Actualizar los campos
                    u.Usuario1 = textUsuario.Text;
                    u.Password = textContraseña.Text;
                    u.Idcategoria_usuario = sesion.GetObjectByKey<Categoria_usuario>(u.Idcategoria_usuario.Idcategoria_usuario);
                    u.Estado = true;

                    // Guardar los cambios en la base de datos
                    u.Save();
                    sesion.CommitChanges();

                    // Recargar los datos de la sesion 

                    //xpUsuarios.Session = sesion;
                    //xpUsuarios.Reload();

                    sesionventa.Reload(uSr);
                    gridViewUsuario.RefreshData();
                    // Limpiar y deshabilitar controles
                    limpiar();
                    Habilitar_De(false);

                    MessageBox.Show("Usuario actualizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se puede actualizar el registro de usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}
