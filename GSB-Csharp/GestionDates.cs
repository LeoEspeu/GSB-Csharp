using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Csharp
{
    public abstract class GestionDates
    {
        /// <summary>
        /// Fonction permettant d'obtenir le mois précédent du mois actuel
        /// </summary>
        /// <returns>Mois précédent sous forme d'une chaîne de caractére</returns>
        public static string getMoisPrecedent()
        {
            string moisChaine = DateTime.Now.Month.ToString();
            int moisNb = Convert.ToInt32(moisChaine);
            if (moisNb == 1)
            {
                moisChaine = "12";
            }
            else if (moisNb <= 10)
            {
                moisChaine = "0" + (moisNb - 1);
            }
            else
            {
                moisChaine = Convert.ToString(moisNb - 1);
            }
            return moisChaine;
        }

        /// <summary>
        /// Fonction permettant d'obtenir le mois précédent du mois passés en paramétre
        /// </summary>
        /// <param name="pDate">Mois dont on veut obtenir le mois précédent</param>
        /// <returns>Mois précédent sous forme d'une chaîne de caractére</returns>
        public static string getMoisPrecedent(DateTime pDate)
        {
            string moisChaine = pDate.Month.ToString();
            int moisNb = Convert.ToInt32(moisChaine);
            if (moisNb == 1)
            {
                moisChaine = "12";
            }
            else if (moisNb <= 10)
            {
                moisChaine = "0" + (moisNb - 1);
            }
            else
            {
                moisChaine = Convert.ToString(moisNb - 1);
            }
            return moisChaine;
        }

        /// <summary>
        /// Fonction permettant d'obtenir le mois suivant le mois actuel
        /// </summary>
        /// <returns>Mois suivant sous forme d'une chaîne de caractére</returns>
        public static string getMoisSuivant()
        {
            string moisChaine = DateTime.Now.Month.ToString();
            int moisNb = Convert.ToInt32(moisChaine);
            if (moisNb == 12)
            {
                moisChaine = "01";
            }
            else if (moisNb < 9)
            {
                moisChaine = "0" + (moisNb + 1);
            }
            else
            {
                moisChaine = Convert.ToString(moisNb + 1);
            }
            return moisChaine;
        }

        /// <summary>
        /// Fonction permettant d'obtenir le mois suivant le mois passé en paramétre
        /// </summary>
        /// <param name="pDate">Mois dont on veut savoir le suivant</param>
        /// <returns>Mois suivant sous forme d'une chaîne de caractére</returns>
        public static string getMoisSuivant(DateTime pDate)
        {
            string moisChaine = pDate.Month.ToString();
            int moisNb = Convert.ToInt32(moisChaine);
            if (moisNb == 12)
            {
                moisChaine = "01";
            }
            else if (moisNb < 9)
            {
                moisChaine = "0" + (moisNb + 1);
            }
            else
            {
                moisChaine = Convert.ToString(moisNb + 1);
            }
            return moisChaine;
        }

        /// <summary>
        /// Détermine si le jour actuel est dans l'interval de ceux passés en paramétre
        /// </summary>
        /// <param name="pJoursInf">Intervalle inférieur</param>
        /// <param name="pJoursSup">Interval supérieur</param>
        /// <returns>Retourne un bool selon si la date est situé dans l'interval ou pas</returns>
        public static bool entre(int pJoursInf,int pJoursSup)
        {
            int joursActuel = Convert.ToInt32(DateTime.Now.Day);
            return pJoursInf < joursActuel && joursActuel < pJoursSup;
        }

        /// <summary>
        /// Détermine si le jour passés en paramétre est dans l'interval de ceux passés en paramétre
        /// </summary>
        /// <param name="pJoursInf">Intervalle inférieur</param>
        /// <param name="pJoursSup">Intervalle supérieur</param>
        /// <param name="pJoursTest">Jour à tester</param>
        /// <returns>Retourne un bool selon si la date est situé dans l'interval ou pas</returns>
        public static bool entre(int pJoursInf, int pJoursSup,int pJoursTest)
        {
            return pJoursInf < pJoursTest && pJoursTest < pJoursSup;
        }
    }
}
