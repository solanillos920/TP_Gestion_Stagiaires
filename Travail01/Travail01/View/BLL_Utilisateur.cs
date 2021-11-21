using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail01.Model;
using MySql.Data.MySqlClient;


namespace Travail01.View
{
    class BLL_Utilisateur
    {
        private MySqlDataReader lecteurLogin;

        // Fonction pour lire lespasseWord et login
        public bool LireUtilisateur(DTO_Utilisateur lireUtilisateur)// si pas de using => (Model.DTO_Utilisateur lireUtilisateur)
        {
            bool estOk = false;

            //Connexion au SGBD ouvre 
            ViewModel.BddMySql Bdd = new ViewModel.BddMySql("localhost", 3306, "travail01", "root", "");//car le BddMySql se trouve dans le dossier View.model
            bool OuvertureOk = Bdd.OuvrirConnexion();

            // prepare la requete qui donne 1 si le utilisateur est dans la base de données sinon 0
            int compt = 1; // 0 si idUtilisateur n'exite pas et 1 si idUtilisateur existe
            string requetUtilisateur = "SELECT COUNT(idUtilisateur) FROM `utilisateur` WHERE nomUtilisateur = '" + lireUtilisateur.NomUtilisateur +"' and passWord ='" + lireUtilisateur.PasseWord + "'";

            if (OuvertureOk == true)
            {
                MySqlDataReader tableUtilisateur = Bdd.RequeteSql(requetUtilisateur); // récupère le resultat de requete dans table

                // il vérifit s'il a des données dansle Reader
                if (tableUtilisateur.HasRows)   // = true => 1 ou plusieurs lignes
                {
                    tableUtilisateur.Read(); // lire le contenu dU Reader" dans BddMySql " qui est mis dans la variable tnbeUtilisateur

                    // je recupere la valeur et comme idUtilisateur est un interger
                    compt = Int32.Parse(tableUtilisateur.GetString(0));// si c'est un varchar dans la base
                    // compt = Int32.Parse(tableau.GetInt16()); //idem si le idUtilisateur est un entier dans la base      

                    // si l'utilisateur n'est pas reconnu 
                    if (compt == 0)
                        estOk = false; //                    
                    else
                    {
                        estOk = true;   // 
                    }
                    
                }               
            }
            
            Bdd.FermerConnexion();// fer la connexion
            

            return estOk;
        }

        /* ---- Fin : Fonction pour lire lespasseWord et login   ---- */


        /*-------------------------------------------------*/
        /*-------------------------------------------------*/


        /*--  Debut: fonction qui recupere la valeur idUtilisateur --*/

        public int recupPK(string nom_Utilisateur)
        {
            // création d'un objet de la classe bddMySql  
            int PK = 0; // Primary Cley => Clé Primaire

            // Connexion au SGBD
            ViewModel.BddMySql Bdd = new ViewModel.BddMySql("localhost", 3306, "travail01", "root", "");
            bool OuvertureOK = Bdd.OuvrirConnexion();

            /*    ----------- Début  requête normale  */

            //Preparation de la requête qui me donne la valeur de idFoema pour un numero de formation donné
            //    string requete = "SELECT idForma FROM formation WHERE numForma ='" + numeroformation + "'";


            /*   fin requete normal-------- - */

            /*   ----------------------------------------------------------------    */


            /*   --------------  Requete préparées -----------------------             */


            // creer un objet de la classe  pour stocker le result de la requete préparée
            MySqlDataReader resultat;
            string requetePk = "SELECT idUtilisateur FROM formation WHERE nomUtiisateur = @LeNomUtilisateur";

            // je créé un ojet  MySqlCommand qui permet d'exécuter la requete
            MySqlCommand requetPrepa = new MySqlCommand(requetePk, Bdd.Connexion);

            //Je defini le type des parametreé de la requete preparée
            requetPrepa.Parameters.Add(new MySqlParameter("@LeNomUtilisateur", MySqlDbType.String));
            // j'affecte la valeur
            requetPrepa.Parameters["@LeNomUtilisateur"].Value = (nom_Utilisateur);


            /*    ********* Fin de la requête préparée*********          */

            if (OuvertureOK == true)

            {   // récupère le resultat de requete dans tableau
                resultat = Bdd.RequeteSql(requetPrepa); //  avec la requete normale   MySqlDataReader tableau = Bdd.RequeteSql(requetPrepa);


                // il on verifit s'il a des données dans le Reader
                if (resultat.HasRows) //HasRows = true s'il y 1 ou plusieur lignes
                {
                    resultat.Read(); // lire le contenu du Reader qu est mis dans la variable tableau

                    // récupère la 1ere valeur(string car numformation est un string) du tableau  
                    // la 1ere valeur c'est le idForma et le tableau est selctionné par son Numero = numForma 
                    PK = Int32.Parse(resultat.GetString(0));

                    // PK = Int32.Parse(tableau.GetInt16()); idem si le numforma etait un entier
                }
            }
            return PK;
        }

        



        /*--  fin: fonction qui recupere la valeur idUtilisateur--*/

























        // fonction qui recupere les infos mail 
        public (string nomUtilisa,string lePasseWord , string mailUtilisa, string ceMotPassMail) RecupMotdePasse(string leNomUtilisesateur) // c'est un tuple recup le mot de passe
        {
            string leTableau = string.Empty; // chaine vide 
            string nomutilisateur = string.Empty, ce_passeWord = string.Empty, mailUtilisateur = string.Empty, motPassMail = string.Empty;

            // Connexion au SGBD
            ViewModel.BddMySql Bdd = new ViewModel.BddMySql("localhost", 3306, "travail01", "root", "");
            bool OuvertureOK = Bdd.OuvrirConnexion();

            // creer un objet de la classe  pour stocker le result de la requete préparée
            MySqlDataReader le_resultat;

            // prepare une requete qui me donne l'adresse Mail et le 
            //string requeteMotPass = "SELECT `email`, `motPassMail` FROM `utilisateur` WHERE `nomUtilisateur` = "solanillos";           

            string requeteMotPass = "SELECT nomUtilisateur,passWord ,email, motPassMail FROM utilisateur WHERE `nomUtilisateur` = @LeNomUtilisateur";

            // je créé un ojet  MySqlCommand qui permet d'exécuter la requete
            MySqlCommand requetPrepa = new MySqlCommand(requeteMotPass, Bdd.Connexion);

            //Je defini le type des parametreé de la requete preparée
            requetPrepa.Parameters.Add(new MySqlParameter("@LeNomUtilisateur", MySqlDbType.String));
            // j'affecte la valeur
            requetPrepa.Parameters["@LeNomUtilisateur"].Value = (leNomUtilisesateur);


            /*    ********* Fin de la requête préparée*********          */

            if (OuvertureOK == true)
            {
                // récupère le resultat de requete dans tableau
                le_resultat = Bdd.RequeteSql(requetPrepa); //  avec la requete normale   MySqlDataReader tableau = Bdd.RequeteSql(requetPrepa);



                // et on verifit s'il a des données dans le Reader
                if (le_resultat.HasRows) //HasRows = true s'il y 1 ou plusieur lignes
                {
                    while (le_resultat.Read())// lire le contenu du Reader qu est mis dans la variable tableau
                    {
                        // 

                        nomutilisateur = le_resultat.GetString(0);// 1 = 1er element // mettre le mot de passe
                        ce_passeWord = le_resultat.GetString(1);
                        mailUtilisateur = le_resultat.GetString(2);
                        motPassMail = le_resultat.GetString(3);


                    }

                    // récupère la 1ere valeur(string car numformation est un string) du tableau  
                    // la 1ere valeur c'est le idForma et le tableau est selctionné par son Numero = numForma 


                    //leTableau =(le_resultat.); //

                    // PK = Int32.Parse(tableau.GetInt16()); idem si le numforma etait un entier
                }
                


               
            }



          return (nomutilisateur,ce_passeWord,mailUtilisateur,motPassMail);




















        }



    }
}
