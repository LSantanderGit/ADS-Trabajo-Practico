using Lucas_M_Santander___Trabajo_Practico;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DLL
{
    public class CUENTA
    {
		//public CUENTA(string pNombre, string pApellido, DateTime pFechaNacimiento, string pUsuario, string pContrasena, DateTime pTiempoJuego)
		public CUENTA(string pNombre, string pApellido, DateTime pFechaNacimiento, string pUsuario, string pContrasena)
        {
			nombre = pNombre;
			apellido = pApellido;
			fechaNacimiento = pFechaNacimiento;
			usuario = pUsuario;
            contrasena = pContrasena;
			//tiempoJuego = pTiempoJuego;
        }

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string apellido;

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		private DateTime fechaNacimiento;

		public DateTime FechaNacimiento
		{
			get { return fechaNacimiento; }
			set { fechaNacimiento = value; }
		}

		private string usuario;

		public string Usuario
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string contrasena;

		public string Contrasena
		{
			get { return contrasena; }
			set { contrasena = value; }
		}

		//private DateTime tiempoJuego;

		//public DateTime TiempoJuego
		//{
		//	get { return tiempoJuego; }
		//	set { tiempoJuego = value; }
		//}
    }
}