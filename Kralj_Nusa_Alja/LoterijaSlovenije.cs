using System;
namespace Kralj_Nusa_Alja
{
	 class LoterijaSlovenije
	{

		private List<Loterija> loterije;

		public List<Loterija> Loterije { get { return loterije; } set { loterije = value; } }

        public LoterijaSlovenije(List<Loterija> loterije)
        {
            Loterije = loterije;
        }

        public LoterijaSlovenije()
		{
		}
	}
}

