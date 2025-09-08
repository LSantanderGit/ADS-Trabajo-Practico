using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL
{
    public class TURNO
    {
		private CUENTA[] jugadores;

		public CUENTA[] Jugadores
		{
			get { return jugadores; }
			set { jugadores = value; }
		}
	}
}