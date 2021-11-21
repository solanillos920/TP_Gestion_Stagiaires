using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Travail01.Model
{
    

    class User_BDD
    {
        // les Attributs 
        int idUtilisateur;
        string nomUtilisateur;
        string passeWord;
        string email;


        // les getteurs /  setteurs
  
        public int IdUtilisateur { get => idUtilisateur; set => idUtilisateur = value; } // Clé primaire
      
        public string NomUtilisateur { get => nomUtilisateur; set => nomUtilisateur = value; }
       
        public string PasseWord { get => passeWord; set => passeWord = value; }

        public string Email { get => email; set => email = value; }

        // constructeur
        public User_BDD()
        {
            idUtilisateur = 0;
            nomUtilisateur = "";
            passeWord = "";
            email = "";

        }

        //Constructeur
        public User_BDD(int _idUtilisateur, string _nomUtilisateur, string _passeWord, string _email)
        {
            idUtilisateur = _idUtilisateur;
            nomUtilisateur = _nomUtilisateur;
            passeWord = _passeWord;
            email = _email;

        }


    }





}
