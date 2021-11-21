using System;
using System.Collections.Generic;
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
    /// <summary>
    /// Logique d'interaction pour EnregistreNvStagiaire02Page.xaml
    /// </summary>
    public partial class EnregistreNvStagiaire02Page : Page
    {
        public EnregistreNvStagiaire02Page()
        {
            InitializeComponent();

            // je fais le lien entre la view et le viewModel de EnregistreNvStagiaire02Page
            ViewModel.EnregisteNvStgVMP enregisteNvStgVMP = new ViewModel.EnregisteNvStgVMP();
            this.DataContext = enregisteNvStgVMP;
                
             

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
