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
   
    public partial class EnregistreNvStagiaire01 : Window, INotifyPropertyChanged
    {

        // Attributs
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

        // Pour la liste Formation
        DTO_Formation laForma;
        BLL_Formation formaBDD;
        List<string> resultForma = new List<string>();


        // Constructeur
        public EnregistreNvStagiaire01()
        {
            InitializeComponent();
            
            this.DataContext = this;

            // changer le titre de la page xaml
            this.Title = " Gestion des Stagiaire ";
            TxtHautPage = " Enregistre un Nouveau Stagiaire ";

            // gestion des boutons
            btModif.IsEnabled = false;
            btAjouter.IsEnabled = false;
            btSupprimer.IsEnabled = false;

            // On inhibe les TextBox On peut que lire pas ecrire
            txtNomStagiaire.IsEnabled = false;
            txtPrenomStagiaire.IsEnabled = false;
            txtDtNaissanceStagiaire.IsEnabled = false;
            txtSecuStagiaire.IsEnabled = false;
            txtAdresseStagiaire.IsEnabled = false;
            txtCPStagiaire.IsEnabled = false;
            txtVilleStagiaire.IsEnabled = false;

            //remplissage de la combobox formation
            resultForma = formaBDD.ListeForma();
            foreach (string forma in resultForma)
            {
                string[] tabstring = forma.Split('/');
                comboBoxFormation.Items.Add(tabstring[1]);
            }





            // View.MyUserControls.BasPage1 basPage1 = new MyUserControls.BasPage1();







        }


        // ------- Gestion du Go Back
        private void PreviousPage_CanExecute(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private void PreviousPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }
        /*   --------- Fin Gestion du Go Back        */



        // fonction Bouton Ajouter
        private void BtAjouter_Click(object sender, RoutedEventArgs e)
        {
            string le_id_Forma;



            foreach (string forma in resultForma)
            {
                if (forma.Contains(comboBoxFormation.SelectedItem.ToString()))    // PB ici !!!!!!!!!!!!!!!!!!
                {
                    string[] tabString = forma.Split('/');
                    le_id_Forma = tabString[1];
                    break;
                }
            }


            // on verifieque toutes le données sont bien mises dans les textBox

            if (( txtNomStagiaire.Text !="") && ( txtPrenomStagiaire.Text !="" ) && ( txtDtNaissanceStagiaire.Text !="" ) && 
                ( txtSecuStagiaire.Text !="" ) && ( txtAdresseStagiaire.Text !="" ) && ( txtCPStagiaire.Text !="" ) && ( txtVilleStagiaire.Text != ""))
            {








            }
            else
            {
                MessageBox.Show(" remplissez toutes les données ");
            }








        }



    }
}
