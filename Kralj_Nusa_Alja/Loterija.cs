using System;
namespace Kralj_Nusa_Alja
{
 class Loterija
	{

		private string ime;
		private int maksimalniNagradniSklad;
		private List<Zreb> seznamZrebanj;
		private SkupekStevil naborStevil;
		private int steviloIzzrebanihStevil;
		private int cenaKombinacije;
		private List<Dobitek> dobitki;
		private int garantiranDobtniSklad;



		public string Ime { get { return ime; } set {  ime= value; } }
		public int MaksimalniNagradniSklad { get { return maksimalniNagradniSklad; } set { maksimalniNagradniSklad = value; } }
		public List<Zreb> SeznamZrebanj { get { return seznamZrebanj; } set { seznamZrebanj = value; } }
		public SkupekStevil NaborStevil { get { return naborStevil; } set { naborStevil = value; } }
		public int SteviloIzzrebanihStevil { get { return steviloIzzrebanihStevil; } set { steviloIzzrebanihStevil = value; } }
		public int CenaKombinacije { get { return cenaKombinacije; } set { cenaKombinacije = value; } }
		public List<Dobitek> Dobitki { get { return dobitki; } set { dobitki = value; } }
		public int GarantiranDobtniSklad { get { return garantiranDobtniSklad; } set { garantiranDobtniSklad = value; } }

        public Loterija(string ime, int maksimalniNagradniSklad, List<Zreb> seznamZrebanj, SkupekStevil naborStevil, int steviloIzzrebanihStevil, int cenaKombinacije, List<Dobitek> dobitki, int garantiranDobtniSklad)
        {
            Ime = ime;
            MaksimalniNagradniSklad = maksimalniNagradniSklad;
            SeznamZrebanj = seznamZrebanj;
            NaborStevil = naborStevil;
            SteviloIzzrebanihStevil = steviloIzzrebanihStevil;
            CenaKombinacije = cenaKombinacije;
            Dobitki = dobitki;
            GarantiranDobtniSklad = garantiranDobtniSklad;
        }

        public Loterija()
		{
		}

		public delegate void LoterijaObvetilo(string x, string y);

		public event LoterijaObvetilo dogodek;

		public void sporociloNarocnikom(string sporocilo)
		{
			dogodek.Invoke(sporocilo,Ime);
		}

	}
}

