using System;

namespace Kralj_Nusa_Alja
{
     class Program
    {
        static void Main(string[] args)
        {

            int[] sseznamIzbranihstevil = { 10, 20, 30, 40,4,5,3 };
            Kombinacija kombinacija1 = new Kombinacija(sseznamIzbranihstevil, new DateTime(2022, 2, 1));

            List<int> izzrebanastevila = new List<int>();
            izzrebanastevila.Add(2);
            izzrebanastevila.Add(26);
            izzrebanastevila.Add(7);
            izzrebanastevila.Add(8);
            izzrebanastevila.Add(3);

            List<Kombinacija> seznam_kombinacij = new List<Kombinacija>();
            seznam_kombinacij.Add(kombinacija1);

            DobitnaKombinacija dobitnakombinacija1 = new DobitnaKombinacija(sseznamIzbranihstevil, new DateTime(2022, 3, 1),30,2,izzrebanastevila);


            List<int> izzrebanastevilazreb = new List<int>();
            izzrebanastevilazreb.Add(2);
            izzrebanastevilazreb.Add(26);
            izzrebanastevilazreb.Add(7);
            izzrebanastevilazreb.Add(8);
            izzrebanastevilazreb.Add(3);


            List<DobitnaKombinacija> seznam_dkombinacij = new List<DobitnaKombinacija>();
            seznam_dkombinacij.Add(dobitnakombinacija1);

            Zreb zreb1 = new Zreb(new DateTime(2022, 1, 1),true, seznam_kombinacij, 10000, seznam_dkombinacij, 4, izzrebanastevilazreb);

            List<Zreb> seznam_zrebov = new List<Zreb>();
            seznam_zrebov.Add(zreb1);

            SkupekStevil skupekstevil1 = new SkupekStevil(12, 13);


            AbsulutniDobitek absulutnidobitek1 = new AbsulutniDobitek(12, 3);

            List<Dobitek> seznam_dobitkov = new List<Dobitek>();
            seznam_dobitkov.Add(absulutnidobitek1);


            Loterija loterija1 = new Loterija("loterija1",10000000,seznam_zrebov,skupekstevil1,30,23, seznam_dobitkov, 20000);
            Loterija loterija2 = new Loterija();


            Oseba janez = new Oseba("Janez", "Novak");
            janez.PrijaviSeNaObvestila(loterija1);

            loterija1.sporociloNarocnikom("lol");

        }
    }
}