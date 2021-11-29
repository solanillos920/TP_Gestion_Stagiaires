using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail01.Model
{
    class DTO_Formation // elle est public par defaut
    {
        // pour une region on tape "#region" et 2 fois tabulation
        #region Attrubuts de la classe DTO_Formation 
        // Declaration des variables = attributs
        int idForma; // clé primaire  
        int idPole; // Clé etrangère
        int idQualification; // Clé étrangere
        string numForma;
        string intituleForma;
        int nbHeureForma;
        int nbHeureCours;
        int nbHeureStg;
        string dtDebForma;
        string dtFinForma;
        int nombreStage;
        int nbPeriode;
        #endregion
        
        // Pour créer les propriétés
        // On tape "prop" click 2 fois sur tabulation
        #region Proriete de la classe DTO_Formation              
        public int IdForma { get => idForma; set => idForma = value; }  // clé primaire 
        public int IdPole { get => idPole; set => idPole = value; } // Clé etrangère
        public int IdQualification { get => idQualification; set => idQualification = value; }  // Clé etrangère

        public string NumForma { get => numForma; set => numForma = value; }
        public string IntituleFormation { get => intituleForma ; set => intituleForma = value; }
        public int NbHeureForma { get => nbHeureForma; set => nbHeureForma = value; }
        public int NbHeureCours { get => nbHeureCours; set => nbHeureCours = value; }
        public int NbHeureStg { get => nbHeureStg; set => nbHeureStg = value; }
        public string DtDebForma { get => dtDebForma; set => dtDebForma = value; }
        public string DtFinForma { get => dtFinForma; set => dtFinForma = value; }
        public int NombreStage { get => nombreStage; set => nombreStage = value; }
        public int NbPeriode { get => nbPeriode; set => nbPeriode = value; }
        #endregion
        
        // pour crée le constructeur
        // on tape "ctor" click 2 fois sur tabulation
        #region Constructeur de la classe DTO_Formation     
        public DTO_Formation()
        {
            idForma = 0;
            numForma = null;
            intituleForma = "";
            nbHeureForma = 0;
            nbHeureCours = 0;
            nbHeureStg = 0;
            dtDebForma = "";
            dtFinForma = "";
            nombreStage = 0;
            nbPeriode = 0;
            idPole = 0;
            idQualification = 0;
        }

        public DTO_Formation(int _idForma, string _numForma, string _intituleForma, int _nbHeureForma,
                            int _nbHeureCours, int _nbHeureStg, string _dtDebForma, string _dtFinForma,
                            int _nombreStage, int _nbPeriode, int _idPole, int _idQualification   )
        {
            idForma = _idForma;           
            numForma = _numForma;
            intituleForma = _intituleForma;
            nbHeureForma = _nbHeureForma;
            nbHeureCours = _nbHeureCours;
            nbHeureStg = _nbHeureStg;
            dtDebForma = _dtDebForma;
            dtFinForma = _dtFinForma;
            nombreStage = _nombreStage;
            nbPeriode = _nbPeriode;
            idPole = _idPole;
            idQualification = _idQualification;
        }
        #endregion
    }
}
