using System;
using System.Collections.Generic;
using System.Linq;


namespace Kralj_Nusa_Alja
{
	public class Zreb : IZreb
	{

		private DateTime casovniZigZreba;
		private bool izveden;
		private List<Kombinacija> vplacaneKombinacije;
		private int dobitniSklad;
		private List<DobitnaKombinacija> dobitneKombinacije;
		private int koncniSaldo;
		private List<int> izzrebanaStevila;

		public DateTime CasovniZigZreba { get { return casovniZigZreba; } set { casovniZigZreba = value; } }
		public bool Izveden { get { return izveden; } set { izveden = value; } }
		public List<Kombinacija> VplacaneKombinacije { get { return vplacaneKombinacije; } set { vplacaneKombinacije = value; } }
		public int DobitniSklad { get { return  dobitniSklad; } set {  dobitniSklad = value; } }
		public List<DobitnaKombinacija> DobitneKombinacije { get { return dobitneKombinacije; } set { dobitneKombinacije = value; } }
		public int KoncniSaldo { get { return koncniSaldo; } set { koncniSaldo = value; } }
		public List<int> IzzrebanaStevila { get { return izzrebanaStevila; } set { izzrebanaStevila = value; } }

        public Zreb(DateTime casovniZigZreba, bool izveden, List<Kombinacija> vplacaneKombinacije, int dobitniSklad, List<DobitnaKombinacija> dobitneKombinacije, int koncniSaldo, List<int> izzrebanaStevila)
        {
            CasovniZigZreba = casovniZigZreba;
            Izveden = izveden;
            VplacaneKombinacije = vplacaneKombinacije;
            DobitniSklad = dobitniSklad;
            DobitneKombinacije = dobitneKombinacije;
            KoncniSaldo = koncniSaldo;
            IzzrebanaStevila = izzrebanaStevila;
        }

        public Zreb()
		{
		}

		//interface metode
		void IZreb.vplaciloKombinacije(List<Kombinacija> listKombinacija, Kombinacija kombinacija)
		{
			listKombinacija.Add(kombinacija);
		}
		void IZreb.nakljucnaVplacila(Zreb zreb)
		{

		}
		void IZreb.priprava()
		{
		}
		void IZreb.izvedba(Zreb zreb)
		{
		}

		//lambda
		void NajvecjiDobitniSklad(Loterija loterija)
		{
           // return loterija.OrderBy(x => x.SeznamZrebanj).Last();
		}




	}
}

