using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail01.Model
{
    class DTO_Stagiaire // elle est public par defaut
    {
        // pour une region on tape "#region" et 2 fois tabulation
        #region Attributs de la classe DTO_Stagiaire

        // Declaration des variables = attributs
        string nomStg;
        string prenomStg;
        string dtNaissance;
        string adrStg;
        string cpStg;
        string villeStg; 
        string secuStg;

        #endregion


        // Pour créer les propriétés
        // On tape "prop" click 2 fois sur tabulation 
        #region Propriété de la classe DTO_Stagiaire

        public string NomStg { get => nomStg; set => nomStg = value; }
        public string PrenomStg { get => prenomStg; set => prenomStg = value; }
        public string DtNaissance { get => dtNaissance; set => dtNaissance = value; }
        public string AdrStg { get => adrStg; set => adrStg = value; }
        public string CpStg { get => cpStg; set => cpStg = value; }
        public string VilleStg { get => villeStg; set => villeStg = value; }
        public string SecuStg { get => secuStg; set => secuStg = value; }

        #endregion

        
        //pour crée le contructeur
        // on tape "ctor" click 2 fois sur tabulation
        #region Constructeur de la classe DTO_Stagiaire

        public DTO_Stagiaire()
        {

        }

        public DTO_Stagiaire(string _nomStg, string _prenomStg, string _dtNaissance, string _adrStg, string _cpStg, string _villeStg, string _secuStg)
        {
            nomStg = _nomStg;
            prenomStg = _prenomStg;
            dtNaissance = _dtNaissance;
            adrStg = _adrStg;
            cpStg = _cpStg;
            villeStg = _villeStg;
            secuStg = _secuStg;

        }

        #endregion




       

    }
}
