using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Soins2020.classesMetiers
{
    class Intervenant
    {
        readonly private string nom;
        readonly private string prenom;
        private List<Prestation> mesPrestations;
        /// <summary>
        /// Constructeur de la classe Intervenant
        /// </summary>
        /// <param name="nom">Nom de l'Intervenant</param>
        /// <param name="prenom">Prénom de l'Intervenant</param>
        /// <param name="mesPrestations">Prestations de l'Intervenant</param>
        public Intervenant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.mesPrestations = new List<Prestation>();
        }

        /// <summary>
        /// Ajoute une prestation dans la liste de prestation d'un Intervenant
        /// </summary>
        /// <param name="unePrestation">Une Prestation</param>
        public void ajoutePrestation(Prestation unePrestation)
        {
            try
            {
                this.mesPrestations.Add(unePrestation);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// getter sur l'attribut nom
        /// </summary>
        public string Nom => nom;
        /// <summary>
        /// getter sur l'attribut prenom
        /// </summary>
        public string Prenom => prenom;
    }
}