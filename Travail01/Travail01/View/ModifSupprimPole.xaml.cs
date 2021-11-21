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
   
    public partial class ModifSupprimPole : Window, INotifyPropertyChanged
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


        DTO_Pole lePole; // est une varuiable de type DTO_Pole
        BLL_Pole poleBDD; // est une varuiable de type BLL_Pole
        List<string> resultPole = new List<string>();

        // Le constructeur
        public ModifSupprimPole()
        {
            poleBDD = new BLL_Pole();

            InitializeComponent();
            
            /*  ViewModel.MainViewModel mainViewModel = new ViewModel.MainViewModel();
            this.DataContext = mainViewModel;*/
            this.DataContext = this;

            // changer le titre de la page xaml
            this.Title = " Gestion des Stagiaire ";
            TxtHautPage = " Modifier ou Supprimer un Pole ";

            // gestion des boutons
            btModif.IsEnabled = false;  
            btAjouter.IsEnabled = false;
            btSupprimer.IsEnabled = false;

            // On inhibe les TextBox On peut que lire pas ecrire
            txtNumPole.IsEnabled = false;
            txtDesignaPole.IsEnabled = false;

            //replissage de la comboBox Pole
            resultPole = poleBDD.ListePole();// resultate = fonction ListePole() de type "List<string>" de la classe  BLL_Pole
            foreach (string pole in resultPole)// a chaque iteration je prends un element de ma liste et le mets dans la variable pole
            {
                string[] tabString = pole.Split('/'); // Divise une chaîne en sous-chaînes en fonction de caractères de délimitation spécifiés ici '/' et le mets dans un tableau             
                comboBoxPole.Items.Add(tabString[1]); //Dans comboBoxPole j'ajoute un item
            }
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

        
        
/*
        private void BtAjoute_Click(object sender, RoutedEventArgs e)
        {
            // Je n'ai pas besoin d'index car je ne dois pas clicker sur les items du combobox 
            //Si je clicke sur un item je dois inhiber la touche Ajouter!!! C'est fait dans la fonction " CamboPole_SelectionChanged "
            // int index = comboBoxPole.SelectedIndex;// je créer une variable index en fonction de la selection 
            //  int indexAmodifier = int.Parse(resultPole[index].Split('/')[0]); // je trouve la valeur de l'index du pole à ajouter

            lePole = new DTO_Pole(0, txtNumPole.Text, txtDesignaPole.Text);
            if (poleBDD.AjouterPole(lePole) == true)
                MessageBox.Show("un pole  a ete ajouté ");
            //  this.Close();            
            else
                MessageBox.Show("Errure de la base de données");
        }*/


        // Fonction pour Modifier un pole
        private void BtModif_Click(object sender, RoutedEventArgs e)
        {
            int index = comboBoxPole.SelectedIndex; // je créer une variable index en fonction de la selection 
            int indexAmodifier = int.Parse(resultPole[index].Split('/')[0]); // je trouve la valeur de l'index du pole à modifier

            DTO_Pole SelectPoleDTO = new DTO_Pole(indexAmodifier, txtNumPole.Text, txtDesignaPole.Text);

            if (poleBDD.ModifierPole(SelectPoleDTO))
            {
                MessageBox.Show("Le pole id = " + indexAmodifier + " a été modifier");
                // Close();
            }
            else
            {
                MessageBox.Show(" Erreur de suppression !");
            }


        }


    




        private void BtSupprimer_Click(object sender, RoutedEventArgs e)
        {
            int index = comboBoxPole.SelectedIndex;// je créer une variable index en fonction de la selection 
            DTO_Pole SelectPoleDTO = new DTO_Pole();

            SelectPoleDTO.NumPole = resultPole[index].Split('/')[1];
            SelectPoleDTO.DesignationPole = resultPole[index].Split('/')[2];

            poleBDD.SupprimerPole(SelectPoleDTO);
            AfficherInfosPole(SelectPoleDTO);

            if (poleBDD.SupprimerPole(SelectPoleDTO))
            {
                MessageBox.Show(" Le Pole " + SelectPoleDTO.NumPole + "  à été supprimer");
            }
            else MessageBox.Show("Erreur de la suppression !");


        }





       

        private void ComboBoxPole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = comboBoxPole.SelectedIndex;

            // Si on selectionne un item de la ComboBox, on n'autorise pas un nouvel Ajout dans la base
            /*   if (index != 0)
               {
                   // inhibe les bouton
                   btNouveau.IsEnabled = false;              

                   // Message avec réponse avec yes / non + icon Warning + preselection Non
                   MessageBox.Show("Vous ne pouvez pas clicker sur un item pour ajouter un club !", " ATTENTION !! ", MessageBoxButton.OK, MessageBoxImage.Warning);
               }*/

            DTO_Pole SelectPoleDTO = new DTO_Pole();

            SelectPoleDTO.NumPole = resultPole[index].Split('/')[1];
            // autre metode de convertion -->  Convert.ToInt32( tra la la la etc...   );
            SelectPoleDTO.DesignationPole = resultPole[index].Split('/')[2];
            AfficherInfosPole(SelectPoleDTO);

        }


       
    

        private void AfficherInfosPole(DTO_Pole pole)
        {
            // on active les textbox
            txtNumPole.IsEnabled = true;
            txtDesignaPole.IsEnabled = true;

            // On active les boutons
            btModif.IsEnabled = true;
            btSupprimer.IsEnabled = true;

            // c'est que pour les Textbcklo
            txtNumPole.Text = (pole.NumPole).ToString(); // il faut le parser en string
            txtDesignaPole.Text = pole.DesignationPole;
        }










    }
}
