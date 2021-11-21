using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail01.Model
{
    class DTO_Stagiaire_en_Entrerise // elle est public par defaut
    {
        // pour une region on tape "#region" et 2 fois tabulation
        #region Attrubuts de la classe DTO_Stagiaire_en_Entreprise 

        // Declaration des variables = attributs
        
        int idStagiaire; // clé primaire et étrangère car table de jonction 
        int numPeriode; // clé primaire composée 
        int idEntreprise; // clé primaire et étrangère car table de jonction
        int numConventionStg;
        string dtDebStgEntrep;
        string dtFinStgEntrep;

        #endregion
        

        // Pour créer les propriétés
        // On tape "prop" click 2 fois sur tabulation
        #region       de la classe DTO_Stagiaire_en_Entreprise  

        public int IdStagiaire { get => idStagiaire; set => idStagiaire = value; }
        public int NumPeriode { get => numPeriode; set => numPeriode = value; }
        public int IdEntreprise { get => idEntreprise; set => idEntreprise = value; }
        public int NumConventionStg { get => numConventionStg; set => numConventionStg = value; }
        public string DtDebStgEntrep { get => dtDebStgEntrep; set => dtDebStgEntrep = value; }
        public string DtFinStgEntrep { get => dtFinStgEntrep; set => dtFinStgEntrep = value; }
        
        #endregion

                                         
        // pour crée le contructeur
        // on tape "ctor" click 2 fois sur tabulation
        #region       de la classe DTO_Stagiaire_en_Entreprise 
        public DTO_Stagiaire_en_Entrerise()
        {

        }

        public DTO_Stagiaire_en_Entrerise(int _idStagiaire, int _numPeriode, int _idEntreprise, int _numConvention, string _dtDebStgEntrep, string _dtFinStgEntrep )
        {
            idStagiaire = _idStagiaire;
            numPeriode = _numPeriode;
            idEntreprise = _idEntreprise;
            numConventionStg = _numConvention;
            dtDebStgEntrep = _dtDebStgEntrep;
            dtFinStgEntrep = _dtFinStgEntrep;
        }
       
        #endregion

    }
}
