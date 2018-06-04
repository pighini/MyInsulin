using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace mdwBunifu
{
    public class ModelMeasure
    {
        private Connexion myConnexion = new Connexion();
        private User _connectedUser;

        private Measure _mes;

        public Measure Mes
        {
            get { return _mes; }
            set { _mes = value; }
        }

        public User ConnectedUser
        {
            get { return _connectedUser; }
            set { _connectedUser = value; }
        }


        public ModelMeasure(User coUser)
        {
            this.ConnectedUser = coUser;
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

        public List<Measure> GetMesure(int interval, string unit)
        {

            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT `idMesure`, `glucose`, `insulinRecommandation`, `type`, `dateMesure`, `idUser` FROM `measures` WHERE `dateMesure` < NOW() and `dateMesure` > DATE_SUB( @today , INTERVAL @interval "+unit+") and idUser = @idUser ORDER BY `dateMesure` ASC";
            cmd.Parameters.AddWithValue("@today", DateTime.Now);
            cmd.Parameters.AddWithValue("@idUser", ConnectedUser.IdUser);
            cmd.Parameters.AddWithValue("@interval", interval);
            cmd.Parameters.AddWithValue("@unit", unit);



            MySqlDataReader data = cmd.ExecuteReader();
            List<Measure> measures = new List<Measure>();
            while (data.Read())
            {
                measures.Add(new Measure((int)data["idMesure"],
               (int)data["glucose"],
               (int)data["insulinRecommandation"],
               (string)data["commentary"],
               (string)data["type"],
               (DateTime)data["dateMesure"]));

            }
            data.Close();

            return measures;
        }
        
        public Measure GetMesureById(int id)
        {

            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT `idMesure`, `glucose`, `insulinRecommandation`, `commentary`, `type`, `dateMesure`, `idUser` FROM `measures` WHERE  idMesure = @idMesure";
            cmd.Parameters.AddWithValue("@idMesure", id);
            



            MySqlDataReader data = cmd.ExecuteReader();
            Measure mesure;
            data.Read();
                mesure = new Measure((int)data["idMesure"],
               (int)data["glucose"],
               (int)data["insulinRecommandation"],
               (string)data["commentary"],
               (string)data["type"],
               (DateTime)data["dateMesure"]);

            
            data.Close();

            return mesure;
        }
        public string DateForDays(DateTime date)
        {
            string day;
            string month;
            if (date.Day.ToString().Count() == 1)
            {
                day = "0" + date.Day.ToString();

            }
            else
            {
                day = date.Day.ToString();
            }
            if (date.Month.ToString().Count() == 1)
            {
                month = "0" + date.Month.ToString();
            }
            else
            {
                month = date.Month.ToString();
            }
            return day + "." + month;
        }

        public void ChangeMesure(int glucose,int insu, string comment, string type, DateTime dateMesure, int idMesure)
        {
            try
            {

                // Ouverture de la connexion SQL
                myConnexion.OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = myConnexion.Connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "UPDATE `measures` SET `glucose`=@glucose , `insulinRecommandation`=@insulin , `commentary`=@comment , `type`=@type,`dateMesure`=@DateMesure WHERE `idMesure`=@idMesure";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@glucose", glucose);
                cmd.Parameters.AddWithValue("@insulin", insu);
                cmd.Parameters.AddWithValue("@comment", comment);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@DateMesure", dateMesure);
                cmd.Parameters.AddWithValue("@idMesure", idMesure);


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

        public List<string> getAllType()
        {
            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT Distinct `type` FROM `measures` where idUser = @idUser ORDER BY type ASC";
            cmd.Parameters.AddWithValue("@idUser", this.ConnectedUser.IdUser);

            MySqlDataReader data = cmd.ExecuteReader();
            List<string> types = new List<string>();
            while (data.Read())
            {
                types.Add((string)data["type"]);

            }
            data.Close();

            return types;
        }
        public void AddMesure(int glucose, int insulinRecommandation,string commentary, string type, DateTime date)
        {
            try
            {

                // Ouverture de la connexion SQL
                myConnexion.OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = myConnexion.Connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO `measures`(`glucose`, `insulinRecommandation`, `commentary`,`typeofMeasure`, `dateofMeasure`, `idUser`) VALUES (@glucose , @insulinRecommandation, @commentary , @type ,@dateMesure , @idUser)";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@glucose", glucose);
                cmd.Parameters.AddWithValue("@insulinRecommandation", insulinRecommandation);
                cmd.Parameters.AddWithValue("@commentary", commentary);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@DateMesure", date);
                cmd.Parameters.AddWithValue("@idUser", ConnectedUser.IdUser);


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
       

    }
}
