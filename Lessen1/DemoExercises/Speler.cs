using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExercises
{
    class Speler
    {
		private string voornaam;

		public string Voornaam
		{
			get { return voornaam; }
			set { voornaam = value; }
		}
		private string familieNaam;

		public	string FamilieNaam
		{
			get { return familieNaam; }
			set { familieNaam = value; }
		}

		private int geboorteJaar;


        public int GeboorteJaar
		{
			get { return geboorteJaar; }
			set { geboorteJaar = value; }
		}

        public Speler(string voornaam, string familieNaam, int geboorteJaar)
        {
            Voornaam = voornaam;
            FamilieNaam = familieNaam;
            GeboorteJaar = geboorteJaar;
        }
    }
}
