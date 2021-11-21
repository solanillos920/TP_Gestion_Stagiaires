using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail01.Model
{
    class DTO_Mail
    {
        int idUtilisateur;
        string email;
        string motPasseMail;

        public int IdUtilisateur { get => idUtilisateur; set => idUtilisateur = value; }
        public string Email { get => email; set => email = value; }
        public string MotPasseMail { get => motPasseMail; set => motPasseMail = value; }
       

        public DTO_Mail()
        {

        }

        public DTO_Mail(int _idUtilisateur, string _motPasseMail)
        {
            idUtilisateur = _idUtilisateur;          
            motPasseMail = _motPasseMail;
        }

      
        public DTO_Mail(int _idUtilisateur, string _email, string _motPasseMail)
        {
           idUtilisateur = _idUtilisateur;
           email = _email;
           motPasseMail = _motPasseMail;
        }











    }
}
