using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLinq
{
	public class Personne : IHumain	
	{
		//accesseur
		public string Nom { get; set; }
		public string Prenom { get; set; }
		public DateOnly Ddn { get; set; }

		//constructeur
		public Personne(string nom, string prenom, DateOnly ddn)
		{
			Nom = nom;
			Prenom = prenom;
			Ddn = ddn;
		}

		//méthodes
		public virtual string Afficher()
		{
			return string.Format("Nom: {0}, Prénom: {1}, Date de naissance: {2}", Nom, Prenom, Ddn);
		}
		public override string ToString()
		{
			return $"Nom: {Nom}, Prénom: {Prenom}, Date de naissance: {Ddn}";
		}
	}

	
}
