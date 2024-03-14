using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLinq
{
	public class Employe : Personne
	{
		//accesseur
		public double Salaire { get; set; }

		//constructeur
		public Employe(string nom, string prenom, DateOnly ddn, double salaire) : base(nom, prenom, ddn) 
		{
		Salaire = salaire;
		}

		//méthode
		public override string Afficher()
		{
			return string.Format("{0}, salaire : {1:N} euros", base.Afficher(), Salaire);
		}
		public override string ToString()
		{
			return Afficher();
		}
	}
}
