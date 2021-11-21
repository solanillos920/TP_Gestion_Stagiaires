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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Travail01.View
{
    
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        // Attribut
        string txtHautPage;

        public string TxtHautPage { get => txtHautPage; set { txtHautPage = value; OnPropertyChanged("TxtHautPage");  } }

        //notification de l'evenement Property Changed

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }


        public MainWindow()
        {
            InitializeComponent();
           


            /*  ViewModel.MainViewModel mainViewModel = new ViewModel.MainViewModel();
              this.DataContext = mainViewModel;*/
            this.DataContext = this;


            // changer le titre de la page xaml
            this.Title = " Gestion des Stagiaire ";
            TxtHautPage = " Gestion des Stagiaires";
            // gestion des boutons
            btModif.IsEnabled = false;
            btNouveau.IsEnabled = false;
            btSupprimer.IsEnabled = false;




            //instanciation des Commandes
            btQuitterClick = new ViewModel.CommandMainViewModel(ActionQuitter);
        }

        //Mise en place des commandes
        public ICommand btQuitterClick { get; set; }

        private void ActionQuitter(object parametre)
        {
            // juste un message 
            //  MessageBox.Show("Etes vous sur de vouloir quitter l'application : ?");
            // /Message avec réponse avec yes / non + icon Warning + preselection Non
            MessageBoxResult selection = MessageBox.Show("Etes vous sur de vouloir quitter l'application : ?", "repondre", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

            switch (selection)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Vous allez quitter l'application");
                    Application.Current.Shutdown();
                    break;

                case MessageBoxResult.No:
                    MessageBox.Show("Vous ne quittez l'application");
                    break;
            }

        }

        private void GoToPage_CanExecute(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        //Navigation vers les autres pages
        private void GoToPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {

            string nomCmd;
            // dans cet exercice nous avons deux boutons associés à une même commande de navigation NavigationCommands.GoToPage
            // lorsque la méthode GoToPage_Executed est appelée il faut tester quel est le bouton qui a déclencher l'appel de la commande
            // on teste donc les paramètres ExecutedRoutedEventArgs et plus particulièrement le champ Source afin d'en extraire le nom
            // de l'objet qui a appelé la commande, on réalise un cast avec un FrameworkElement de manière à s'affranchir du type du sender
            // la conversion choisira automatiquement le bon type

            nomCmd = ((FrameworkElement)e.Source).Name;

            if (nomCmd == "goNvStagiaire")
            {
                EnregistreNvStagiaire01 enregistreNvStagiaire01 = new EnregistreNvStagiaire01();
                //  EnregistreNvStagiaire02 enregistreNvStagiaire = new EnregistreNvStagiaire02();     
                enregistreNvStagiaire01.ShowDialog();
               // enregistreNvStagiair.ShowDialog();
            }

            if (nomCmd == "goModifSupprimStagiaire")
            {
                ModifSupprimStagiaire modifSupprimStagiaire = new ModifSupprimStagiaire();
                modifSupprimStagiaire.ShowDialog();
            }
            
            if (nomCmd == "goNvEntreprise")
            {
                EnregistreNvEntreprise enregistreNvEntreprise = new EnregistreNvEntreprise();
                enregistreNvEntreprise.ShowDialog();
            }
                       
            if (nomCmd == "goModifSupprimEntreprise")
            {
                ModifSupprimEntreprise modifSupprimEntreprise = new ModifSupprimEntreprise();
                modifSupprimEntreprise.ShowDialog();
            }
                                          
            if (nomCmd == "goGestionStage")
            {
                Stages stages = new Stages();
                stages.ShowDialog();                               
            }
                                   
            if (nomCmd == "goNvQualif")
            {
                EnregistreNvQualif enregistreNvQualif = new EnregistreNvQualif();
                enregistreNvQualif.ShowDialog();                
            }
                                 
            if (nomCmd == "goModifSupprimQualif")
            {
                ModifSupprimQualif modifSupprimQualif = new ModifSupprimQualif();
                modifSupprimQualif.ShowDialog();
            }
                       
            if (nomCmd == "goNvPole")
            {
                EnregistreNvPole enregistreNvPole = new EnregistreNvPole();
                enregistreNvPole.ShowDialog();                
            }
            
            if (nomCmd == "goModifSupprimPole")
            {
                ModifSupprimPole modifSupprimPole = new ModifSupprimPole(); 
                modifSupprimPole.ShowDialog();
            }
                       
            if (nomCmd == "goNvFormation")
            {
                EnregistreNvFormation enregistreNvFormation = new EnregistreNvFormation();
                enregistreNvFormation.ShowDialog();
            }
            
            if (nomCmd == "goModifSupprimFormation")
            {
                ModifSupprimFormation modifSupprimFormation = new ModifSupprimFormation();
                modifSupprimFormation.ShowDialog();
            }
                       
            if (nomCmd == "goCalendrierStage")
            {
                CalendrierStage calendrierStage = new CalendrierStage();
                calendrierStage.ShowDialog();
            }


            




















        }


    }
}
