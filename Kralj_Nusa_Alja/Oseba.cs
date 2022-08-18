using System;
namespace Kralj_Nusa_Alja
{
	 class Oseba
	{

		private string osebaIme;
		private string osebaPriimek;

		public string OsebaIme { get { return osebaIme; } set { osebaIme = value; } }
		public string OsebaPriimek { get { return osebaPriimek; } set { osebaPriimek = value; } }

        public Oseba(string osebaIme, string osebaPriimek)
        {
            OsebaIme = osebaIme;
            OsebaPriimek = osebaPriimek;
        }

        public Oseba()
		{
		}

		public void PrijaviSeNaObvestila(Loterija loterija)
		{
			loterija.dogodek += sporocilo;
		}

		public void sporocilo(string sporocilo, string osebaIme)
		{
			Console.WriteLine("Zdravo " + OsebaIme+" Žreb-"+/*casovniZigZreba+ */",V igri je bilo kar " +/*dobitni sklad+*/"€. Izzrebane stevilke so bile:");
			/*seznamizzrebanihstevil.forEach(element => console.log(element));*/
		}

	}
}

