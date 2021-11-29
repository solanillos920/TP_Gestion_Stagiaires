using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Travail01.Model;
using Travail01.ViewModel;

namespace Travail01.View
{
    class BLL_Formation
    {
          private MySqlDataReader lecture;
        
        // Fonction pour Ajouter une Formation
        public bool AjouterForma(DTO_Formation formaAjouter)// Car le DTO se trouve dans le dossier Model
        {
            //création d'un objet de la classe bddMysql
            bool EstOk = false;

            //Connexion au SGBD pour ouverture
            BddMySql Bdd = new BddMySql("localhost", 3306, "travail01", "root", "");
            bool OuvertureOk = Bdd.OuvrirConnexion();                                 
           
            /*    ----    Je verifie que le numero de formaton n'exite pas déjà     ------  */

            //  requete  teste car je sais que la 1002 existe deja =>  //  SELECT COUNT(idForma) FROM `formation` WHERE numForma = 1002  

            // prepare la requete qui donne 1 si le numero existe déja et 0 si non!
            int compt = 1; // 0 si numForma n'existe pas et 1 si numforma existe déjà
            
            /* **************    requetes preparées  *********************  */

            // creer un objet de la classe  pour stocker le resultat de la requete préparée
            MySqlDataReader resultat;
            // Je definis le squelette  de la requête préparée
            string requeteExiste = " SELECT COUNT(idForma) FROM formation WHERE numforma = @NumFormation";
            // je crée un ojet  MySqlCommand qui permet d'exécuter la requete
            MySqlCommand requetPrepa = new MySqlCommand(requeteExiste,Bdd.Connexion);

            //Je definis le type des parametres de la requete preparée
            requetPrepa.Parameters.Add(new MySqlParameter("@NumFormation", MySqlDbType.String));
            // j'affecte la valeur au pararmetre
            requetPrepa.Parameters["@NumFormation"].Value = (formaAjouter.NumForma);

            /*  *************** fin requete preparée ******************  */
                       
            if (OuvertureOk == true)
            {                
                // j'execute la requete prepareé
                resultat = Bdd.RequeteSql(requetPrepa);

                // on verifie s'il y a des données dans le Reader
                if (resultat.HasRows)// = true s'il y 1 ou plusieurs lignes
                {
                     resultat.Read(); // lire le contenu du Reader qui est mis dans la variable tableau

                     // récupère la 1ere valeur(string car numformation est un string) du tableau  
                     // la 1ere valeur c'est le idForma et le tableau est selctionné par son Numero = numForma 
                     compt = Int32.Parse(resultat.GetString(0));    
                }
            }

            Bdd.FermerConnexion();  // ferme la connexion

            // si le compteur = 0 => le numero n'existe pas 
            if (compt == 0)
            {
                // ouvrire la connexion
                OuvertureOk = Bdd.OuvrirConnexion();

                /*    --------------  debut requete préparée  -----------------------      */

                /* ---mettre en place des requetes preparées --- */
                // on definit le squelette  de la requête préparée
                string requeter =  "INSERT INTO formation(idForma, numForma, intituleForma, nbHeureForma, nbHeureCours, nbHeureStg, dtDebForma, dtFinForma, nombreStage, nbPeriodeStg, " +
                "idPole, idQualification) VALUES (Null, @NumeForma, @IntituForma, @LeNbHeureForma, @LeNbHeureCours, @LeNbHeureStg, @LaDtDebForma, @LaDtFinForma, @LeNbStg, @LeNbPeriodeStg, @LeIdPole, @LeIdQualifi)";
                                                      
                // je crée un objet  MySqlCommand qui permet d'exécuter la requete
                MySqlCommand laRequetePreparer = new MySqlCommand(requeter, Bdd.Connexion);

                //Je definis le type des parametres à ajouter à la requête préparée
                laRequetePreparer.Parameters.Add(new MySqlParameter("@LeIdForma", MySqlDbType.Int16));
                laRequetePreparer.Parameters.Add(new MySqlParameter("@NumeForma", MySqlDbType.String));
                laRequetePreparer.Parameters.Add(new MySqlParameter("@IntituForma", MySqlDbType.String));
                laRequetePreparer.Parameters.Add(new MySqlParameter("@LeNbHeureForma", MySqlDbType.Int16));                                                                    
                laRequetePreparer.Parameters.Add(new MySqlParameter("@LeNbHeureCours", MySqlDbType.Int16));
                laRequetePreparer.Parameters.Add(new MySqlParameter("@LeNbHeureStg", MySqlDbType.Int16));
                laRequetePreparer.Parameters.Add(new MySqlParameter("@LaDtDebForma", MySqlDbType.String));
                laRequetePreparer.Parameters.Add(new MySqlParameter("@LaDtFinForma", MySqlDbType.String));
                laRequetePreparer.Parameters.Add(new MySqlParameter("@LeNbStg", MySqlDbType.Int16));
                laRequetePreparer.Parameters.Add(new MySqlParameter("@LeNbPeriodeStg", MySqlDbType.Int16));
                laRequetePreparer.Parameters.Add(new MySqlParameter("@LeIdPole", MySqlDbType.Int16));
                laRequetePreparer.Parameters.Add(new MySqlParameter("@LeIdQualifi", MySqlDbType.Int16));

                // j'affecte la valeur au pararmetre
                laRequetePreparer.Parameters["@LeIdForma"].Value = (formaAjouter.IdForma);
                laRequetePreparer.Parameters["@NumeForma"].Value = (formaAjouter.NumForma);
                laRequetePreparer.Parameters["@IntituForma"].Value = (formaAjouter.IntituleFormation);
                laRequetePreparer.Parameters["@LeNbHeureForma"].Value = (formaAjouter.NbHeureForma);                                              
                laRequetePreparer.Parameters["@LeNbHeureCours"].Value = (formaAjouter.NbHeureCours);
                laRequetePreparer.Parameters["@LeNbHeureStg"].Value = (formaAjouter.NbHeureStg);
                laRequetePreparer.Parameters["@LaDtDebForma"].Value = (formaAjouter.DtDebForma);
                laRequetePreparer.Parameters["@LaDtFinForma"].Value = (formaAjouter.DtFinForma);
                laRequetePreparer.Parameters["@LeNbStg"].Value = (formaAjouter.NombreStage);
                laRequetePreparer.Parameters["@LeNbPeriodeStg"].Value = (formaAjouter.NbPeriode);
                laRequetePreparer.Parameters["@LeIdPole"].Value = (formaAjouter.IdPole);
                laRequetePreparer.Parameters["@LeIdQualifi"].Value = (formaAjouter.IdQualification);
             
                   /*   ------  Fin de la requête préparée   ----------     */                                        


                if (OuvertureOk == true) // connexion au SGBD ok
                {                
                    // J'execute la requete et je teste la requête
                    int NbrLignes = Bdd.RequeteNoData(laRequetePreparer); // passage en parametres modifiés pour la requete préparée
                    if (NbrLignes > 0)
                        EstOk = true;   // requête AjouterPole effectuer
                }    
            }
            else
            {
                MessageBoxResult selection = MessageBox.Show("Le numero de formation exite déjà . Entrer un nouveau ", "repondre", MessageBoxButton.OK);
                EstOk = false;
            }

            // fermer connexion
            Bdd.FermerConnexion();
            return EstOk;            
        }

        // Fonction pour Modifier une Formation
        public bool ModifierForma(DTO_Formation formaModif)
        {
            // Creation d'un objet de la classe BddMySql         
            bool EstOk = false;

            //Connexion au SGBD
            ViewModel.BddMySql Bdd = new ViewModel.BddMySql("localhost", 3306, "travail01", "root", "");
            bool OuvertureOk = Bdd.OuvrirConnexion();
           
            /*   --------------  Requetes préparées -----------------------             */
            
            string requeter = "UPDATE formation SET numForma = @NumFormation, intituleForma = @IntituForma, nbHeureForma = @LeNbHeureForma, nbHeureCours =@LeNbHeureCours, nbHeureStg = @LeNbHeureStg, dtDebForma = @LaDtDebForma, dtFinForma = @LaDtFinForma, nombreStage =@LeNbStg, nbPeriodeStg = @LeNbPeriodeStg  WHERE idForma = @LeIdForma";

            // je crée un objet  MySqlCommand qui permet d'exécuter la requete
            MySqlCommand laRequetePreparer = new MySqlCommand(requeter, Bdd.Connexion);

            //Je definis le type des parametres à ajouter à la requête préparée
            laRequetePreparer.Parameters.Add(new MySqlParameter("@LeIdForma", MySqlDbType.Int16));
            laRequetePreparer.Parameters.Add(new MySqlParameter("@NumFormation", MySqlDbType.String));
            laRequetePreparer.Parameters.Add(new MySqlParameter("@IntituForma", MySqlDbType.String));
            laRequetePreparer.Parameters.Add(new MySqlParameter("@LeNbHeureForma", MySqlDbType.Int16));
            laRequetePreparer.Parameters.Add(new MySqlParameter("@LeNbHeureCours", MySqlDbType.Int16));
            laRequetePreparer.Parameters.Add(new MySqlParameter("@LeNbHeureStg", MySqlDbType.Int16));
            laRequetePreparer.Parameters.Add(new MySqlParameter("@LaDtDebForma", MySqlDbType.String));
            laRequetePreparer.Parameters.Add(new MySqlParameter("@LaDtFinForma", MySqlDbType.String));
            laRequetePreparer.Parameters.Add(new MySqlParameter("@LeNbStg", MySqlDbType.Int16));
            laRequetePreparer.Parameters.Add(new MySqlParameter("@LeNbPeriodeStg", MySqlDbType.Int16));

            // j'affecte la valeur au pararmetre                
            laRequetePreparer.Parameters["@LeIdForma"].Value = (formaModif.IdForma);
            laRequetePreparer.Parameters["@NumFormation"].Value = (formaModif.NumForma);
            laRequetePreparer.Parameters["@IntituForma"].Value = (formaModif.IntituleFormation);
            laRequetePreparer.Parameters["@LeNbHeureForma"].Value = (formaModif.NbHeureForma);
            laRequetePreparer.Parameters["@LeNbHeureCours"].Value = (formaModif.NbHeureCours);
            laRequetePreparer.Parameters["@LeNbHeureStg"].Value = (formaModif.NbHeureStg);
            laRequetePreparer.Parameters["@LaDtDebForma"].Value = (formaModif.DtDebForma);
            laRequetePreparer.Parameters["@LaDtFinForma"].Value = (formaModif.DtFinForma);
            laRequetePreparer.Parameters["@LeNbStg"].Value = (formaModif.NombreStage);
            laRequetePreparer.Parameters["@LeNbPeriodeStg"].Value = (formaModif.NbPeriode);
          
            /*  --------   Fin de la requête préparée   ---------    */
                        
            if (OuvertureOk == true)
            {
                //Tester la requête
                int nBUpdate = Bdd.RequeteNoData(laRequetePreparer);
                if (nBUpdate > 0)
                    EstOk = true; // requête ModifierPole effectuer
            }
            return EstOk;
        }

        // fonction qui recupere la valeur de idForma => valeur de la Clé Primaire
        public int recupPK(string numeroformation)
        {
            // création d'un objet de la classe bddMySql  
            int PK = 0; // Primary Cley => Clé Primaire

            // Connexion au SGBD
            ViewModel.BddMySql Bdd = new ViewModel.BddMySql("localhost", 3306, "travail01", "root", "");
            bool OuvertureOK = Bdd.OuvrirConnexion();
                       
            /*   --------- Debut  Requetes préparées  ------------------         */
            
            // creer un objet de la classe  pour stocker le resultat de la requete préparée
            MySqlDataReader resultat;
            string requetePk = "SELECT idForma FROM formation WHERE numForma = @Numeroformation";
            
            // je crée un ojet  MySqlCommand qui permet d'exécuter la requete
            MySqlCommand requetPrepa = new MySqlCommand(requetePk, Bdd.Connexion);

            //Je definis le type des parametreé de la requete preparée
            requetPrepa.Parameters.Add(new MySqlParameter("@Numeroformation", MySqlDbType.String));
            // j'affecte la valeur
            requetPrepa.Parameters["@Numeroformation"].Value = (numeroformation);
                        
            /*  ------  Fin de la requête préparée  -------    */
                                 

            if (OuvertureOK == true)

            {   // je récupère le resultat de requete dans tableau
                resultat = Bdd.RequeteSql(requetPrepa); //  avec la requete normale MySqlDataReader tableau = Bdd.RequeteSql(requetPrepa);

                // on verifite s'il y a des données dans le Reader
                if (resultat.HasRows) //HasRows = true s'il y 1 ou plusieurs lignes
                {
                    resultat.Read(); // lire le contenu du Reader qu est mis dans la variable tableau

                    // récupère la 1ere valeur(string car numformation est un string) du tableau  
                    // la 1ere valeur c'est le idForma et le tableau est selctionné par son Numero = numForma 
                    PK = Int32.Parse(resultat.GetString(0)); 
                }                
            }
            return PK;
        }



        // Fonction pour supprimer une Formation. On supprime l'enregistrement par rapport au numero et on peut le faire par raport à l'id
        public bool SupprimerForma(DTO_Formation formaSupprimer)
        {
            // création d'un objet de la classe bddMySql  
            bool EstOk = false;

            // Connexion au SGBD
            ViewModel.BddMySql Bdd = new ViewModel.BddMySql("localhost", 3306, "travail01", "root", "");
            bool OuvertureOK = Bdd.OuvrirConnexion();
                       
            /*   --------------  Requete préparées -----------------------             */

            // je defini le squelette  de la requête préparée
            string requetePrePa = "DELETE FROM formation WHERE idForma = @LeIdFormat";

            // je crée un objet  MySqlCommand qui permet d'exécuter la requete
            MySqlCommand laRequetePreparer = new MySqlCommand(requetePrePa, Bdd.Connexion);

            //Je definis le type des parametres à ajouter à la requête préparée
            laRequetePreparer.Parameters.Add(new MySqlParameter("@LeIdFormat", MySqlDbType.Int16));

            // j'affecte la valeur au pararmetre
            laRequetePreparer.Parameters["@LeIdFormat"].Value = (formaSupprimer.IdForma);

            /*    ------  Fin de la requête préparée  -------     */
            
            if (OuvertureOK == true)
            {
                // tester la requête
                int nbModif = Bdd.RequeteNoData(laRequetePreparer); //   "int nbModif = Bdd.RequeteNoData(requete);" --> requete normale
                //if (nbModif > 0)
                EstOk = true;  //Requête SupprimerPole effectuée
            }
            return EstOk;
        }       


        //Je crée une liste des Poles existants
        public List<string> ListeForma()
        {
            List<string> resulForma = new List<string>();
            bool EstOk = false; //n'est jamais utilisée
            ViewModel.BddMySql Bdd = new ViewModel.BddMySql("localhost", 3306, "travail01", "root", "");
            bool OuvertureOK = Bdd.OuvrirConnexion();
            resulForma = Bdd.AvoirListe("formation");
            return resulForma;
        }

        

       




    }
}
