using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail01.Model
{
    class DTO_Qualif  // elle est public par defaut  
    {
        // pour une region on tape "#region" et 2 fois tabulation
        #region attrubuts de la classe DTO_Qualif 

        // Declaration des variables = attributs
        int idQualification; // clé primaire
        string numQualif;
        string nomQualif;
        string niveauQualif;
        string descriptionQualif;
        
        #endregion


        // Pour créer les propriétés
        // On tape "prop" click 2 fois sur tabulation
        #region Propriété de la classe DTO_Qualif 

        public int IdQualification { get => idQualification; set => idQualification = value; }
        public string NumQualif { get => numQualif; set => numQualif = value; }
        public string NomQualif { get => nomQualif; set => nomQualif = value; }
        public string NiveauQualif { get => niveauQualif; set => niveauQualif = value; }
        public string DescriptionQualif { get => descriptionQualif; set => descriptionQualif = value; }

        #endregion


        // pour crée le contructeur
        // on tape "ctor" click 2 fois sur tabulation
        #region Constructeur de la classe DTO_Qualif 

        public DTO_Qualif()
        {

        }
        
        public DTO_Qualif(int _idQualification, string _numQualif, string _nomQualif, string _niveauQualif, string _descriptionQualif)
        {
            idQualification = _idQualification;
            numQualif = _numQualif;
            nomQualif = _nomQualif;
            niveauQualif = _niveauQualif;
            descriptionQualif = _descriptionQualif;            
        }
        
        #endregion



    }
}
