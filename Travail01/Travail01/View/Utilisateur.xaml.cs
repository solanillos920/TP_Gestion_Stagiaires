using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Travail01.ViewModel;
using MySql.Data.MySqlClient;// il faut mettre ça mais ça et ça marche !!
using Travail01.Model;
using System;

using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Travail01.View
{
 
  
    public partial class Utilisateur : Window, INotifyPropertyChanged
    {


        // Attribut
        string txtHautPage;

        public string TxtHautPage { get => txtHautPage; set { txtHautPage = value; OnPropertyChanged("TxtHautPage"); } }

        //notification de l'evenement Property Changed

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }


        // Attribut 



        // 
        DTO_Utilisateur utilise;    // Je declare une variable de type  DTO_utiliateur
        DTO_Mail mail;              // je declare une variable de type  DTO_Mail                  
        BLL_Utilisateur utiliseBDD; // Je declare une variable de type  BLL_Utilisateur

        // je créer une liste des Nom Utilidateur
       // List<string> resultatNom_Utilisateur = new List<string>();



        public Utilisateur()
        {
            InitializeComponent();


            //position de la fenetre dans l'espace "écran"
            WindowStartupLocation = WindowStartupLocation.CenterScreen; // au lieur de l'écran



            this.DataContext = this;

            // changer le titre de la page xaml
            this.Title = " Gestion des Stagiaire ";
            TxtHautPage = " Login";                      

            // gestion des boutons
            btValidLogin.IsEnabled = true;
            btQuitter.IsEnabled = true;
            btMot_Passe_Oublier.IsEnabled = true;
          


            utiliseBDD = new BLL_Utilisateur();// j'instancie la l'objet 


            /*-----------------   INUTIL!!!!!! c'est dans le BLL  --------  *

          Travail01.ViewModel.BddMySql Bdd = new BddMySql("localhost", 3306, "travail01", "root", "solanillos");//car le BddMySql se trouve dans le dossier View.model
          bool OuvertureOk = Bdd.OuvrirConnexion();


          // requete que je fais sur cette base
          string requete = ("SELECT * from utilisateur").ToString();
          // tableau est la variable qui contient le result de la requete
          MySqlDataReader tableau = Bdd.RequeteSql(requete);

          string connectionString = "localhost, 3306, travail01, root, solanillos";

          MySqlConnection connection = new MySqlConnection(connectionString);


          //     MessageBox.Show(tableau[1].ToString());//je dois avoir "solanillos"
          MySqlCommand command = new MySqlCommand("SELECT * from travail01", connection);

          *--------------------*/

            //instanciation des Commandes
            btQuitterClick = new ViewModel.CommandMainViewModel(ActionQuitter);
            goFenetrePrincipale = new CommandMainViewModel(ActionFenetrePrincipale);





        }


        //Mise en place des commandes
        public ICommand btQuitterClick { get; set; }
        public ICommand goFenetrePrincipale { get; set; }




        private void ActionQuitter(object parametre)
        {

            MessageBoxResult selection = MessageBox.Show("Etes vous sur de vouloir quitter l'application : ?", "repondre", MessageBoxButton.OK);
            //Je quitte l'application
            Application.Current.Shutdown();
        }

        private void ActionFenetrePrincipale(object parametre)
        {
            // on instancie la fenetre principale de l'application
            MainWindow mainWindow = new MainWindow();
        }






        // fonction pour valider ou pas le login!
        private void BtValidLogin_Click(object sender, RoutedEventArgs e)
        {
              
            // Attributs 
            string le_Login_Taper = txtLogin.Text;                 
            string le_PasseWord_Taper = pwMot_de_Passe.Password;  // le contenue de passeword      txtPasseWord.Text; 
                      
            // verifions que les textbox sont pas vide
            if ((le_Login_Taper != "") && (le_PasseWord_Taper != ""))
            { 
                // methode de control

                // instancie un DTO pour setter lelogin et mot de passe
                utilise = new DTO_Utilisateur(1, le_Login_Taper, le_PasseWord_Taper);

                //Je passe en parametre utilisateur dans la fonction LireUtilisateur de la classe BLL_Utilisateur 
                // la fonction de la classe BLL_Utilisateur execute la requete et si le login est vrai la fonction revoit true
                if (utiliseBDD.LireUtilisateur(utilise) == true) // si c'est vrai que ça merde
                {
                    // aller vers la fenetre  principale  
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.ShowDialog();
                    this.Close(); // je ferme la fenetre de login
                }
            }
            else
            {
                MessageBox.Show("replisser les champs !!");
            }
            
        }


        private void BtMot_Passe_Oublier_Click(object sender, RoutedEventArgs e)
        {
            string le_Login_Taper = txtLogin.Text; // C'est le nom utilisateur 
            string le_mail = string.Empty;    // chaine vide 
            string le_Mot_Pass_Mail = string.Empty; // chaine vide 

            // déclare un tuple que l'on appelle tuple
            (string, string,string,string) tuple; //nom, mail, motde passe

            // index du nom utilisateur 
            //    int indexNom_Utilisateur = utiliseBDD.recupPK(le_Login_Taper ); 

            // récupérer un tuple
            tuple = utiliseBDD.RecupMotdePasse(le_Login_Taper);



            /* mail*/
            string server = "smtp.gmail.com"; // car c'est @gmail.com
            int port = 587;

            string GmailUser = tuple.Item3;   // "tempoocasion@gmail.com";             //  tuple(0);     
            string GmailPass = tuple.Item4;   // "passe-TO-00";



            /* -- Debut: recuperation adresse Mai et son mot de passe  -- */
            /*      demander le Mail et son mot de pas dans la Base de données                  */


            // verifions que le textbox n'est pas vide
            if (le_Login_Taper != "")
            { // methode de control

                // instancie un DTO pour setter lelogin et mot de passe
                utilise = new DTO_Utilisateur(1, le_Login_Taper);

                //
                if (utilise.NomUtilisateur == null) // si c'est vrai que ça merde
                {
                    MessageBox.Show("remplisser le mot de passe qui est dans votre boite Mail !!");
                }

            }
            else
            {
                MessageBox.Show("remplisser les champs !!");
            }




            /*   fin    demander le Mail et son mot de pas dans la Base de données          */

             /* -- Fin: recuperation adresse Mai et son mot de passe  -- */






            /* --- debut message --- */
            MimeMessage message = new MimeMessage();
            // From => qui envoie le message et les paramètres (le nom , la direction)
            message.From.Add(new MailboxAddress("Prueba", GmailUser));
            // to => qui recoit le message
            message.To.Add(new MailboxAddress("Destino", GmailUser));
            /* ---- si envoie à plusieur e-mail ----- */
            //   message.To.Add(new MailboxAddress("Destino", "autre email"));

            // on definit notre sujet du message
            message.Subject = " Hola la  voici votre mot passWord pour vous connectez ";   // qui est le mot de passe           

            /* -- le corps du message -- */
            // soit une variable qui est le corps du message
            BodyBuilder corpsMessage = new BodyBuilder();
            corpsMessage.TextBody = tuple.Item2;     //     " Hola ";               
           // corpsMessage.TextBody = "Hola <b>Mondo</b> ";   // messge en HTML


            message.Body = corpsMessage.ToMessageBody(); //ToMessageBody() prepare le message pour que smtp le reconnaise et l'envoie bien

            /* --- fin message --- */

            // reste se connecter à smtp et faire l'envoie du mail
            SmtpClient clientSmtp = new SmtpClient(); // Attention  " SmtpClient " C'est un Smtp qui vient de Mailkit et pas de sytem.Net.Mail qui à le même nom
            // desactiver un
            clientSmtp.CheckCertificateRevocation = false;
            // se connecter
            clientSmtp.Connect(server, port, MailKit.Security.SecureSocketOptions.StartTls);      //  
            // on s'identifie
            clientSmtp.Authenticate(GmailUser, GmailPass);
            // l'envoie
            clientSmtp.Send(message);
            // se deconnecter
            clientSmtp.Disconnect(true);




        }

       












        // methode de verif du mot de passe 

        private void BtQuitter_Click(object sender, RoutedEventArgs e)
        {
            Cde_Bt_Login cde_Bt_Login = new Cde_Bt_Login();
            cde_Bt_Login.BtOulier = true;

            MessageBox.Show("Vous allez quitter l'application");
        }

       








    }
}
