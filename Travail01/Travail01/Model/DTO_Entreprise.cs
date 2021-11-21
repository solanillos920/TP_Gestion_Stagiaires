using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail01.Model
{
    class DTO_Entreprise // elle est public par defaut
    {
        // pour une region on tape "#region" et 2 fois tabulation
        #region attrubuts de la classe DTO_Entreprise 

        // Declaration des variables = attributs
        int idEntreprise;   // clé primaire
        string nomEntreprise;
        string nomDirigeant;
        int telEntreprise;
        string adrEntreprise;
        int cpEntreprise;
        string villeEntreprise;
        int siret;

        #endregion


        // Pour créer les propriétés
        // On tape prop click 2 fois sur tabulation
        #region Propriétées de la classe DTO_Entreprise  

        public int IdEntreprise { get => idEntreprise; set => idEntreprise = value; }   // clé peimaire      
        public string NomEntreprise { get => nomEntreprise; set => nomEntreprise = value; }
        public string NomDirigeant { get => nomDirigeant; set => nomDirigeant = value; }
        public int TelEntreprise { get => telEntreprise; set => telEntreprise = value; }
        public string AdrEtreprise { get => adrEntreprise; set => adrEntreprise = value; }
        public int CpEtreprise { get => cpEntreprise; set => cpEntreprise = value; }
        public string VilleEntreprise { get => villeEntreprise; set => villeEntreprise = value; }
        public int Siret { get => siret; set => siret = value; }        

        #endregion


        // pour crée le contructeur
        // on tape "ctor" click 2 fois sur tabulation
        #region Constructeur de la classe DTO_Entreprise 

        public DTO_Entreprise()
        {
                
        }

        public DTO_Entreprise(int _idEntreprise, string _nomEntreprise, string _nomDirigeant, int _telEntreprise, string _adrEntreprise, int _cpEntreprise, string _villeEntreprise, int _siret)
        {
            idEntreprise = _idEntreprise;
            nomEntreprise = _nomEntreprise;
            nomDirigeant = _nomDirigeant;
            telEntreprise = _telEntreprise;
            adrEntreprise = _adrEntreprise;
            cpEntreprise = _cpEntreprise;
            villeEntreprise =  _villeEntreprise;
            siret = _siret;

        }
      
        #endregion
       


    }
}
