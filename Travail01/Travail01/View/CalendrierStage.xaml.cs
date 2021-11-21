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
    /// <summary>
    /// Logique d'interaction pour CalendrierStage.xaml
    /// </summary>
    public partial class CalendrierStage : Window, INotifyPropertyChanged    
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


        public CalendrierStage()
        {
            InitializeComponent();



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
