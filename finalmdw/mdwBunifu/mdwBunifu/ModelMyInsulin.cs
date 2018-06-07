using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdwBunifu
{
    public class ModelMyInsulin
    {
        private Connexion myConnexion = new Connexion();
        public List<InsulineTable> GetRecommandation(int idUser)
        {

            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT `idInsulinTable`, `minGlucose`, `maxGlucose`, `recommandation` FROM `insulintables` WHERE `idUser` = @idUser ORDER BY `minGlucose` ASC";
            cmd.Parameters.AddWithValue("@idUser", idUser);



            MySqlDataReader data = cmd.ExecuteReader();
            List<InsulineTable> recos = new List<InsulineTable>();
            while (data.Read())
            {
                recos.Add(new InsulineTable((int)data["idInsulinTable"],
               (double)data["minGlucose"],
               (double)data["maxGlucose"],
               (double)data["recommandation"]));

            }
            data.Close();

            return recos;
        }
        public void ChangeReco(int idReco, double min, double max, double reco)
        {
            try
            {

                // Ouverture de la connexion SQL
                myConnexion.OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = myConnexion.Connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "UPDATE insulin tables SET minGlucose = @min ,maxGlucose = @max  , recommandation = @reco  WHERE idInsulinTable =@idReco";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@min", min);
                cmd.Parameters.AddWithValue("@max", max);
                cmd.Parameters.AddWithValue("@reco", reco);
                cmd.Parameters.AddWithValue("@idReco", idReco);

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
        public void Delete(int id)
        {
            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "DELETE FROM `insulintables` WHERE `idInsulinTable` = @idReco";



            cmd.Parameters.AddWithValue("@idReco", id);

            // Exécution de la commande SQL
            cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            connect.CloseConnection();
        }
        public double getRecommandationInsu(double glycemie, int idUser)
        {
            
                Connexion connect = new Connexion();
                // Ouverture de la connexion SQL
                connect.OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = connect.Connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "SELECT `recommandation` FROM `insulintables` WHERE @glycemie >= `minGlucose` AND @glycemie <`maxGlucose` AND `idUser` = @idUser";
                cmd.Parameters.AddWithValue("@glycemie", glycemie);
                cmd.Parameters.AddWithValue("@idUser", idUser);
                MySqlDataReader data = cmd.ExecuteReader();
                double insu;
            
                data.Read();
            try
            {
                insu = (double)data["recommandation"];
            }
            catch
            {
                insu = 0;
            }
                data.Close();
                return insu;
            
        }
        public int GetLastId()
        {

            Connexion connect = new Connexion();
            // Ouverture de la connexion SQL
            connect.OpenConnection();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = connect.Connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "SELECT `idInsulinTable` FROM `insulintables` ORDER BY `idInsulinTable`DESC";
            




            MySqlDataReader data = cmd.ExecuteReader();
            int id;
            data.Read();
            id = (int)data["idInsulinTable"];


            data.Close();

            return id;
        }
    }

}
   
