using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail01.View
{
    class BLL_Stagiaire
    {


        public bool AjouterStagiaire()
        {
            //création d'un objet de la classe bddMysql
            bool EstOk = false;












            return EstOk;
        }


        public bool ModifierForma()
        {
            //création d'un objet de la classe bddMysql
            bool EstOk = false;














            return EstOk;                       
        }




        // on supprime l'enregistrement par rapport au numero et on peut le faire par raport id
        public bool SupprimerForma()
        {
            //création d'un objet de la classe bddMysql
            bool EstOk = false;














            return EstOk;







        }

        //Je créé une liste des Poles existant
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
