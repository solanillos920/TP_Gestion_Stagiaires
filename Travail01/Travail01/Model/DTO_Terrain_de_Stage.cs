using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail01.Model
{
    class DTO_Terrain_de_Stage // elle est public par defaut
    {
        // pour une region on tape "#region" et 2 fois tabulation
        #region attrubuts de la classe DTO_Terrain_de_Stage

        // Declaration des variables = attributs
        int idEntreprise; // clé primaire et étrangère car table de jonction 
        int idFormation;  // clé primaire et étrangère car table de jonction 

        #endregion



        // Pour créer les propriétés
        // On tape "prop" click 2 fois sur tabulation
        #region attrubuts de la classe DTO_Terrain_de_Stage

        public int IdEntreprise { get => idEntreprise; set => idEntreprise = value; }
        public int IdFormation { get => idFormation; set => idFormation = value; }

        #endregion


        // pour crée le contructeur
        // on tape "ctor" click 2 fois sur tabulation
        #region attrubuts de la classe DTO_Terrain_de_Stage

        public DTO_Terrain_de_Stage()
        {

        }

        public DTO_Terrain_de_Stage(int _idEntreprise ,int _idFormation)
        {
            idEntreprise = _idEntreprise;
            idFormation = _idFormation;
        }        
        #endregion




    }
}
