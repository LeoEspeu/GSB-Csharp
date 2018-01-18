using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//On utilise le nugget Mysql.Data de Oracle (celle avec le logo bleu)
using MySql.Data.MySqlClient;

namespace GSB_Csharp
{
    class TraitementBDD
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string login;
        private string password;
        private string co;
        //Constructeur
        public TraitementBDD(string server, string database, string login, string password)
        {
            try
            {
                this.server = server;
                this.database = database;
                this.login = login;
                this.password = password;

                //On fussionne toutes les Info et on met tout dans un string,parce que Oracle ne connait pas les tableaux
                co = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + login + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(co);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Une exception a été levée : " + ex.Message);
            }
        }

        //On retourne un MySqlDataReader (un peu comme un fetch en php)
        public MySqlDataReader interogation(string commande)
        {
            try
            {

                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = commande;
                MySqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }

            catch (MySqlException err)
            {
                //en cas d'erreur:
                //on ferme la connection

                Console.WriteLine("Une exception a été levée : " + err.Message);
                //Si il y a un soucis les fonctions retourne NULL 
                return null;
            }
        }
        //IUD (insert,update,delect) est une fonction qui accepte en paramètre une commande
        //insert update ou delect...
        public void execution(string commande)
        {
            try
            {

                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = commande;
                //execution de la requette
                cmd.ExecuteNonQuery();
                //on ferme la connection
                connection.Close();
            }
            catch (MySqlException err)
            {
                //en cas d'erreur:
                //on ferme la connection
                Console.WriteLine("Une exception a été levée : " + err.Message);

            }
        }

        public void fermeture()
        {
            connection.Close();
        }


    }
}
