using System;
namespace Kralj_Nusa_Alja
{
	public abstract class Dobitek
	{
		private int steviloIzzrebanih;

		public int SteviloIzzrebanih { get { return steviloIzzrebanih; } set { steviloIzzrebanih = value; } }

        protected Dobitek(int steviloIzzrebanih)
        {
            SteviloIzzrebanih = steviloIzzrebanih;
        }

        public Dobitek()
		{
		}
	}
}

