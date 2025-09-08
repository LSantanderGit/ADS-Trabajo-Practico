using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL
{
    public class TABLERO
    {
		private CASILLERO[] espacios;

		public CASILLERO[] Espacios
		{
			get { return espacios; }
			set { espacios = value; }
		}
	}
}