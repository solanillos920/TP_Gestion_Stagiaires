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
    
    public partial class ModifSupprimQualif : Window, INotifyPropertyChanged
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

        DTO_Qualif laQualif; // est une variable d type DTO_Qualif on aussi utilise using Travail.Model
        BLL_Qualification qualifBDD; // est une variable de type BLL_Qualification
        List<string> resultQualif = new List<string>();


        // Le constructeur 
        public ModifSupprimQualif()
        {            
            qualifBDD = new BLL_Qualification();

            InitializeComponent();

            this.DataContext = this;

            // changer le titre de la page xaml
            this.Title = " Gestion des Stagiaire ";
            TxtHautPage = " Modifier ou Supprimer une Qualification ";

            // gestion des boutons
            btModif.IsEnabled = false;
            btAjouter.IsEnabled = false;
            btSupprimer.IsEnabled = false;

            // On inhibe les TextBox On peut que lire pas ecrire
            txtNumQualif.IsEnabled = false;
            txtNomQualif.IsEnabled = false;
            txtNivQualif.IsEnabled = false;
            txtDescripQualif.IsEnabled = false;

            //replissage de la comboBox Pole
            resultQualif = qualifBDD.ListeQualif();// resultate = fonction ListePole() de type "List<string>" de la classe  BLL_Pole
            foreach (string qualif in resultQualif)// a chaque iteration je prends un element de ma liste et le mets dans la variable pole
            {
                string[] tabString = qualif.Split('/'); // Divise une chaîne en sous-chaînes en fonction de caractères de délimitation spécifiés ici '/' et le mets dans un tableau             
                comboBoxQualif.Items.Add(tabString[1]); //Dans comboBoxPole j'ajoute un item
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




        // Fonction pour le bouton Modifier une qualification de formation
        private void BtModif_Click(object sender, RoutedEventArgs e)
        {

            int index = comboBoxQualif.SelectedIndex; // je créer une variable index en fonction de la selection 
            int indexAmodifier = int.Parse(resultQualif[index].Split('/')[0]); // je trouve la valeur de l'index du pole à modifier

            DTO_Qualif SelectQualifDTO = new DTO_Qualif(indexAmodifier, txtNumQualif.Text, txtNomQualif.Text, txtNivQualif.Text,  txtDescripQualif.Text);

            if (qualifBDD.ModifierQualif(SelectQualifDTO))
            {
                MessageBox.Show("La qualification id = " + indexAmodifier + " a été modifier");
                // Close();
            }
            else
            {
                MessageBox.Show(" Erreur de suppression !");
            }

       //     txtNumQualif       txtNomQualif         txtNivQualif      txtDescripQualif

        }


        // fonction pour supprimer une qualification de formation
        private void BtSupprimer_Click(object sender, RoutedEventArgs e)
        {
            int index = comboBoxQualif.SelectedIndex;// je créer une variable index en fonction de la selection 
            DTO_Qualif SelectQualifDTO = new DTO_Qualif();

            SelectQualifDTO.NumQualif = resultQualif[index].Split('/')[1];
            SelectQualifDTO.NomQualif = resultQualif[index].Split('/')[2];
            SelectQualifDTO.NiveauQualif = resultQualif[index].Split('/')[3];
            SelectQualifDTO.DescriptionQualif = resultQualif[index].Split('/')[4];

            qualifBDD.SupprimerQualif(SelectQualifDTO);
            AfficherInfosQualif(SelectQualifDTO);

            if (qualifBDD.SupprimerQualif(SelectQualifDTO))
            {
                MessageBox.Show(" Le Pole " + SelectQualifDTO.NumQualif + "  à été supprimer");
            }
            else MessageBox.Show("Erreur de la suppression !");
        }


        private void ComboBoxQualif_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = comboBoxQualif.SelectedIndex;

            // Si on selectionne un item de la ComboBox, on n'autorise pas un nouvel Ajout dans la base
            /*   if (index != 0)
               {
                   // inhibe les bouton
                   btNouveau.IsEnabled = false;              

                   // Message avec réponse avec yes / non + icon Warning + preselection Non
                   MessageBox.Show("Vous ne pouvez pas clicker sur un item pour ajouter un club !", " ATTENTION !! ", MessageBoxButton.OK, MessageBoxImage.Warning);
               }*/

            DTO_Qualif SelectQualifDTO = new DTO_Qualif();

            SelectQualifDTO.NumQualif = resultQualif[index].Split('/')[1];
            SelectQualifDTO.NomQualif = resultQualif[index].Split('/')[2];
            SelectQualifDTO.NiveauQualif = resultQualif[index].Split('/')[3];
            SelectQualifDTO.DescriptionQualif = resultQualif[index].Split('/')[4]; // autre metode de convertion -->  Convert.ToInt32( tra la la la etc...   );
            AfficherInfosQualif(SelectQualifDTO);
        }

      //  laQualif = new DTO_Qualif(0, txtNumCertif.Text, txtNomCertif.Text, (txtNivQualif.Text), txtDescripQualif.Text);


        private void AfficherInfosQualif(DTO_Qualif qualif)
        {
            // on active les textbox
            txtNumQualif.IsEnabled = true;
            txtNomQualif.IsEnabled = true;
            txtNivQualif.IsEnabled = true;
            txtDescripQualif.IsEnabled = true;

            // On active les boutons
            btModif.IsEnabled = true;          
            btSupprimer.IsEnabled = true;

            // c'est que pour les Textbcklo
            txtNumQualif.Text = qualif.NumQualif;
            txtNomQualif.Text = qualif.NomQualif;            
            txtNivQualif.Text = qualif.NiveauQualif;
            txtDescripQualif.Text = qualif.DescriptionQualif;

        }

     

       //      txtNumQualif       txtNomQualif         txtNivQualif      txtDescripQualif


    }
}
