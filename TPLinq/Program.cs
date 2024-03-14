// Sur une liste d'entiers, afficher la somme
using System.Linq;
using TPLinq;

void q1()
{
	List<int> listeEntiers = new List<int> { 1, 34, 21, 71, 98 };
	int somme = listeEntiers.Sum();
	Console.WriteLine(somme);
}
//q1();

//Sur une liste d'entiers, Afficher la moyenne
void q2()
{
	List<int> listeEntiers = new List<int> { 2, 34, 21, 71, 98 };
	double moy = listeEntiers.Average();
	Console.WriteLine(moy);
}
//q2();

//Sur une liste d'entiers, sélectionner que les nombres qui sont > 6
void q3()
{
	List<int> listeEntiers = new List<int> { 2, 34, 21, 71, 98 };
	var selection = listeEntiers.Where(n => n > 6).ToList();
	foreach (int n in selection) Console.WriteLine(n);
}
//q3();

//Sur une liste d'entiers, Compter le nombre d’élément
void q4()
{
	List<int> listeEntiers = new List<int> { 2, 34, 21, 71, 98 };
	Console.WriteLine(listeEntiers.Count);
}
//q4();

//Sur une liste de personne: Les trier avec la méthode OrderBy par le nom puis le prénom
List<Personne> listePersonnes = new List<Personne>()
	{
	new Personne ("1FAVE","Jean", DateOnly.Parse("20/01/1987")),
	new Personne ("Dupont", "Philippe", DateOnly.Parse("20/01/1990")),
	new Employe  ("3DURAND","Julie",DateOnly.Parse("20/10/1987"),35000),
	new Employe ("4POULE", "Karine", DateOnly.Parse("14/01/1987"),45000),
	new Personne ("5FAVE","Jean", DateOnly.Parse("20/01/1987")),
	new Personne ("6DUPONT", "Philippe", DateOnly.Parse("20/01/1990")),
	new Employe  ("7DURAND","Julie",DateOnly.Parse("20/10/1987"),35000),
	new Employe ("8POULE", "Karine", DateOnly.Parse("14/01/1987"),45000),
	new Personne ("9DUPONT", "Philippe", DateOnly.Parse("20/01/1990")),
	new Employe  ("10DURAND","Julie",DateOnly.Parse("20/10/1987"),35000),
	new Employe ("11POULE", "Karine", DateOnly.Parse("14/01/1987"),45000),
	new Personne ("Dupont", "Anne", DateOnly.Parse("20/01/1990"))
	};
void q5()
{
	var liste = listePersonnes.OrderBy(p => p.Nom).ThenBy(p => p.Prenom).ToList();
	foreach (var p in liste) Console.WriteLine(p);
}
//q5();

//Sur une liste de personne: Afficher que les personnes qui ont leurs noms qui commence par D
void q6()
{
	List<Personne> liste = listePersonnes.Where(p => p.Nom.StartsWith("D")).ToList();
	foreach (var p in liste) Console.WriteLine(p);
}
//q6();

//Sur une liste de personne: Afficher que les noms des personnes
void q7()
{
	var liste = listePersonnes.Select(p => p.Nom).ToList();
	foreach (var p in liste) Console.WriteLine(p);
}
//q7();

//Sur une liste de personne: Récupérer que les 2 première personne
void q8()
{
	var liste = listePersonnes.Take(2).ToList();
	foreach (var p in liste) Console.WriteLine(p);
}
//q8();

//Sur une liste de personne: Récupérer les personnes rentrées en 7ème 8ème et 9ème position
void q9()
{
	var liste = listePersonnes.Skip(6).Take(3).ToList();
	foreach (var p in liste) Console.WriteLine(p);
}
//q9();

//Sur une liste de personne: Récupérer la personne qui a le nom Dupont
void q10()
{
	Personne? pers = listePersonnes.FirstOrDefault(p=>p.Nom=="Dupont");
	Console.WriteLine(pers);
}
//q10();

//Sur une liste de personne : Savoir si notre liste contient une personne dont le nom commence par D
void q11()
{
	bool test = listePersonnes.Any(p => p.Nom.StartsWith("D"));
	Console.WriteLine(test);
}
//q11();

//Sur une liste de personnes : Faire la somme du nombre de lettre dans les prénoms
void q12()
{
	foreach(var p in listePersonnes) Console.WriteLine($"Nb lettres dans {p.Prenom} {p.Prenom.Length}");
}
//q12();

//Regrouper les personnes par leurs prénoms
void q13()
{
	var listeGroup = listePersonnes.GroupBy(p => p.Prenom);
	foreach (var group in listeGroup)
	{
		foreach (var p in group)
		{
			Console.WriteLine(p);
		}
	}
}
//q13();

//Afficher le nom en majuscule et le prénom des personnes
//trié par ordre descendant sur le prénom dont leurs noms commence par D
void q14()
{
	var persons = listePersonnes.Where(p => p.Nom
								.StartsWith("D"))
								.OrderByDescending(p=>p.Prenom)
								.Select(p => new { NomMaj = p.Nom.ToUpper(), p.Prenom })
								.ToList();
	foreach (var person in persons)
	{
		Console.WriteLine(person);
	}
}
q14();

