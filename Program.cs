using System;
using Soins2020.classesMetiers;

namespace Soins2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Dossier unDossier = new Dossier("Robert", "Jean", new DateTime(1980, 12, 3));
            unDossier.ajoutePrestation("Libelle P3", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            unDossier.ajoutePrestation("Libelle P1", new DateTime(2015, 9, 1, 12, 0, 0), new IntervenantExterne("Durand", "Annie", "Cardiologue", "Marseille", "0202020202"));
            unDossier.ajoutePrestation("Libelle P2", new DateTime(2015, 9, 8, 12, 0, 0), new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "0303030303"));
            unDossier.ajoutePrestation("Libelle P4", new DateTime(2015, 9, 20, 12, 0, 0), new Intervenant("Maurin", "Joëlle"));
            unDossier.ajoutePrestation("Libelle P6", new DateTime(2015, 9, 8, 9, 0, 0), new Intervenant("Blanchard", "Michel"));
            unDossier.ajoutePrestation("Libelle P5", new DateTime(2015, 9, 10, 6, 0, 0), new Intervenant("Tournier", "Hélène"));

            Console.WriteLine(unDossier);
            Console.WriteLine("Nombre de jours de soins V1 : " + unDossier.getNbJoursSoins());
            Console.WriteLine("Nombre de jours de soins V2 : " + unDossier.getNbJoursSoinsV2());
            Console.WriteLine("Nombre de soins externes : " + unDossier.getNbPrestationsExternes());
        }
    }
}