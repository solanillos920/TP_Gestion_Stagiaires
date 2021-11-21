using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail01.Model
{
    class Cde_Bt_Login
    {
        // attribut
        bool btQuitter;
        bool btValidLogin;
        bool btOulier;

        // devlaration des getter / setter
        public bool BtQuitter { get => btQuitter; set => btQuitter = value; }
        public bool BtValidLogin { get => btValidLogin; set => btValidLogin = value; }
        public bool BtOulier { get => btOulier; set => btOulier = value; }


        //Constructeur
        public Cde_Bt_Login()
        {

        }

        public Cde_Bt_Login(bool _btQuitter, bool _btValidLogin, bool _btOulier)
        {
            btQuitter = _btQuitter;
            btValidLogin = _btValidLogin;
            btOulier = _btOulier;

        }



    }
}
