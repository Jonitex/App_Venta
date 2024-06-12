using App_Venta.venta;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region
        private void Login_us(string cLogin, string cPassword)
        {
            try
            {
                // Crear una sesión de XPO
                using (Session session = new Session())
                {
                    // Obtener la colección de usuarios
                    XPCollection<Usuario> usuarios = new XPCollection<Usuario>(session);

                    // Filtrar usuarios por login y password
                    var usuario = usuarios.FirstOrDefault(u => u.Usuario1 == cLogin && u.Password == cPassword);

                    if (usuario != null)
                    {
                        string cNombres = usuario.Usuario1;
                        string cargo = usuario.Idcategoria_usuario.Categoria;
                        //bool bAdmin = usuario.Admin;

                        Frm_DashBoard oDashBoard = new Frm_DashBoard();
                        oDashBoard.Lbl_nombres_us.Text = "Nombres: " + cNombres;
                        oDashBoard.Lbl_cargo.Text = "Cargo: " + cargo;
                        //oDashBoard.Chk_admin.Checked = bAdmin;

                        if (cargo == "ADMINISTRADOR")
                        {
                            // Administrador
                            oDashBoard.Btn_Procesos.Enabled = true;
                            oDashBoard.Btn_DatosM.Enabled = true;
                            oDashBoard.btnUsuarios.Enabled = true;
                        }
                        else if (cargo == "REGENTE")
                        {
                            // Usuario Regente
                            oDashBoard.Btn_Procesos.Enabled = true;
                            oDashBoard.Btn_DatosM.Enabled = true;
                            oDashBoard.btnUsuarios.Visible = false;
                        }
                        else
                        {
                            // Administrador
                            oDashBoard.Btn_Procesos.Enabled = true;
                            oDashBoard.BtnEntrada_p.Visible = false;
                            oDashBoard.Btn_DatosM.Visible = false;
                            oDashBoard.btnUsuarios.Visible = false;
                        }

                        oDashBoard.Show();
                        oDashBoard.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Acceso errado", "Aviso del Sistema");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Clear();
            txtPassword.Clear();
            this.Show();
            txtUsuario.Focus();
        }

        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Login_us(txtUsuario.Text, txtPassword.Text);
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
