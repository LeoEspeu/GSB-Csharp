using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace GSB_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //exemple d'utilisation de traitmentBDD
            TraitementBDD connect = new TraitementBDD("127.0.0.1", "gsb_frais", "root", "");
            MySqlDataReader reader = connect.interogation("Select * FROM comptable");


            Console.WriteLine("\n-----------------INFO COMPTABLE---------------\n");
            while (reader.Read())
            {
                //le chiffre envoyer à la méthode getstring sert a avoir une colone
                Console.WriteLine("Login / MDP des comptables de : " + reader.GetString(1) + " " + reader.GetString(2) + "\n");
                Console.WriteLine("Login: " + reader.GetString(3) + " MDP(crypté): " + reader.GetString(4));
                Console.WriteLine("Adresse: " + reader.GetString(5) + " Ville: " + reader.GetString(7) + "(" + reader.GetString(6) + ")");
                Console.WriteLine("Date d'embauche: " + reader.GetString(8));
                Console.WriteLine("\n-------------------------------------------\n");
            }

            //Ne pas oublier de fermer la connection
            connect.fermeture();

            Console.ReadKey();
        }
    }
}
