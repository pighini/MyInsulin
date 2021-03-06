﻿using MySql.Data.MySqlClient;
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
        public List<Measure> GetMesureWeekly(int interval, string unit)
        {

            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT `idMesure`, `glucose`, `insulinRecommandation`, `type`, `dateMesure`, `idUser` FROM `measures` WHERE `dateMesure` < NOW() and `dateMesure` > DATE_SUB( @today , INTERVAL @interval " + unit + ") and idUser = @idUser ORDER BY `dateMesure` ASC";
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
               (string)data["typeofMeasure"],
               ((DateTime)data["dateofMeasure"]).ToString()));

            }
            data.Close();

            return measures;
        }
        public List<Measure> GetMesureByType(string dateDebut, string dateFin,string type)
        {

            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT * FROM `measures` WHERE `idUser` = @idUser AND `dateofMeasure` >= @dateDeb AND `dateofMeasure` <= @dateFin AND `typeofMeasure`= @type ";
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
               (string)data["typeofMeasure"],
               ((DateTime)data["dateofMeasure"]).ToString()));

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
            cmd.CommandText = "SELECT `idMesure`, `glucose`, `insulinRecommandation`, `commentary`, `typeofMeasure`, `dateMesure`, `idUser` FROM `measures` WHERE  idMesure = @idMesure";
            cmd.Parameters.AddWithValue("@idMesure", id);
            



            MySqlDataReader data = cmd.ExecuteReader();
            Measure mesure;
            data.Read();
                mesure = new Measure((int)data["idMeasure"],
               (double)data["glucose"],
               (double)data["insulinRecommandation"],
               (string)data["commentary"],
               (string)data["typeofMeasure"],
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
        public bool verifMeasure(string date, string type )
        {
            int nbResultat = 0;
            // Ouverture de la connexion SQL
            myConnexion.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = myConnexion.Connection.CreateCommand();

            // Requête SQL
             cmd.CommandText = "SELECT idMeasure FROM `measures` WHERE `dateofMeasure` = '"+date+ "' AND `typeofMeasure` ='"+type+"';";

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

        public void ChangeMesure(double glucose,double insu, string comment, string type, string dateMesure, int idMesure)
        {
            try
            {

                // Ouverture de la connexion SQL
                myConnexion.OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = myConnexion.Connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "UPDATE `measures` SET `glucose`="+glucose+ " , `insulinRecommandation`="+insu+ " , `commentary`='"+comment+ "' , `typeofMeasure`='"+type+ "',`dateofMeasure`='"+dateMesure+ "' WHERE `idMeasure`="+idMesure+"";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@glucose", glucose);
                cmd.Parameters.AddWithValue("@insulin", insu);
                cmd.Parameters.AddWithValue("@comment", comment);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@DateMesure", dateMesure);
                cmd.Parameters.AddWithValue("@idMeasure", idMesure);


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

        public List<string> getAllTypes()
        {
            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT Distinct `typeofMeasure` FROM `measures` where idUser = @idUser ORDER BY typeofMeasure ASC";
            cmd.Parameters.AddWithValue("@idUser", this.ConnectedUser.IdUser);

            MySqlDataReader data = cmd.ExecuteReader();
            List<string> types = new List<string>();
            while (data.Read())
            {
                types.Add((string)data["typeofMeasure"]);

            }
            data.Close();

            return types;
        }
        public void AddMesure(double glucose, double insulinRecommandation,string commentary, string type, string date)
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
               (string)data["typeofMeasure"],
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
