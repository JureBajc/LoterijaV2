using System;
namespace Kralj_Nusa_Alja
{
	public class DobitnaKombinacija : Kombinacija
	{

		private int vrednostDobitka;
		private int steviloIzzrebanihStevil;
		private List<int> izzrebanaStevila;


		public int VrednostDobitka { get { return vrednostDobitka; } set { vrednostDobitka = value; } }
		public int SteviloIzzrebanihStevil { get { return steviloIzzrebanihStevil; } set { steviloIzzrebanihStevil = value; } }
		public List<int> IzzrebanaStevil { get { return izzrebanaStevila; } set { izzrebanaStevila = value; } }

        public DobitnaKombinacija(int[] seznamIzbranihStevil, DateTime casovniZigZreba,int vrednostDobitka, int steviloIzzrebanihStevil, List<int> izzrebanaStevil):base(seznamIzbranihStevil, casovniZigZreba)
        {
            VrednostDobitka = vrednostDobitka;
            SteviloIzzrebanihStevil = steviloIzzrebanihStevil;
            IzzrebanaStevil = izzrebanaStevil;
        }

        public DobitnaKombinacija()
		{
		}
	}
}

