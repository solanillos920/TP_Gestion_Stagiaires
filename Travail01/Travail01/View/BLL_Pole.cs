using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail01.Model;
//using Travail01.Model;        // soit je mets le using soit je mets le chemein dans le progamme
//using Travail01.ViewModel;    // idem 

namespace Travail01.View
{
    class BLL_Pole
    {
        // pas de clé étrangere !!


        public bool AjouterPole(DTO_Pole poleAjouter)// Car le DTO se trouve dans le dossier Model
        {
            //création d'un objet de la classe bddMysql
            bool EstOk = false;

            //Connexion au SGBD
            ViewModel.BddMySql Bdd = new ViewModel.BddMySql("localhost", 3306, "travail01", "root", "");//car le BddMySql se trouve dans le dossier View.model
            bool OuvertureOk = Bdd.OuvrirConnexion();

            // Préparation de la requête MySQL  remarque le champ du id est Null car le id est en auto incrementation
            string requete = "INSERT INTO pole VALUES  (Null, '" + poleAjouter.NumPole + "', '" + poleAjouter.DesignationPole + "')";

            if (OuvertureOk == true) // connexion ouverte
            {
                //Tester la requête
                int NbrLignes = Bdd.RequeteNoData(requete); // execute la requete et donne l'info nombre de ligne modifier
                if (NbrLignes > 0) // si ligne modifiée => requete executé
                    EstOk = true;   // requête AjouterPole effectuer
            }
            return EstOk;
        }


        public bool ModifierPole(DTO_Pole poleModif)
        {
            // Creation d'un objet dela classe BddMySql         
            bool EstOk = false;

            //Connexion au SGBD
            ViewModel.BddMySql Bdd = new ViewModel.BddMySql("localhost", 3306, "travail01", "root", "");
            bool OuvertureOk = Bdd.OuvrirConnexion();

            //Préaration de la requête MySQL
            string requete = "UPDATE pole SET numPole ='" + poleModif.NumPole + "', designationPole ='" + poleModif.DesignationPole + "' WHERE idPole = '" + poleModif.IdPole + "'";
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
        public bool SupprimerPole(DTO_Pole poleSupprimer)
        {
            // création d'un objet de la classe bddMySql  
            bool EstOk = false;

            // Connexion au SGBD
            ViewModel.BddMySql Bdd = new ViewModel.BddMySql("localhost", 3306, "travail01", "root", "");
            bool OuvertureOK = Bdd.OuvrirConnexion();

            //Preparation de la requête
            string requete = "DELETE FROM pole WHERE numPole='" + poleSupprimer.NumPole + "'";

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

        //Je créé une liste des Poles existant
        public List<string> ListePole()
        {
            List<string> resulPole = new List<string>();
            bool EstOk = false; //n'est jamais utilisée
            ViewModel.BddMySql Bdd = new ViewModel.BddMySql("localhost", 3306, "travail01", "root", "");
            bool OuvertureOK = Bdd.OuvrirConnexion();
            resulPole = Bdd.AvoirListe("pole");
            return resulPole;
        }


























    }
}
