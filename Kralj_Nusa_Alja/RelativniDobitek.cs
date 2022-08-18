using System;
namespace Kralj_Nusa_Alja
{
	public class RelativniDobitek : Dobitek
	{
		private int odstotekDobitnegaSklada;

		public int OdstotekDobitnegaSklada { get { return odstotekDobitnegaSklada; } set { odstotekDobitnegaSklada = value; } }

        public RelativniDobitek(int steviloIzzrebanih,int odstotekDobitnegaSklada):base(steviloIzzrebanih)
        {
            OdstotekDobitnegaSklada = odstotekDobitnegaSklada;
        }

        public RelativniDobitek()
		{
		}
	}
}

