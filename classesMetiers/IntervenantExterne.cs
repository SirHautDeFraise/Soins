using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soins2020.classesMetiers
{
    class IntervenantExterne : Intervenant
    {
        readonly string specialite;
        readonly string adresse;
        readonly string tel;
        /// <summary>
        /// Constructeur de la classe Intervenant Externe
        /// </summary>
        /// <param name="nom">Nom de l'Intervenant</param>
        /// <param name="prenom">Prénom de l'intervenant</param>
        /// <param name="specialite">Specialité de l'Intervenant</param>
        /// <param name="adresse">Adresse de l'Intervenant</param>
        /// <param name="tel">Téléphone de l'Intervenant</param>
        public IntervenantExterne(string nom, string prenom, string specialite, string adresse, string tel) : base(nom, prenom)
        {
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }

        /// <summary>
        /// getter sur l'attribut specialite
        /// </summary>
        public string Specialite => specialite;
        /// <summary>
        /// getter sur l'attribut adresse
        /// </summary>
        public string Adresse => adresse;
        /// <summary>
        /// getter sur l'attribut tel
        /// </summary>
        public string Tel => tel;
    }
}
