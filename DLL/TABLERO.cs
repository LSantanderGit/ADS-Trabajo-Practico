using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL
{
    public class TABLERO
    {
		private ESPACIO[] espacios;

		public ESPACIO[] Espacios
		{
			get { return espacios; }
			set { espacios = value; }
		}
	}
}