using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace App_Venta
{
    public partial class Frm_DashBoard : Form
    {

        public Frm_DashBoard()
        {
            InitializeComponent();
        }
        #region "Mis variables"
        private Form activeForm = null;

        #endregion
        #region "Mis metodos"

        public void openChildForm(Form childFrom)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            Pnl_cuerpo.Controls.Add(childFrom);
            childFrom.BringToFront();
            childFrom.Show();

        }

        private void Panelessubopciones(int opcion)
        {


            switch (opcion)
            {
                case 1:
                    if (this.Panel_Procesos.Visible == true)
                    {
                        this.Panel_Procesos.Visible = false;
                    }
                    else
                    {
                        this.Panel_Procesos.Visible = true;
                    }

                    //Poner los demas paneles de opciones ocultos
                    this.Panel_DatosM.Visible = false;
                    //this.Pnl_datos_maestros.Visible = false;
                    //this.Pnl_sistemas.Visible = false;

                    break;
                case 2:
                    if (this.Panel_DatosM.Visible == true)
                    {
                        this.Panel_DatosM.Visible = false;
                    }
                    else
                    {
                        this.Panel_DatosM.Visible = true;
                    }
                    //Poner los demas paneles de opciones ocultos
                    this.Panel_Procesos.Visible = false;
                    //this.Pnl_datos_maestros.Visible = false;
                   // this.Pnl_sistemas.Visible = false;
                    break;
                case 3:
                    /*if (this.Pnl_datos_maestros.Visible == true)
                    {
                        this.Pnl_datos_maestros.Visible = false;
                    }
                    else
                    {
                        this.Pnl_datos_maestros.Visible = true;
                    }
                    //Poner los demas paneles de opciones ocultos
                    this.Pnl_reportes.Visible = false;
                    this.Pnl_procesos.Visible = false;
                    this.Pnl_sistemas.Visible = false;*/
                    break;
                case 4:
                   /* if (this.Pnl_sistemas.Visible == true)
                    {
                        this.Pnl_sistemas.Visible = false;
                    }
                    else
                    {
                        this.Pnl_sistemas.Visible = true;
                    }
                    //Poner los demas paneles de opciones ocultos
                    this.Pnl_reportes.Visible = false;
                    this.Pnl_datos_maestros.Visible = false;
                    this.Pnl_procesos.Visible = false;*/
                    break;
                default:
                    MessageBox.Show("Ocurrio un error, disculpe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_fecha.Text = DateTime.Now.ToLongDateString();
            Lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Btn_Procesos_Click(object sender, EventArgs e)
        {
            this.Panelessubopciones(1);

        }

        private void Btn_DatosM_Click(object sender, EventArgs e)
        {
            this.Panelessubopciones(2);

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProductos());

        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            openChildForm(new Categorias());

        }

        private void Pnl_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmClientes());

        }

        private void Panel_DatosM_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSalida_p_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmVenta());

        }

        private void BtnEntrada_p_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmUsuarios());

        }

        private void Respaldo(string ruta)
        {
            string constring = "Server=localhost;Database=venta;Uid=root; Password=root";
            string file = ruta;
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        
                        conn.Close();
                    }
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Realizando respaldo de base de datos.";
            save.Filter = "Respaldo SQL|*.sql";
            save.FileName = "RespaldoVenta" + DateTime.Today.Day.ToString()
                            +"_" + DateTime.Today.Month.ToString() + "_" + DateTime.Today.Year.ToString();

            if(save.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            Respaldo(save.FileName);
            MessageBox.Show("Respaldo realizado correctamente.","Respaldo BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHerramienta_Click(object sender, EventArgs e)
        {

        }

        private void BtnRestaurarBackup_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user=root;pwd=root;database=venta;"; ;

            // Important Additional Connection Options
            constring += "charset=utf8;convertzerodatetime=true;";
            OpenFileDialog open = new OpenFileDialog();
            //open.Title = "Restauracion de base de datos";
            open.Filter = "Respaldo SQL|*.sql";
            if (open.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            //  MessageBox.Show(open.FileName);
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(open.FileName);
                        conn.Close();
                        MessageBox.Show("Restauracion  realizada correctamente");
                    }
                }
            }
        }
    }
}
