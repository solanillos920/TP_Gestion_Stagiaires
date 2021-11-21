using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;// il faut mettre ça mais ça et ça marche !!

namespace Travail01.ViewModel
{
    class BddMySql
    {
        public MySqlConnection Connexion;  // ATTENTION ??!!!! Avant => private MySqlConnection Connexion;
        private String AdrServeur, NomBdd, Utilisateur, MotPasse;
        private int NumPort;
        private String ChaineConnexion;
        private string _Erreur;
        private bool EstConnecte;


        public BddMySql(string Serv, int Port, string Bdd, string User, string Pass)
        {
            AdrServeur = Serv;
            NomBdd = Bdd;
            Utilisateur = User;
            MotPasse = Pass;
            NumPort = Port;
            ChaineConnexion = "Server=" + AdrServeur +
                               ";Database=" + NomBdd +
                               ";port=" + NumPort +
                               ";User Id=" + Utilisateur +
                              ";password=" + MotPasse;

            Connexion = new MySqlConnection(ChaineConnexion); // Création de l'objet Connexion
            EstConnecte = false; // Connexion fermée par défaut
        }
        
        public bool OuvrirConnexion() // Methode ouverture de la connexion
        {
            try
            {
                Connexion.Open();
                EstConnecte = true;
            }

            catch (Exception Er)
            {
                _Erreur = Er.Message;
            }

            return EstConnecte;
        }
        
        public bool FermerConnexion() // Methode fermeture de la connexion
        {
            try
            {
                Connexion.Close();
                EstConnecte = false;
            }

            catch (Exception Er)
            {
                _Erreur = Er.Message;
            }

            return EstConnecte;
        }

        public string Erreur
        {
            get { return _Erreur; }
        }


        public MySqlDataReader RequeteSql(String Requete)
        {
            MySqlCommand CmdSql = new MySqlCommand(Requete, Connexion);
            MySqlDataReader Reader = null;

            if (EstConnecte == true)
            {
                try
                {// On éxecute la commande et on recupère le résultat de la requete dans MySqlDataReader = Reader
                    Reader = CmdSql.ExecuteReader();
                }
                catch (Exception Er)
                {
                    _Erreur = Er.Message;
                }
            }
            return Reader;
        }


        // je surcharge de la Methode RequeteSql en passant l'objet  commande de type MySqlCommand pour la requete preparée
        public MySqlDataReader RequeteSql(MySqlCommand commande)
        {
            // MySqlCommand CmdSql = new MySqlCommand(Requete, Connexion); // car c'est fait dans le BLL_tititoto
            MySqlDataReader Reader = null;

            if (EstConnecte == true)
            {
                try
                {
                    Reader = commande.ExecuteReader();
                }
                catch (Exception Er)
                {
                    _Erreur = Er.Message;
                }
            }
            return Reader;
        }

        
        // requete CRUD
        public int RequeteNoData(String Requete)
        {
            MySqlCommand CmdSqlNoData = new MySqlCommand(Requete, Connexion);
            int NbrLignesModifiees = 0;

            if (EstConnecte == true)
            {
                try
                {
                    NbrLignesModifiees = CmdSqlNoData.ExecuteNonQuery();// mehode qui peret d'executer la requete
                }
                catch (MySqlException Er)
                {
                    _Erreur = Er.Message;
                }
            }
            return NbrLignesModifiees;

        }


        // je surcharge de la Methode RequeteSql en passant l'objet  commande de type MySqlCommand pour la requete preparée
        public int RequeteNoData(MySqlCommand commande)
        {
            // MySqlCommand CmdSqlNoData = new MySqlCommand(Requete, Connexion); // car c'est fait dans le BLL_tititoto
            int NbrLignesModifiees = 0;

            if (EstConnecte == true)
            {
                try
                {
                    // ici  CmdSqlNoData.ExecuteNonQuery() devient commande.ExecutNonQuery car c'est l'objet passé en pararmetre 
                    NbrLignesModifiees = commande.ExecuteNonQuery();
                }
                catch (MySqlException Er)
                {
                    _Erreur = Er.Message;
                }
            }
            return NbrLignesModifiees;

        }

               
        // Attention Methode à adapter !

        public List<string> AvoirListe(string table)
        {
            List<string> resultat = new List<string>();

            String requete = string.Format("select * from {0}", table);
            bool ok = false;
            MySqlDataReader reader = RequeteSql(requete);
            if (reader != null)
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int nbrColonnes = reader.FieldCount;
                        string valeur = "";
                        for (int i = 0; i < nbrColonnes; i++)
                        {
                            valeur += reader.GetString(i) + "/";
                        }
                        resultat.Add(valeur);
                    }
                }
            }
            // reader.Close();
            return resultat;
        }        
    }
}
