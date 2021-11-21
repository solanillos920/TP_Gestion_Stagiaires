using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail01.Model;

namespace Travail01.View
{
    class BLL_Qualification
    {
        public bool AjouterQualif(DTO_Qualif qualifAjouter)// Car le DTO se trouve dans le dossier Model
        {
            //création d'un objet de la classe bddMysql
            bool EstOk = false;

            //Connexion au SGBD
            ViewModel.BddMySql Bdd = new ViewModel.BddMySql("localhost", 3306, "travail01", "root", "");//car le BddMySql se trouve dans le dossier View.model
            bool OuvertureOk = Bdd.OuvrirConnexion();

            // Préparation de la requête MySQL  remarque le champ du id est Null car le id est en auto incrementation
            string requete = "INSERT INTO qualification VALUES  (Null, '" + qualifAjouter.NumQualif + "', '" + qualifAjouter.NomQualif + "', '" + qualifAjouter.NiveauQualif + "', '" + qualifAjouter.DescriptionQualif + "')";

            if (OuvertureOk == true)
            {
                //Tester la requête
                int NbrLignes = Bdd.RequeteNoData(requete);
                if (NbrLignes > 0)
                    EstOk = true;   // requête AjouterPole effectuer
            }
            return EstOk;
        }


        public bool ModifierQualif(DTO_Qualif qualifModif)
        {
            // Creation d'un objet dela classe BddMySql         
            bool EstOk = false;

            //Connexion au SGBD
            ViewModel.BddMySql Bdd = new ViewModel.BddMySql("localhost", 3306, "travail01", "root", "");
            bool OuvertureOk = Bdd.OuvrirConnexion();

            //Préaration de la requête MySQL
            string requete = "UPDATE qualification SET numQualif ='" + qualifModif.NumQualif + "', nomQualif ='" + qualifModif.NomQualif + "',niveauQualif = '" + qualifModif.NiveauQualif + "', descriptionQualif ='" + qualifModif.DescriptionQualif + "' WHERE idQualification = '" + qualifModif.IdQualification + "'";
            if (OuvertureOk == true)
            {
                //Trester la requête
                int nBUpdate = Bdd.RequeteNoData(requete);
                if (nBUpdate > 0)
                    EstOk = true; // requête ModifierPole effectuer
            }
            return EstOk;
        }

        // on supprime l'enregistrement par rapport au numero et on peut le faire par raport id
        public bool SupprimerQualif(DTO_Qualif qualifSupprimer)
        {
            // création d'un objet de la classe bddMySql  
            bool EstOk = false;

            // Connexion au SGBD
            ViewModel.BddMySql Bdd = new ViewModel.BddMySql("localhost", 3306, "travail01", "root", "");
            bool OuvertureOK = Bdd.OuvrirConnexion();

            //Preparation de la requête
            string requete = "DELETE FROM qualification WHERE numQualif='" + qualifSupprimer.NumQualif + "'";

            if (OuvertureOK == true)
            {
                // tester la requête
                int nbModif = Bdd.RequeteNoData(requete);
                //if (nbModif > 0)
                EstOk = true;  //Requête SupprimerPole effectuée

                // autre Methode
                //   MySqlDataReader reader = Bdd.RequeteSql(requete);
                // mettre à jour EstOK en fonction du retour de la requete
            }
            return EstOk;
        }


        //Je créé une liste des qualifs existant
        public List<string> ListeQualif()
        {
            List<string> resulQualif = new List<string>();
            bool EstOk = false; //n'est jamais utilisée
            ViewModel.BddMySql Bdd = new ViewModel.BddMySql("localhost", 3306, "travail01", "root", "");
            bool OuvertureOK = Bdd.OuvrirConnexion();
            resulQualif = Bdd.AvoirListe("qualification"); // AvoirListe fonction de la classe "BddMySql"
            return resulQualif;
        }
























    }














}
