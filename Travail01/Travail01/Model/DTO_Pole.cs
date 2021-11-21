using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail01.Model
{
    class DTO_Pole  // elle est privé par defaut
    {
        // pour une region on tape "#region" et 2 fois tabulation
        #region Attributs de la classe DTO_Pole 

        // Declaration des variables = attributs
        int idPole; // Clé primaire
        string numPole;
        string designationPole;        
        
        #endregion


        // Pour créer les propriétés
        // On tape "prop" click 2 fois sur tabulation
        #region Propriétés de la classe DTO_Pole 
            
        public int IdPole { get => idPole; set => idPole = value; } // Clé primaire
        public string NumPole { get => numPole; set => numPole = value; }
        public string DesignationPole { get => designationPole; set => designationPole = value; }

        #endregion


        // pour crée le contructeur
        // on tape "ctor" click 2 fois sur tabulation
        #region Constructeurs de la classe DTO_Pole 

        public DTO_Pole()
        {

        }

        public DTO_Pole( int _idPole, string _numPole, string _designationPole)
        {
            idPole = _idPole;
            numPole = _numPole;
            designationPole = _designationPole;
        }

        #endregion


    }
}
