using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL
{
    public class USUARIO
    {
		private String nombre;

		public String Nombre
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

		private DateTime tiempoJuego;

		public DateTime TiempoJuego
		{
			get { return tiempoJuego; }
			set { tiempoJuego = value; }
		}

	}
}