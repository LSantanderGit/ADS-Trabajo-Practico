using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucas_M_Santander___Trabajo_Practico
{
    public partial class frmCrearCuenta : Form
    {
        public frmCrearCuenta()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if(!checkErrores())
            {
                ACCESO acceso = new ACCESO();
                acceso.Abrir();
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(acceso.CrearParametro("@nombre", txtNombre.Text));
                parametros.Add(acceso.CrearParametro("@apellido", txtApellido.Text));
                parametros.Add(acceso.CrearParametro("@fechaNacimiento", dtpFechaNacimiento.Value));
                parametros.Add(acceso.CrearParametro("@usuario", txtUsuario.Text));
                parametros.Add(acceso.CrearParametro("@contrasena", txtContrasena.Text));
                int filas = acceso.Escribir("SP_CREAR_USUARIO", parametros);
                acceso.Cerrar();
                if (filas > 0)
                {
                    MessageBox.Show("Cuenta creada con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al crear la cuenta, intente nuevamente");
                }
            }
        }

        private bool checkErrores()
        {
            bool errores = false;
            txtNombre.BackColor = SystemColors.Window;
            txtApellido.BackColor = SystemColors.Window;
            dtpFechaNacimiento.BackColor = SystemColors.Window;
            txtUsuario.BackColor = SystemColors.Window;
            txtContrasena.BackColor = SystemColors.Window;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errores = true;
                txtNombre.BackColor = Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errores = true;
                txtApellido.BackColor = Color.LightCoral;
            }
            if (dtpFechaNacimiento.Value <= DateTime.Now)
            {
                errores = true;
                dtpFechaNacimiento.BackColor = Color.LightCoral;
            }
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
    }
}
