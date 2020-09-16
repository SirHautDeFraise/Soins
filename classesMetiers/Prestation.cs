using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soins2020.classesMetiers
{
    class Prestation
    {
        readonly string libelle;
        readonly DateTime dateSoin;
        readonly Intervenant l_Intervenant;
        /// <summary>
        /// Constructeur de la classe Prestation
        /// </summary>
        /// <param name="libelle">Libellé d'une Prestation</param>
        /// <param name="dateSoin">Date d'un soin</param>
        /// <param name="l_Intervenant">Intervenant</param>
        public Prestation(string libelle, DateTime dateSoin, Intervenant l_Intervenant)
        {
            this.libelle = libelle;
            this.dateSoin = dateSoin;
            this.l_Intervenant = l_Intervenant;
            l_Intervenant.ajoutePrestation(this);
        }
        /// <summary>
        /// Fonction qui permet de comparer deux prestations, la prestation courante et le parametre unePrestation
        /// </summary>
        /// <param name="unePrestation">Prestation a comparer</param>
        /// <returns></returns>
        public int compareTo(Prestation unePrestation)
        {
            try
            {
                int res = 0;
                if (unePrestation.dateSoin.Date == this.dateSoin.Date)
                {
                    return res;
                }
                else if (unePrestation.dateSoin.Date > this.dateSoin.Date)
                {
                    return res = 1;
                }
                else
                {
                    return res = -1;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// getter sur l'attribut libelle
        /// </summary>
        public string Libelle => libelle;
        /// <summary>
        /// getter sur l'attribut dateSoin
        /// </summary>
        public DateTime DateSoin => dateSoin;
        /// <summary>
        /// getter sur l'attribut l_intervenant
        /// </summary>
        public Intervenant L_Intervenant => l_Intervenant;
    }
}
