using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Librairie MySQL ajoutée dans les références.
using MySql.Data.MySqlClient;


namespace mdwBunifu
{
    class Connection
    {
        private MySqlConnection _connection;

        public MySqlConnection myConnection
        {
            get { return _connection; }
            set { _connection = value; }
        }


        
        private string _error;

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }


        // Constructeur
        public Connection()
        {
            this.InitConnexion();
        }

        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=myinsulin; UID=root; PASSWORD=";
            myConnection = new MySqlConnection(connectionString);
            Error = String.Empty;
        }
        public bool OpenConnection()
        {
            myConnection.Close();
            try
            {
                myConnection.Open();
                return true;
            }
            catch
            {
                this.Error = "Veulliez vérifier votre connexion";
                return false;
            }

        }
        public bool CloseConnection()
        {
            try
            {
                myConnection.Close();
                return true;
            }
            catch
            {
                
                return false;
            }
        }

       
    }
}