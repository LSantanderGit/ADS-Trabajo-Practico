using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL
{
    public class TURNO
    {
		private USUARIO jugador;

		public USUARIO Jugador
		{
			get { return jugador; }
			set { jugador = value; }
		}

		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		private DateTime fechaHora;

		public DateTime FechaHora
		{
			get { return fechaHora; }
			set { fechaHora = value; }
		}
	}
}