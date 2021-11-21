using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail01.Model
{

    class DTO_Utilisateur
    {
        // Attribut
        int idUtilisateur;// clé 1ere
        string nomUtilisateur; //Nom utilisateur pour le login = UserNam
        string passeWord; // mot de passe pour le login
        string email; // adresse Mail
      //  string motPasseMail;

        public int IdUtilisateur { get => idUtilisateur; set => idUtilisateur = value; }
        public string NomUtilisateur { get => nomUtilisateur; set => nomUtilisateur = value; }
        public string PasseWord { get => passeWord; set => passeWord = value; }
        public string Email { get => email; set => email = value; }
       // public string MotPasseMail { get => motPasseMail; set => motPasseMail = value; }
       

        public DTO_Utilisateur()
        {

        }

        // surchargé que du nom utilisateur pour recevoir un Mail
        public DTO_Utilisateur(int _idUtilisateur, string _nomUtilisateur)
        {
            idUtilisateur = _idUtilisateur;   // clé 1ere
            nomUtilisateur = _nomUtilisateur; // Non Utilisateur pour le login
         
        }

   /*     public DTO_Utilisateur(int _idUtilisateur, string _nomUtilisateur, string _motPasseMail  )
        {
            idUtilisateur = _idUtilisateur;// clé 1ere
            nomUtilisateur = _nomUtilisateur;
            motPasseMail = _motPasseMail;

        }*/



        // surchargé que du nom et mot de passe
        public DTO_Utilisateur(int _idUtilisateur, string _nomUtilisateur, string _passeWord)
        {
            idUtilisateur = _idUtilisateur;   // clé 1ere
            nomUtilisateur = _nomUtilisateur; // Non Utilisateur pour le login
            passeWord = _passeWord;           // mot de passe pour le login



        }

        // suechargé de tous les attributs
        public DTO_Utilisateur(int _idUtilisateur, string _nomUtilisateur, string _passeWord, string _email)
        {
            idUtilisateur = _idUtilisateur;   // clé 1ere
            nomUtilisateur = _nomUtilisateur; // Non Utilisateur pour le login
            passeWord = _passeWord;           // mot de passe pour le login
            email = _email;                   // adresse Mail



        }

    }
}
