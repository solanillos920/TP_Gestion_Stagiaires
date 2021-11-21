using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail01.Model
{
    class DTO_CalendrierStage  // elle est public par defaut 
    {

        // pour une region on tape "#region" et 2 fois tabulation
        #region Attrubuts de la classe DTO_CalendrierStage 

        // Declaration des variables = attributs
        int idCalendrierStage;   // clé primaire
        int idForma; // Clé etrangère
        int numPeriode;
        string dtDebStgFormation;
        string dtFinStgFormation;

        #endregion

        
        // Pour créer les propriétés
        // On tape "prop" click 2 fois sur tabulation
        #region Propriété de la classe DTO_CalendrierStage 

        public int IdCalendrierStage { get => idCalendrierStage; set => idCalendrierStage = value; }
        public int IdForma { get => idForma; set => idForma = value; }
        public int NumPeriode { get => numPeriode; set => numPeriode = value; }
        public string DtDebStgFormation { get => dtDebStgFormation; set => dtDebStgFormation = value; }
        public string DtFinStgFormation { get => dtFinStgFormation; set => dtFinStgFormation = value; }

        #endregion


        // pour crée le contructeur
        // on tape "ctor" click 2 fois sur tabulation
        #region       de la classe DTO_CalendrierStage 
        public DTO_CalendrierStage()
        {

        }

        public DTO_CalendrierStage(int _idCalendierStage, int _idForma, int _numPeriode, string _dtDebStgFormation, string _dtFinStgFormation)
        {
            idCalendrierStage = _idCalendierStage;
            idForma = _idForma;
            numPeriode = _numPeriode;
            dtDebStgFormation = _dtDebStgFormation;
            dtFinStgFormation = _dtFinStgFormation;
                
        }

        #endregion



    }
}
