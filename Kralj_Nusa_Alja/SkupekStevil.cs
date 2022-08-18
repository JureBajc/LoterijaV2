using System;
namespace Kralj_Nusa_Alja
{
	public class SkupekStevil
	{


		private int naborVrednostiMin;
		private int naborVrednostiMax;

		public int NaborVrednostiMin { get { return naborVrednostiMin; } set { naborVrednostiMin = value; } }
		public int NaborVrednostiMax { get { return naborVrednostiMax; } set { naborVrednostiMax = value; } }

        public SkupekStevil(int naborVrednostiMin, int naborVrednostiMax)
        {
            NaborVrednostiMin = naborVrednostiMin;
            NaborVrednostiMax = naborVrednostiMax;
        }

        public SkupekStevil()
		{
		}
	}
}

