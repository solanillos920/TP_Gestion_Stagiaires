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
    /// <summary>
    /// Logique d'interaction pour EnregistreNvQualif.xaml
    /// </summary>
    public partial class EnregistreNvQualif : Window, INotifyPropertyChanged
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

        DTO_Qualif laQualif; // est une variable d type DTO_Qualif
        BLL_Qualification qualifBDD; // est une variable de type BLL_Qualification
      

        // le constructeur
        public EnregistreNvQualif()
        {
            qualifBDD = new BLL_Qualification();
          
            InitializeComponent();

            // changer le titre de la page xaml
            this.Title = " Gestion des Stagiaire ";
            TxtHautPage = " Enregistrement nouvelle Qualification ";

            // gestion des boutons
            btModif.IsEnabled = false;
            btAjouter.IsEnabled = true;
            btSupprimer.IsEnabled = false;

            /*  ViewModel.MainViewModel mainViewModel = new ViewModel.MainViewModel();
            this.DataContext = mainViewModel;*/
            this.DataContext = this;




        }


        //Gestion du Go Back
        private void PreviousPage_CanExecute(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private void PreviousPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }


        // fonction Ajouter
        private void BtAjouter_Click(object sender, RoutedEventArgs e)
        {
            // Je n'ai pas besoin d'index car je ne dois pas clicker sur les items du combobox 
            //Si je clicke sur un item je dois inhiber la touche Ajouter!!! C'est fait dans la fonction " CamboPole_SelectionChanged "
            // int index = comboBoxPole.SelectedIndex;// je créer une variable index en fonction de la selection 
            //  int indexAmodifier = int.Parse(resultPole[index].Split('/')[0]); // je trouve la valeur de l'index du pole à ajouter

            // on verifieque toutes le données sont bien mises dans les textBox
            if (( txtNumQualif.Text !="" ) && ( txtNomQualif.Text !="" ) && ( txtNivQualif.Text!="" ) && ( txtDescripQualif.Text != "" ))
            {



         





                laQualif = new DTO_Qualif(0, txtNumQualif.Text, txtNomQualif.Text, txtNivQualif.Text, txtDescripQualif.Text);
                if (qualifBDD.AjouterQualif(laQualif) == true)
                    MessageBox.Show("une qualification a ete ajouté ");
                //  this.Close();            
                else
                    MessageBox.Show("Errure de la base de données");




                        //  txtNumQualif    txtNomQualif         txtNivQualif     txtDescripQualif


            }
            else
            {
                MessageBox.Show(" Remplisez toutes les données ");
            }








        }
    }
}
