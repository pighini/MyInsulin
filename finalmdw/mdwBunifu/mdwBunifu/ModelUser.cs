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
        private Connection myConnexion = new Connection();

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


        public void AddUser(string firstName, string lastName, string email, string password, bool isDoctor)
        {
            try
            {

                // Ouverture de la connexion SQL
                myConnexion.OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = myConnexion.myConnection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO `users`(`firstName`,`lastName`,`email`, `password`, `isDoctor`) VALUES (@fName, @lName, @email, @password, @isDoctor)";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@fName",firstName);
                cmd.Parameters.AddWithValue("@lName",lastName);
                cmd.Parameters.AddWithValue("@email",email);
                cmd.Parameters.AddWithValue("@password",password);
                cmd.Parameters.AddWithValue("@isDoctor", isDoctor);



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

        public int GetIdByLogin(string fName, string lName, string password)
        {
            
            // Ouverture de la connexion SQL
            myConnexion.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = myConnexion.myConnection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT `idUser` FROM `users` WHERE `firstName` =@fName AND `lastName` =@lName AND `password` =@pwd;";

            // utilisation de l'objet contact passé en paramètre
            cmd.Parameters.AddWithValue("@lName", lName);
            cmd.Parameters.AddWithValue("@fName", fName);
            cmd.Parameters.AddWithValue("@pwd", CalculateSHA1(password, Encoding.UTF8));

            

            MySqlDataReader data = cmd.ExecuteReader();
            int id;
            data.Read();

            id = (int)data["idUser"];

            data.Close();

            // Fermeture de la connexion
            myConnexion.CloseConnection();

            return id;
        }
        public int GetIdByNames(string fName, string lName)
        {
            
            // Ouverture de la connexion SQL
            myConnexion.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = myConnexion.myConnection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT * FROM `users` WHERE `firstName` =@fName AND `lastName` =@lName";

            // utilisation de l'objet contact passé en paramètre
            cmd.Parameters.AddWithValue("@lName", lName);
            cmd.Parameters.AddWithValue("@fName", fName);


            

            MySqlDataReader data = cmd.ExecuteReader();
            int id;
            data.Read();

            id = (int)data["idUser"];

            data.Close();

            // Fermeture de la connexion
            myConnexion.CloseConnection();

            return id;
        }

        public List<string[]> GetAllUserForDoc()
        {


            Connection connect = new Connection();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.myConnection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT `lastName` ,`firstName` FROM `users` WHERE `idMedecin` = @idMedecin";
            cmd.Parameters.AddWithValue("@idMedecin", this.ConnectedUser.IdUser);


            MySqlDataReader data = cmd.ExecuteReader();
            List<string[]> users = new List<string[]>();
            while (data.Read())
            {
                users.Add(new string[] { (string)data["lastName"], (string)data["firstName"] });

            }
            data.Close();

            return users;
        }
        public bool UserExistbyEmail(string email)
        {
            int nbResultat = 0;
            // Ouverture de la connexion SQL
            myConnexion.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = myConnexion.myConnection.CreateCommand();

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
        public bool UserExistbyNames(string nom, string prenom)
        {
            int nbResultat = 0;
            // Ouverture de la connexion SQL
            myConnexion.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = myConnexion.myConnection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT * FROM `users` WHERE `lastName` = @lName  AND `firstName` = @fName;";

            // utilisation de l'objet contact passé en paramètre
            cmd.Parameters.AddWithValue("@lName", nom);
            cmd.Parameters.AddWithValue("@fName", prenom);

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
        public bool CheckPatient(string fName, string lName, string password)
        {
            int nbResultat = 0;
            // Ouverture de la connexion SQL
            myConnexion.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = myConnexion.myConnection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT * FROM `users` WHERE `firstName` =@fName AND `lastName` =@lName AND `password` =@pwd;";

            // utilisation de l'objet contact passé en paramètre
            cmd.Parameters.AddWithValue("@lName", lName);
            cmd.Parameters.AddWithValue("@fName", fName);
            cmd.Parameters.AddWithValue("@pwd", CalculateSHA1(password, Encoding.UTF8));

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
        public void AddPatient(int idMed, int idUser)
        {
            int nbResultat = 0;
            // Ouverture de la connexion SQL
            myConnexion.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = myConnexion.myConnection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "UPDATE `users` SET `idMedecin`= @idMed WHERE `idUser` = @idUser";

            // utilisation de l'objet contact passé en paramètre
            cmd.Parameters.AddWithValue("@idMed", idMed);
            cmd.Parameters.AddWithValue("@idUser", idUser);

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                nbResultat++;
            }

            reader.Close();

            // Fermeture de la connexion
            myConnexion.CloseConnection();


        }
        public string CalculateSHA1(string text, Encoding enc)//methode pour encrypter une chaine en Sha1
        {
            byte[] buffer = enc.GetBytes(text);
            SHA1CryptoServiceProvider cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
            return BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
        }
        public bool LoginUser(string email, string password)
        {
            int nbResultat = 0;
            // Ouverture de la connexion SQL
            myConnexion.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = myConnexion.myConnection.CreateCommand();

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
                ConnectedUser.IsDoctor = IsDoctor();

                return true;

            }
            else
            {
                return false;
            }
        }

        private bool IsDoctor()
        {
            bool isDoc;
            Connection connect = new Connection();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.myConnection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT `isDoctor` FROM `users` WHERE `email` = @email;";
            cmd.Parameters.AddWithValue("@email", ConnectedUser.Email);


            MySqlDataReader data = cmd.ExecuteReader();
            data.Read();
            isDoc = (bool)data["isDoctor"];
            data.Close();

            return isDoc;
        }
        
        public int GetId()
        {
            int idUser;
            Connection connect = new Connection();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.myConnection.CreateCommand();

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
