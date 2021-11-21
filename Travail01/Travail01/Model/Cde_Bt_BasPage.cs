using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail01.Model
{
    class Cde_Bt_BasPage
    {
        // declaration des variable = attribut
        bool btQuit;
        bool btNouveau;
        bool btModif; 
        bool btSupprimer;
                      

        // declaration des Getters et des Setters
        public bool BtQuit { get => btQuit; set => btQuit = value; }
        public bool BtNouveau { get => btNouveau; set => btNouveau = value; }
        public bool BtModif { get => btModif; set => btModif = value; }
        public bool BtSupprimer { get => btSupprimer; set => btSupprimer = value; }

        //Constructeur
        public void Cde_Bt_BatPage()
        {
            btQuit = false;
            btNouveau = false;
            btModif = false;
            btSupprimer = false;
        }

        //Constructeur
        public void Cde_Bt_BatPage(bool _btQuit, bool _btNouveau, bool _btModif, bool _btSupprimer)
        {
            btQuit = _btQuit;
            btNouveau = _btNouveau;
            btModif = _btModif;
            btSupprimer = _btSupprimer;
        }


    }
}
