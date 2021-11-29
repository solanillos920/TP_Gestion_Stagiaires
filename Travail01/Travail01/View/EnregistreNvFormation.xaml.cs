using System;
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
using Travail01.Model;

namespace Travail01.View
{
        public partial class EnregistreNvFormation : Window, INotifyPropertyChanged
    {

        // Attributs
        string txtHautPage;

        // Pour les dates du satge
        string dateduJour; // la date du jour pour le DatePicker debut de stage
        string dateduJourFin; // la date du jour pour le DatePicker fin de stage

        public string TxtHautPage { get => txtHautPage; set { txtHautPage = value; OnPropertyChanged("TxtHautPage"); } }

        public string DateduJour { get => dateduJour; set { dateduJour = value; OnPropertyChanged("DateduJour");}}
        public string DateduJourFin { get => dateduJourFin; set { dateduJourFin = value; OnPropertyChanged("DateduJourFin"); } }

        //notification de l'evenement Property Changed

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(v));
            }

        }



        // drapeau 
        bool drapeauChoixPole = false;
        bool drapeauChoixQualif = false;

        //Pour la liste formation
        DTO_Formation laForma;// using Travail01.Model  ->  sinon mettre le chemin entier => Model.DTO_Formation etc...
        BLL_Formation formaBDD;
        //   List<string> resultForma = new List<string>();

        // Pour la Liste Pole de Formation
        DTO_Pole lePole;
        BLL_Pole poleBDD;
        List<string> resultPole = new List<string>();

        // Pour la Liste Qualification
        DTO_Qualif laQualif;
        BLL_Qualification qualifBDD;
        List<string> resultQualif = new List<string>();
                       
        // le Constucteur
        public EnregistreNvFormation()
        {
            formaBDD = new BLL_Formation();
            poleBDD = new BLL_Pole();
            qualifBDD = new BLL_Qualification();

            InitializeComponent();

            // la date du jour
            DateTime dateMachine = new DateTime();
            dateMachine = DateTime.Now;

            // pour mettre la date du jour dans  le DatePicker debut de stage
            DateduJour = dateMachine.ToShortDateString();// retourne que la date : 02/11/2021

            // pour mettre la date du jour dans  le DatePicker fin de stage
            DateduJourFin = dateMachine.ToShortDateString();// retourne que la date : 02/11/2021

            /*---------------
                        string[] formaDate = DateduJour.Split('/');                     
                            -----------------*/


            // changer le titre de la page xaml
            this.Title = " Gestion des Stagiaires ";
            TxtHautPage = " Enregistrement Nouvelle Formation";
            // gestion des boutons
            btModif.IsEnabled = false;
            btAjouter.IsEnabled = false;
            btSupprimer.IsEnabled = false;

       //     dpDebForma.IsEnabled = false;

            // On inhibe les textbox tant que les combobox ne sont pas utilisés
            txtBoxNumForma.IsEnabled = false;
            txtBoxIntituleForma.IsEnabled = false;
            txtBoxnbHeureForma.IsEnabled = false;
            txtBoxnbHeureCours.IsEnabled = false;
            txtBoxnbHeureStg.IsEnabled = false;
     //       txtBoxdtDebForma.IsEnabled = false;
     //       txtBoxdtFinForma.IsEnabled = false;
            txtBoxnbStage.IsEnabled = false;
            txtBoxPeriodestg.IsEnabled = false;
            //
            comboBoxQualif.IsEnabled = false;   // on peut lire mais pas ecrire sur le comboBox

            this.DataContext = this;
            
            //replissage de la comboBox Pole
            resultPole = poleBDD.ListePole(); // resultate = fonction ListePole() de type "List<string>" de la classe  BLL_Pole
            foreach (string pole in resultPole) // à chaque iteration je prends un element de ma liste et le mets dans la variable pole
            {
                string[] tabString = pole.Split('/'); // Divise une chaîne en sous-chaînes en fonction de caractères de délimitation spécifiés ici '/' et le met dans un tableau             
                comboBoxPole.Items.Add(tabString[1]); //Dans comboBoxPole j'ajoute un item
            }

            //replissage de la comboBox Qualification
            resultQualif = qualifBDD.ListeQualif();// resultate = fonction ListePole() de type "List<string>" de la classe  BLL_Pole
            foreach (string qualif in resultQualif)// a chaque iteration je prends un element de ma liste et le mets dans la variable pole
            {
                string[] tabString = qualif.Split('/'); // Divise une chaîne en sous-chaînes en fonction de caractères de délimitation spécifiés ici '/' et le mets dans un tableau             
                comboBoxQualif.Items.Add(tabString[1]); //Dans comboBoxQualif j'ajoute un item
            }
                    
        }



        /*  ------  Gestion du Go Back--------    */
        private void PreviousPage_CanExecute(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private void PreviousPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }
        /* ---------- FIN de la Gestion du Go Back ------------   */



        // Appui sur le bouton Ajouter nouvelle Formation 
        private void BtAjouter_Click(object sender, RoutedEventArgs e)
        {
            int indexPole = comboBoxPole.SelectedIndex;
            int indexQualif = comboBoxQualif.SelectedIndex;

            string le_id_Pole = "";
            string la_id_Qualif = "";
            string formatted = string.Empty;// bien que vide il faut lui préciser que la chaine est vide sinon il pense que c'est indeterminé!!!
            string formattedFin = string.Empty; // idem

            DateTime dateduJour = new DateTime();// on declare et on l'instancie DataPicker
            dateduJour = DateTime.Now; // avec Now on met la date du moment

            // idem pour la DataPicker de fin de stage
            DateTime dateduJourFin = new DateTime();
            dateduJourFin = DateTime.Now;

            // selection la date debut
            DateTime? selectedDate = dpDebForma.SelectedDate;// DateTime? avec ? on peut avoir un null: resultat= 14/01/2021 00:00:00
                                                             //    DateTime? dateDebut = dpDebForma.SelectedDate; 

            DateTime? selectedDateFin = dpFinForma.SelectedDate;

            //     DateduJour = dateMachine.ToShortDateString();// retourne que la date : 02/11/2021

            if (selectedDate.HasValue) // si il y a une valeur => true
            {
                formatted = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);//la valeur est mise au forma string : mmois/Jour/Année
                MessageBox.Show(formatted, "c'est la date début sélectionnée !! ");
            }

            if (selectedDate.HasValue)
            {
                formattedFin = selectedDateFin.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);//la valeur est mise au forma string : mmois/Jour/Année
                MessageBox.Show(formattedFin, "c'est la date fin sélectionnée !! ");

            }

            string[] formaDate = formatted.Split('.'); // car le separateur entre :" jour . mois . année " est un point
            string dateformaBase = formaDate[2] + "-" + formaDate[1] + "-" + formaDate[0];  // la date de debut stage au format pour la base
            // plus besoin car DataPicker est mis au format francais dans Xaml ... Donc formatted est au bon format pour le DataPicker
        //  string datformaAffichage = formaDate[1] + "-" + formaDate[0] + "-" + formaDate[2]; // plus besoin

            string[] formaDateFin = formattedFin.Split('.');
            string dateformaFinBase = formaDateFin[2] + "-" + formaDateFin[1] + "-" + formaDateFin[0];// mois-jour-année format pour la base
            
            foreach (string pole in resultPole)
            {
                if (pole.Contains(comboBoxPole.SelectedItem.ToString()))   
                {
                    string[] tabString = pole.Split('/');
                    le_id_Pole = tabString[1];
                    break;
                }
            }

            foreach (string cat in resultQualif)
            {
                if (cat.Contains(comboBoxQualif.SelectedItem.ToString()))
                {
                    string[] tabString = cat.Split('/');
                    la_id_Qualif = tabString[2];
                    break;
                }
            }


            // on verifie que toutes le données sont bien mises dans les textBox

            if (( txtBoxNumForma.Text != "" ) && ( txtBoxIntituleForma.Text != "" ) && 
                ( txtBoxnbHeureForma.Text != "" ) && ( txtBoxnbHeureCours.Text != "" ) && ( txtBoxnbHeureStg.Text != "" ) && 
     //           ( txtBoxdtDebForma.Text != "" ) && (   txtBoxdtFinForma.Text != "" ) && // j'ai mis un  DataPicker qui est mis à la date du jour
                (  txtBoxnbStage.Text != ""  ) && (  txtBoxPeriodestg.Text !="" ) )                            
            {
                
                // 
                laForma = new DTO_Formation(1, txtBoxNumForma.Text, txtBoxIntituleForma.Text, Convert.ToInt32(txtBoxnbHeureForma.Text),
                Convert.ToInt32(txtBoxnbHeureCours.Text), Convert.ToInt32(txtBoxnbHeureStg.Text),        //       
                formatted, formattedFin, //  txtBoxdtDebForma.Text, txtBoxdtFinForma.Text,
                Convert.ToInt32(txtBoxnbStage.Text), Convert.ToInt32(txtBoxPeriodestg.Text), indexPole, indexQualif);                               
                
                if (formaBDD.AjouterForma(laForma) == true)
                    this.Close();
                else
                    MessageBox.Show("Erreur de base de donnéés");                
            }
            else
            {
                MessageBox.Show(" Remplisez toutes les données");
            }
        }


        // On oblige au préalable à choisir un Pole
        private void ComboBoxPole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indexComboPole = (comboBoxPole.SelectedIndex)+0; // car le 1er commence à 0

            DTO_Pole SelectPoleDTO = new DTO_Pole();

            // je prends que le numero du pole 
            SelectPoleDTO.NumPole = resultPole[indexComboPole].Split('/')[1];                                

            if (SelectPoleDTO.NumPole !="") // si la zonne texte n'est pas vide
            {
                drapeauChoixPole = true;
                comboBoxQualif.IsEnabled = true;   // on peut lire mais pas ecrire sur le comboBox
            }
        }

        // Apres le pole, on oblige à choisir une qualification de formation  
        private void ComboBoxQualif_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indexComboQualif = (comboBoxQualif.SelectedIndex) + 1; // car le 1er commence à 0

            DTO_Qualif SelectQualifDTO = new DTO_Qualif();

            // je recupere que le numero de la qualification de la formation
            SelectQualifDTO.NumQualif = resultQualif[indexComboQualif].Split('/')[1];
                   
            if (SelectQualifDTO.NumQualif !="")   // si la zone texte n'est pas vide 
            {
                drapeauChoixQualif = true;
                btAjouter.IsEnabled = true; // on active le bouton Ajouter           
            }
                
            ActiveLesTextBox();
        }


        private void ActiveLesTextBox()
        {
            if (drapeauChoixPole == true )
            {
                if (drapeauChoixQualif == true)
                {
                    // on active les textbox
                    txtBoxNumForma.IsEnabled = true;
                    txtBoxIntituleForma.IsEnabled = true;
                    txtBoxnbHeureForma.IsEnabled = true;
                    txtBoxnbHeureCours.IsEnabled = true;
                    txtBoxnbHeureStg.IsEnabled = true;
              //    txtBoxdtDebForma.IsEnabled = true; // c'est un DataPicker 
              //    txtBoxdtFinForma.IsEnabled = true; // c'est un DataPicker
                    txtBoxnbStage.IsEnabled = true;
                    txtBoxPeriodestg.IsEnabled = true;
                }
            }
        }
    }
}
