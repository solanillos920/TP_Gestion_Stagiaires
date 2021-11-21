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
        
    public partial class EnregistreNvPole : Window, INotifyPropertyChanged
    {

        // Attributs
        string txtHautPage;
     //  private string infoconnexion; // le Binding sur la connexion ... du texte 

        public string TxtHautPage { get => txtHautPage; set { txtHautPage = value; OnPropertyChanged("TxtHautPage"); } }
     //   public string Infoconnexion { get { return infoconnexion; } set { infoconnexion = value; OnPropertyChanged("Infoconnexion"); } }

        //notification de l'evenement Property Changed

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }


        DTO_Pole lePole; // est une varuiable de type DTO_Pole
        BLL_Pole poleBDD; // est une varuiable de type BLL_Pole



        // Le Constructeur 
        public EnregistreNvPole()
        {
            poleBDD = new BLL_Pole();

            InitializeComponent();

            // changer le titre de la page xaml
            this.Title = " Enregistrement d'un nouveau Pole  ";
            TxtHautPage = " Enregistrement d'un nouveau Pole ";
            
            // gestion des boutons
            btModif.IsEnabled = false;
            btAjoutePole.IsEnabled = true;
            btSupprimer.IsEnabled = false;
           
            /*  ViewModel.MainViewModel mainViewModel = new ViewModel.MainViewModel();
            this.DataContext = mainViewModel;*/
            this.DataContext = this;

            


        }



        // retour à la fenetre pre
        private void PreviousPage_CanExecute(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void PreviousPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

       

        private void BtAjoutePole_Click(object sender, RoutedEventArgs e)
        {
            // Je n'ai pas besoin d'index car je ne dois pas clicker sur les items du combobox 
            //Si je clicke sur un item je dois inhiber la touche Ajouter!!! C'est fait dans la fonction " CamboPole_SelectionChanged "
            // int index = comboBoxPole.SelectedIndex;// je créer une variable index en fonction de la selection 
            //  int indexAmodifier = int.Parse(resultPole[index].Split('/')[0]); // je trouve la valeur de l'index du pole à ajouter

            // on verifieque toutes le données sont bien mises dans les textBox

            if (( txtNumPole.Text !="" ) && ( txtDesignaPole.Text !=""))
            {

                

                lePole = new DTO_Pole(0, txtNumPole.Text, txtDesignaPole.Text);
                if ( poleBDD.AjouterPole(lePole) == true )
                    MessageBox.Show("un pole  a ete ajouté ");
                //  this.Close();            
                else
                    MessageBox.Show("Errure de la base de données");

            }
            else
            {
                MessageBox.Show(" Remplisez toutes les données");
            }


        }






    }
}
