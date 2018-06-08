using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace mdwBunifu
{
    public class ModelUser
    {
        private Connexion myConnexion = new Connexion();

        private User _connectedUser;


        public User ConnectedUser
        {
            get { return _connectedUser; }
            set { _connectedUser = value; }
        }

        public bool isCoOpen()
        {
            if (myConnexion.OpenConnection())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void AddUser(string firstName, string lastName, string email, string password)
        {
            try
            {

                // Ouverture de la connexion SQL
                myConnexion.OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = myConnexion.Connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO `users`(`firstName`,`lastName`,`email`, `password`) VALUES (@fName, @lName, @email, @password)";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@fName",firstName);
                cmd.Parameters.AddWithValue("@lName",lastName);
                cmd.Parameters.AddWithValue("@email",email);
                cmd.Parameters.AddWithValue("@password",password);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                myConnexion.CloseConnection();

            }
            catch
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
            }
        }
        public bool UserExist(string email)
        {
            int nbResultat = 0;
            // Ouverture de la connexion SQL
            myConnexion.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = myConnexion.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT * FROM `users` WHERE `email` = @email;";

            // utilisation de l'objet contact passé en paramètre
            cmd.Parameters.AddWithValue("@email", email);

            List<User> list = new List<User>();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                nbResultat++;
            }

            reader.Close();

            // Fermeture de la connexion
            myConnexion.CloseConnection();

            if (nbResultat == 0)
            {
                return false;
            }
            else
            {
                return true;

            }
        }
        public string CalculateSHA1(string text, Encoding enc)//methode pour encrypter une chaine en Sha1
        {
            byte[] buffer = enc.GetBytes(text);
            SHA1CryptoServiceProvider cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
            return BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
        }
        public bool loginUser(string email, string password)
        {
            int nbResultat = 0;
            // Ouverture de la connexion SQL
            myConnexion.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = myConnexion.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT * FROM `users` WHERE `email` = @email AND `password` = @password;";

            // utilisation de l'objet contact passé en paramètre
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);

            List<User> list = new List<User>();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                nbResultat++;
            }

            reader.Close();

            // Fermeture de la connexion
            myConnexion.CloseConnection();

            if (nbResultat == 1)
            {
                ConnectedUser = new User(email);
                ConnectedUser.IdUser = GetId();

                return true;

            }
            else
            {
                return false;
            }
        }
        public int GetId()
        {
            int idUser;
            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT `idUser` FROM `users` WHERE `email` = @email;";
            cmd.Parameters.AddWithValue("@email", ConnectedUser.Email);


            MySqlDataReader data = cmd.ExecuteReader();
            data.Read();
            idUser = (int)data["idUser"];
            data.Close();

            return idUser;
        }

    }
}
