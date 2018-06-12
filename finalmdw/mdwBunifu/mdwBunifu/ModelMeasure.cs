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
        public List<Measure> GetMesureWeekly(int interval, string unit, string date)
        {

            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT * FROM `measures` WHERE `dateofMeasure` < @date and `dateofMeasure` > DATE_SUB( @date , INTERVAL @interval " + unit + ") and idUser = @idUser ORDER BY `dateofMeasure` ASC";
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@idUser", ConnectedUser.IdUser);
            cmd.Parameters.AddWithValue("@interval", interval);
            cmd.Parameters.AddWithValue("@unit", unit);



            MySqlDataReader data = cmd.ExecuteReader();
            List<Measure> measures = new List<Measure>();
            while (data.Read())
            {
                measures.Add(new Measure((int)data["idMeasure"],
               (double)data["glucose"],
               (double)data["insulinRecommandation"],
               (string)data["commentary"],
               GetTypeById((int)data["idType"]),
               ((DateTime)data["dateofMeasure"]).ToString()));

            }
            data.Close();

            return measures;
        }
        public List<Measure> GetMesure(string dateDebut, string dateFin)
        {

            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT * FROM `measures` WHERE `idUser` = @idUser AND `dateofMeasure` >= @dateDeb AND `dateofMeasure` <= @dateFin ";
            cmd.Parameters.AddWithValue("@dateDeb", dateDebut);
            cmd.Parameters.AddWithValue("@dateFin", dateFin);
            cmd.Parameters.AddWithValue("@idUser", ConnectedUser.IdUser);




            MySqlDataReader data = cmd.ExecuteReader();
            List<Measure> measures = new List<Measure>();
            while (data.Read())
            {
                measures.Add(new Measure((int)data["idMeasure"],
               (double)data["glucose"],
               (double)data["insulinRecommandation"],
               (string)data["commentary"],
                GetTypeById((int)data["idType"]),
               ((DateTime)data["dateofMeasure"]).ToString()));

            }
            data.Close();

            return measures;
        }
        public List<Measure> GetMesureByType(string dateDebut, string dateFin, int type)
        {

            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT * FROM `measures` WHERE `idUser` = @idUser AND `dateofMeasure` >= @dateDeb AND `dateofMeasure` <= @dateFin AND `idType`= @type ";
            cmd.Parameters.AddWithValue("@dateDeb", dateDebut);
            cmd.Parameters.AddWithValue("@dateFin", dateFin);
            cmd.Parameters.AddWithValue("@idUser", ConnectedUser.IdUser);
            cmd.Parameters.AddWithValue("@type", type);





            MySqlDataReader data = cmd.ExecuteReader();
            List<Measure> measures = new List<Measure>();
            while (data.Read())
            {
                measures.Add(new Measure((int)data["idMeasure"],
               (double)data["glucose"],
               (double)data["insulinRecommandation"],
               (string)data["commentary"],
               GetTypeById((int)data["idType"]),
               ((DateTime)data["dateofMeasure"]).ToString()));

            }
            data.Close();

            return measures;
        }
        public string GetTypeById(int id)
        {

            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT type FROM `types` WHERE idType = @idType";
            cmd.Parameters.AddWithValue("@idType", id);


            MySqlDataReader data = cmd.ExecuteReader();
            string type;
            data.Read();


            type = (string)data["type"];


            data.Close();

            return type;
        }
        public int GetTypeByName(string type)
        {

            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT idType FROM `types` WHERE type = @type";
            cmd.Parameters.AddWithValue("@type", type);


            MySqlDataReader data = cmd.ExecuteReader();
            int typeToReturn;
            data.Read();

            try
            {
                typeToReturn = (int)data["idType"];
            }
            catch
            {
                typeToReturn = 0;
            }
            data.Close();

            return typeToReturn;
        }
        public int GetHasType(int idtype)
        {

            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT idType FROM `hastypes` WHERE idType = @idtype";
            cmd.Parameters.AddWithValue("@idtype", idtype);


            MySqlDataReader data = cmd.ExecuteReader();
            int typeToReturn;
            data.Read();

            try
            {
                typeToReturn = (int)data["idType"];
            }
            catch
            {
                typeToReturn = 0;
            }
            data.Close();

            return typeToReturn;
        }
        public void AddType(string type)
        {
            try
            {

                // Ouverture de la connexion SQL
                myConnexion.OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = myConnexion.Connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO `types`( `type`) VALUES (@type)";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@type", type);


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
        public void DeleteType(int id)
        {
            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "DELETE FROM `hastypes` WHERE `idType` = @idType";



            cmd.Parameters.AddWithValue("@idType", id);

            // Exécution de la commande SQL
            cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            connect.CloseConnection();
        }
        public int GetLastId()
        {

            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT `idType` FROM `insulintables` ORDER BY `idInsulinTable`DESC";





            MySqlDataReader data = cmd.ExecuteReader();
            int id;
            data.Read();
            id = (int)data["idInsulinTable"];


            data.Close();

            return id;
        }
        public void AddHasType( int idType , int idUser)
        {
            try
            {

                // Ouverture de la connexion SQL
                myConnexion.OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = myConnexion.Connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO `hastypes`(`idType`, `idUser`) VALUES ("+idType+" , "+idUser+")";

                // utilisation de l'objet contact passé en paramètre

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
        public double GetMesureDate(string date)
        {

            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT avg(`glucose`) as glucose FROM `measures` WHERE `dateofMeasure` = @date";
            cmd.Parameters.AddWithValue("@date", date);




            MySqlDataReader data = cmd.ExecuteReader();
            double mesure;
            data.Read();
            try
            {
                mesure = (double)data["glucose"];
            }
            catch
            {
                mesure = 0;
            }

            data.Close();

            return mesure;
        }
        public Measure GetMesureById(int id)
        {

            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT * FROM `measures` WHERE  idMeasure = @idMesure";
            cmd.Parameters.AddWithValue("@idMesure", id);




            MySqlDataReader data = cmd.ExecuteReader();
            Measure mesure;
            data.Read();
            mesure = new Measure((int)data["idMeasure"],
           (double)data["glucose"],
           (double)data["insulinRecommandation"],
           (string)data["commentary"],
           GetTypeById((int)data["idType"]),
           ((DateTime)data["dateofMeasure"]).ToString());


            data.Close();

            return mesure;
        }

        public List<string> GetAllTypes()
        {


            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT * FROM `types`";


            MySqlDataReader data = cmd.ExecuteReader();
            List<string> types = new List<string>();
            while (data.Read())
            {
                types.Add((string)data["type"]);

            }
            data.Close();

            return types;
        }
        public List<string> GetAllTypesByUser()
        {


            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT t.type FROM `hastypes` as h, `types` as t WHERE h.idUser = @idUser AND h.idType=t.idType ORDER BY `type` ASC ";
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
        public List<string> GetTypesWeekly(int interval, string unit, string date)
        {

            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT DISTINCT idType FROM `measures` WHERE `dateofMeasure` < @date and `dateofMeasure` > DATE_SUB( @date , INTERVAL @interval " + unit + ") and idUser = @idUser ORDER BY `dateofMeasure` ASC";
            cmd.Parameters.AddWithValue("@date", DateTime.Parse(date));
            cmd.Parameters.AddWithValue("@idUser", ConnectedUser.IdUser);
            cmd.Parameters.AddWithValue("@interval", interval);
            cmd.Parameters.AddWithValue("@unit", unit);



            MySqlDataReader data = cmd.ExecuteReader();
            List<string> types = new List<string>();
            while (data.Read())
            {
                types.Add(
               GetTypeById((int)data["idType"]));

            }
            data.Close();

            return types;
        }
        public bool verifMeasure(string date, string type)
        {
            int nbResultat = 0;
            // Ouverture de la connexion SQL
            myConnexion.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = myConnexion.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT idMeasure FROM `measures` WHERE `dateofMeasure` = '" + date + "' AND `idType` ='" + GetTypeByName(type) + "';";

            // utilisation de l'objet contact passé en paramètre


            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                nbResultat++;
            }

            reader.Close();

            // Fermeture de la connexion
            myConnexion.CloseConnection();

            if (nbResultat >= 1)
            {

                return true;

            }
            else
            {
                return false;
            }
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

        public void ChangeMesure(double glucose, double insu, string comment, string type, string dateMesure, int idMesure)
        {
            try
            {

                // Ouverture de la connexion SQL
                myConnexion.OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = myConnexion.Connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "UPDATE `measures` SET `glucose`=" + glucose + " , `insulinRecommandation`=" + insu + " , `commentary`='" + comment + "' , `idType`='" + GetTypeByName(type) + "',`dateofMeasure`='" + dateMesure + "' WHERE `idMeasure`=" + idMesure + "";

                // utilisation de l'objet contact passé en paramètre


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
        public void DelMeasure( int idMesure)
        {
            try
            {

                // Ouverture de la connexion SQL
                myConnexion.OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = myConnexion.Connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "DELETE FROM `measures` WHERE `idMeasure` = @idMeasure";
                cmd.Parameters.AddWithValue("@idMeasure", idMesure);

                // utilisation de l'objet contact passé en paramètre


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
       
        public void AddMesure(double glucose, double insulinRecommandation, string commentary, string type, string date)
        {
            try
            {

                // Ouverture de la connexion SQL
                myConnexion.OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = myConnexion.Connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO `measures`(`glucose`, `insulinRecommandation`, `commentary`, `dateofMeasure`, `idUser`, `idType`) VALUES (@glucose , @insulinRecommandation, @commentary , @dateMesure , @idUser, @type )";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@glucose", glucose);
                cmd.Parameters.AddWithValue("@insulinRecommandation", insulinRecommandation);
                cmd.Parameters.AddWithValue("@commentary", commentary);
                cmd.Parameters.AddWithValue("@type", GetTypeByName(type));
                cmd.Parameters.AddWithValue("@dateMesure", date);
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
        public Measure GetMesureByTypeAndDate(string date, string type)
        {
            try
            {
                Connexion connect = new Connexion();
                // Ouverture de la connexion SQL
                connect.OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = connect.Connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "SELECT `idMeasure`, `glucose`, `insulinRecommandation`, `commentary`, `typeofMeasure`, `dateofMeasure` FROM `measures` WHERE  `dateofMeasure` = '" + date + "' AND `typeofMeasure` = '" + type + "'";


                MySqlDataReader data = cmd.ExecuteReader();
                Measure mesure;
                data.Read();
                mesure = new Measure((int)data["idMeasure"],
               (double)data["glucose"],
               (double)data["insulinRecommandation"],
               (string)data["commentary"],
               GetTypeById((int)data["idType"]),
               ((DateTime)data["dateofMeasure"]).ToShortDateString());


                data.Close();

                return mesure;
            }
            catch
            {
                Measure emptyMeasure = new Measure(0);
                return emptyMeasure;
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
            }
        }

    }
}
