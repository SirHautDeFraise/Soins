using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soins2020.classesMetiers
{
    class Dossier
    {
        readonly string nomPatient;
        readonly string prenomPatient;
        readonly DateTime dateNaissancePatient;
        readonly List<Prestation> mesPrestations;

        public string NomPatient => nomPatient;

        public string PrenomPatient => prenomPatient;

        public DateTime DateNaissancePatient => dateNaissancePatient;

        internal List<Prestation> MesPrestations => mesPrestations;

        /// <summary>
        /// Constructeur de la classe Dossier avec plusieurs Prestations
        /// </summary>
        /// <param name="nomPatient">Nom du Patient</param>
        /// <param name="prenomPatient">Prénom du Patient</param>
        /// <param name="dateNaissancePatient">Date de naissance du Patient</param>
        /// <param name="mesPrestations">Les Prestations</param>
        public Dossier(string nomPatient, string prenomPatient, DateTime dateNaissancePatient, List<Prestation> mesPrestations)
        {
            this.nomPatient = nomPatient;
            this.prenomPatient = prenomPatient;
            this.dateNaissancePatient = dateNaissancePatient;
            foreach (Prestation prestation in mesPrestations)
            {
                mesPrestations = new List<Prestation>();
            }
        }

        /// <summary>
        /// Constructeur de la classe Dossier avec une Prestations
        /// </summary>
        /// <param name="nomPatient">Nom du Patient</param>
        /// <param name="prenomPatient">Prénom du Patient</param>
        /// <param name="dateNaissancePatient">Date de naissance du Patient</param>
        /// <param name="unePrestations">Une Prestations</param>
        public Dossier(string nomPatient, string prenomPatient, DateTime dateNaissancePatient, Prestation unePrestations)
        {
            this.nomPatient = nomPatient;
            this.prenomPatient = prenomPatient;
            this.dateNaissancePatient = dateNaissancePatient;
            this.mesPrestations = new List<Prestation>();
            this.mesPrestations.Add(unePrestations);
        }

        /// <summary>
        /// Constructeur de la classe Dossier avec aucune Prestations
        /// </summary>
        /// <param name="nomPatient">Nom du Patient</param>
        /// <param name="prenomPatient">Prénom du Patient</param>
        /// <param name="dateNaissancePatient">Date de naissance du Patient</param>
        public Dossier(string nomPatient, string prenomPatient, DateTime dateNaissancePatient)
        {
            this.nomPatient = nomPatient;
            this.prenomPatient = prenomPatient;
            this.dateNaissancePatient = dateNaissancePatient;
        }


        /// <summary>
        /// Ajoute une prestation dans la liste de prestation d'un dossier
        /// </summary>
        /// <param name="unLibelle">Libellé d'une Prestation</param>
        /// <param name="date">Date de la Prestation</param>
        /// <param name="unIntervenant">L'intervenant de la Prestation</param>
        public void ajoutePrestation(string unLibelle, DateTime date, Intervenant unIntervenant)
        {
            try
            {
                Prestation unePrestation = new Prestation(unLibelle, date, unIntervenant);
                this.MesPrestations.Add(unePrestation);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Retourne le nombre d'intervenant externe
        /// </summary>
        /// <returns></returns>
        public int getNbPrestationsExternes()
        {
            try
            {
                int cpt = 0;
                foreach (Prestation maPrestation in MesPrestations)
                {
                    if (maPrestation.L_Intervenant.GetType().ToString() == "Soins2018.classesMetiers.IntervenantExterne")
                    {
                        cpt++;
                    }
                }
                return cpt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Retourne le nombre d'intervenant
        /// </summary>
        /// <returns></returns>
        public int getNbPrestation()
        {
            try
            {
                return this.MesPrestations.Count;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Retourne le nombre de jour de soins
        /// </summary>
        /// <returns></returns>
        public int getNbJoursSoins()
        {
            try
            {
                int cpt = 1;
                Prestation unePrestation;
                if (this.MesPrestations.Count == 0)
                {
                    return 0;
                }
                this.MesPrestations.Sort((x, y) => DateTime.Compare(y.DateSoin.Date, x.DateSoin.Date));
                unePrestation = this.MesPrestations[0];
                foreach (Prestation maPrestation in this.MesPrestations)
                {
                    cpt = cpt + maPrestation.compareTo(unePrestation);
                    unePrestation = maPrestation;
                }
                return cpt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int getNbJoursSoinsV2()
        {
            try
            {
                int cpt = 1;
                if (this.MesPrestations.Count == 0)
                {
                    return 0;
                }

                return cpt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
