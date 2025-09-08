using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucas_M_Santander___Trabajo_Practico
{
    public partial class frmLogin : Form
    {
        private JUEGO juego;

        public JUEGO Juego
        {
            get { return juego; }
            set { juego = value; }
        }

        private bool jugador1;

        public bool Jugador1
        {
            get { return jugador1; }
            set { jugador1 = value; }
        }


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogearse_Click(object sender, EventArgs e)
        {
            if(!checkErrores())
            {
                List<SqlParameter> parametros = new List<SqlParameter>();

                ACCESO acceso = new ACCESO();
                acceso.Abrir();

                parametros.Add(acceso.CrearParametro("@usu", txtUsuario.Text));
                parametros.Add(acceso.CrearParametro("@pass", txtContrasena.Text));
                int resultado = acceso.LeerEscalar("CUENTA_LOGIN", parametros);
                if (resultado > 0)
                {
                    DataTable tablaCuenta = acceso.Leer("CUENTA_GET_BY_USER_PASSWORD", parametros);

                    if (tablaCuenta.Rows.Count < 0)
                    {
                        CUENTA cuenta = getCuentaUsuario(tablaCuenta);

                        if (jugador1)
                        {
                            juego.Jugador1 = cuenta;
                        }
                        else
                        {
                            juego.Jugador2 = cuenta;
                        }
                        MessageBox.Show("Login exitoso");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error inesperado. Intentelo nuevamente");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contrasena incorrectos");
                }
                acceso.Cerrar();
            }
        }

        private CUENTA getCuentaUsuario(DataTable tablaCuenta)
        {
            DataRow row = tablaCuenta.Rows[0];
            CUENTA cuenta = new CUENTA(
                row["nombre"].ToString(),
                row["apellido"].ToString(),
                DateTime.Parse(row["fechaNacimiento"].ToString()),
                row["usuario"].ToString(),
                row["contrasena"].ToString()
                //DateTime.Parse(row["tiempoJuego"].ToString())
            );
            return cuenta;
        }

        private bool checkErrores()
        {
            bool errores = false;
            txtUsuario.BackColor = SystemColors.Window;
            txtContrasena.BackColor = SystemColors.Window;
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                errores = true;
                txtUsuario.BackColor = Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                errores = true;
                txtContrasena.BackColor = Color.LightCoral;
            }
            return errores;
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            frmCrearCuenta frm = new frmCrearCuenta();
            frm.ShowDialog();
        }
    }
}
