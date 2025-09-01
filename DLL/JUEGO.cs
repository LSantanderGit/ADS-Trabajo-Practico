using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL
{
    public class JUEGO
    {
		private USUARIO jugador1;

		public USUARIO Jugador1
        {
			get { return jugador1; }
			set { jugador1 = value; }
		}

        private USUARIO jugador2;

        public USUARIO Jugador2
        {
            get { return jugador2; }
            set { jugador2 = value; }
        }
    }
}