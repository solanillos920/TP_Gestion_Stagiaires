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

namespace Travail01.View
{
    
    public partial class EnregistreNvStagiaire02 : Window, INotifyPropertyChanged
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




        // constructeur
        public EnregistreNvStagiaire02()
        {

            InitializeComponent();
            // je fais le lien entre la view et le viewModel de EnregistreNvStagiaire02
            /*   ViewModel.EnregistreNvStagiaireVM enregistreNvStagiaireVM = new ViewModel.EnregistreNvStagiaireVM();
               this.DataContext = enregistreNvStagiaireVM;*/

          

            // je declare et j'instancie le user control du bas de page
            View.MyUserControls.BasPage1 basPage1 = new MyUserControls.BasPage1();
            // grContentBPg.Children.Add(basPage1);//Je l'affiche en l'agoutant au enfant de la grid grContentBPg



            //instanciation des Commandes
            //grContentBPg.    = new ViewModel.CommandMainViewModel(ActionQuitter);

            //  BtQuitter_Click"



            // changer le titre de la page xaml
            this.Title = " Gestion des Stagiaire ";
            TxtHautPage = " Enregistrement un nouveau Stagiaire";
            // gestion des boutons
            btModif.IsEnabled = false;
            btAjouter.IsEnabled = true;
            btSupprimer.IsEnabled = false;

            /*  ViewModel.MainViewModel mainViewModel = new ViewModel.MainViewModel();
            this.DataContext = mainViewModel;*/
            this.DataContext = this;








        }


        //Mise en place des commandes
        public ICommand btQuitterClick { get; set; }

        //fonction quitter dans cette fenetre
        private void ActionQuitter(object parametre)
        {
            View.EnregistreNvStagiaire02 enregistreNvStagiaire02 = new EnregistreNvStagiaire02();
            enregistreNvStagiaire02.Close();
            Hide();
           Close();
            // this.Close();
            MessageBox.Show("Etes vous sur de vouloir quitter l'application : ?");
             // on instancie la fenetre ou on veux  aller ici MainWindows
            //     View.EnregistreNvStagiaire01.Close();
            /*   View.MainPage mainPage = new View.MainPage();
             mainPage.ShowsNavigationUI();

            


           View.MainWindow mainWindow = new View.MainWindow();

               mainWindow.ShowDialog();

            this.Close();  




             Application.Current.Clo;

             Application.Current.Shutdown();
             */






            //Application.Current.Shutdown();
            //  mainWindow.Show();

            /*
            System.Windows.MessageBox.Show ("Etes vous sur de vouloir quitter l'application : ?");// ou mettre un using System.Windows pour trouver le chemein
            System.Windows.Application.Current.Shutdown();// ou mettre un using System.Windows pour trouver le chemein  */
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















    }
}
