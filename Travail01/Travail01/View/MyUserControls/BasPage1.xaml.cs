using System;
using System.Collections.Generic;
using System.ComponentModel; // pour le chemin du INotifyPropertyChanged et du public event etc...
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

namespace Travail01.View.MyUserControls
{
    /// <summary>
    /// Logique d'interaction pour BasPage1.xaml
    /// </summary>
    public partial class BasPage1 : UserControl, INotifyPropertyChanged // System.ComponentModel.INotifyPropertyChanged .. si on met pas le  un using System.ComponentModel
    {
        //  public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged; // a mettre pour le Binding avec ... INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged; // a mettre pour le Binding avec ... INotifyPropertyChanged

        private string infoConnexion;

        public string Infoconnexion { get { return infoConnexion; } set { infoConnexion = value; OnPropertyChanged("InfoConnexion"); } }

        public BasPage1()
        {
            InitializeComponent();
        }

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            
        }


        


        private void BtQuit_Click(object sender, RoutedEventArgs e)
        {
            int tata = 0;
            tata = 1;
            Model.Cde_Bt_BasPage cde_Bt_BasPage = new Model.Cde_Bt_BasPage();
            cde_Bt_BasPage.BtQuit = true;

            MessageBox.Show(" OU  LALA   !!! Quitter Etes vous sur de vouloir quitter l'application : ?");
            

        }



        private void BtModif_Click(object sender, RoutedEventArgs e)
        {
            Model.Cde_Bt_BasPage cde_Bt_BasPage = new Model.Cde_Bt_BasPage();
            cde_Bt_BasPage.BtModif = true;

            MessageBox.Show(" OU  LALA   !!! Modif Etes vous sur de vouloir quitter l'application : ?");
         
            
        }

        private void BtNouveau_Click(object sender, RoutedEventArgs e)
        {
            Model.Cde_Bt_BasPage cde_Bt_BasPage = new Model.Cde_Bt_BasPage();
            cde_Bt_BasPage.BtNouveau = true;

            MessageBox.Show(" OU  LALA   !!! Nouveau tes vous sur de vouloir quitter l'application : ?");
        }

        private void BtSupprime_Click(object sender, RoutedEventArgs e)
        {
            Model.Cde_Bt_BasPage cde_Bt_BasPage = new Model.Cde_Bt_BasPage();
            cde_Bt_BasPage.BtSupprimer = true;

            MessageBox.Show(" OU  LALA   !!!    Supprimer  vous sur de vouloir quitter l'application : ?");
        }







    }
}
