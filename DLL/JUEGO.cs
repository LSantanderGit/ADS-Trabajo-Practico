using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL
{
    public class JUEGO
    {
		private CUENTA jugador1;

		public CUENTA Jugador1
        {
			get { return jugador1; }
			set { jugador1 = value; }
		}

        private CUENTA jugador2;

        public CUENTA Jugador2
        {
            get { return jugador2; }
            set { jugador2 = value; }
        }
    }
}