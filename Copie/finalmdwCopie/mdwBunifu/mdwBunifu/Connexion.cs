using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Librairie MySQL ajoutée dans les références.
using MySql.Data.MySqlClient;


namespace mdwBunifu
{
    class Connexion
    {
        public MySqlConnection Connection;

        public string error = string.Empty;

        // Constructeur
        public Connexion()
        {
            this.InitConnexion();
        }

        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=myinsulin; UID=root; PASSWORD=";
            Connection = new MySqlConnection(connectionString);
        }
        public bool OpenConnection()
        {
            Connection.Close();
            try
            {
                Connection.Open();
                return true;
            }
            catch
            {
                this.error = "Veulliez vérifier votre connexion";
                return false;
            }

        }
        public bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch
            {
                
                return false;
            }
        }

       
    }
}