using System;
namespace Kralj_Nusa_Alja
{
	public class Kombinacija
	{
		private int[] seznamIzbranihStevil;
		private DateTime datumVplacila;

		public int[] SeznamIzbranihStevil { get { return seznamIzbranihStevil; } set { seznamIzbranihStevil = value; } }
		public DateTime CasovniZigZreba { get { return datumVplacila; } set { datumVplacila = value; } }

        public Kombinacija(int[] seznamIzbranihStevil, DateTime casovniZigZreba)
        {
            SeznamIzbranihStevil = seznamIzbranihStevil;
            CasovniZigZreba = casovniZigZreba;
        }

        public Kombinacija()
		{
		}
	}
}

