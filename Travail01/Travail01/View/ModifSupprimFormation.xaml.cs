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
    
    public partial class ModifSupprimFormation : Window, INotifyPropertyChanged
    {

        //attribut
        string txtHautPage;

        // Pour la date du jour pour le stage
        string dateduJourDeb; // la date du jour pour le DatePicker debut de stage
        string dateduJourFin; // la date du jour pour le DatePicker fin de stage

        public string TxtHautPage { get => txtHautPage; set { txtHautPage = value; OnPropertyChanged("TxtHautPage"); } }

        // getter setter pour les dates du stage 
        public string DateduJourDeb { get => dateduJourDeb; set { dateduJourDeb = value; OnPropertyChanged("DateduJourDeb"); } }
        public string DateduJourFin { get => dateduJourFin; set { dateduJourFin = value; OnPropertyChanged("DateduJourFin"); } }

        //notification de l'evenement Property Changed

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(v));
            }

        }


        //Pour la liste formation
    //    DTO_Formation laForma;// using Travail01.Model  ->  sinon mettre le chemin entier => Model.DTO_Formation etc...
        BLL_Formation formaBDD;
        List<string> resultForma = new List<string>();

        // Pour la Liste Pole de Formation
    //    DTO_Pole lePole;
        BLL_Pole poleBDD;
        List<string> resultPole = new List<string>();
        // Je crée une liste des Poles
        List<string> lesPoles = new List<string>();
        
        // Pour la Liste Qualification
  //      DTO_Qualif laQualif;
        BLL_Qualification qualifBDD;
        List<string> resultQualif = new List<string>();
        // Je crée une liste des qualification
        List<string> lesQualif = new List<string>();


        // Le Constructeur
        public ModifSupprimFormation()
        {
            formaBDD = new BLL_Formation();
            poleBDD = new BLL_Pole();
            qualifBDD = new BLL_Qualification();

            InitializeComponent();

            //position de la fenetre dans l'espace "écran"
            WindowStartupLocation = WindowStartupLocation.CenterScreen; // au Milieur de l'écran

            // changer le titre de la page xaml
            this.Title = " Gestion des Stagiaire ";
            TxtHautPage = " Modifier ou Supprimer une Formation ";

            // gestion des boutons
            btModif.IsEnabled = false;
            btAjouter.IsEnabled = false;
            btSupprimer.IsEnabled = false;

            // On inhibe les comboBox On peut que lire pas ecrire
            comboBoxPole.IsEnabled = false;
            comboBoxQualif.IsEnabled = false;

            // On inhibe les textbox tant que les combobox sont pas utilisés
            txtBoxNumForma.IsEnabled = false;
            txtBoxIntituleForma.IsEnabled = false;
            txtBoxnbHeureForma.IsEnabled = false;
            txtBoxnbHeureCours.IsEnabled = false;
            txtBoxnbHeureStg.IsEnabled = false;
            //   txtBoxdtDebForma.IsEnabled = false; // devenu un TimePicker
            //   txtBoxdtFinForma.IsEnabled = false; // devenu un TimePicker
            txtBoxnbStage.IsEnabled = false;
            txtBoxPeriodestg.IsEnabled = false;
                    
            this.DataContext = this;


            //replissage de la comboBox Formation par les intitulé de Formation
            resultForma = formaBDD.ListeForma();// resultate = fonction Listeforma() de type "List<string>" de la classe  BLL_Formation
            foreach (string forma in resultForma)// a chaque iteration je prends un element de ma liste et le mets dans la variable forma
            {
                string[] tabString = forma.Split('/'); // Divise une chaîne en sous-chaînes en fonction de caractères de délimitation spécifiés ici '/' et le mets dans un tableau             
                comboBoxForma.Items.Add(tabString[1]); //Dans comboBoxforma j'ajoute un item
            }

            //replissage de la comboBox Pole
            resultPole = poleBDD.ListePole();// resultate = fonction ListePole() de type "List<string>" de la classe  BLL_Pole
            foreach (string pole in resultPole)// a chaque iteration je prends un element de ma liste et le mets dans la variable pole
            {
                string[] tabString = pole.Split('/'); // Divise une chaîne en sous-chaînes en fonction de caractères de délimitation spécifiés ici '/' et le mets dans un tableau             
                comboBoxPole.Items.Add(tabString[1]); //Dans comboBoxPole j'ajoute un item

                // je recupere la liste des numero de poles
                lesPoles.Add(tabString[1]);

            }

            //replissage de la comboBox Qualification
            resultQualif = qualifBDD.ListeQualif();// resultate = fonction ListeQualif() de type "List<string>" de la classe  BLL_Qualification()
            foreach (string qualif in resultQualif)// a chaque iteration je prends un element de ma liste et le mets dans la variable pole
            {
                string[] tabString = qualif.Split('/'); // Divise une chaîne en sous-chaînes en fonction de caractères de délimitation spécifiés ici '/' et le mets dans un tableau             
                comboBoxQualif.Items.Add(tabString[1]); //Dans comboBoxQualif j'ajoute un item

                // je recupere la liste des numero des qualifications
                lesQualif.Add(tabString[1]);
            }
        }



        /*  ------  Gestion du Go Back--------    */
        private void PreviousPage_CanExecute(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private void PreviousPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }
        /* ---------- FIN de la Gestion du Go Back ------------   */


        /*  Quand je selectionne une formation dans le combo Formation : je mets à jour toutes les données  " TextBox, Combo, TimePicker " qui vant ensuite être affichées     */
        private void ComboBoxForma_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = comboBoxForma.SelectedIndex;

            /*---- declaration des variable pour la mise en forme des date dans du DtaPicker vers la base de données -----*/
            string formatted = string.Empty; // bien que vide il faut lui préciser que la chaine est vide sinon il pense que c'est indéterminé!!!
            string formattedFin = string.Empty; // idem


            // instancie la classe " DTO"
            DTO_Formation SelectFormaDTO = new DTO_Formation();
            // de la liste "formation via Combo" persité vers les Setters pour les passé en parametre vers la fonction "AfficherInfosFormation(SelectFormaDTO)"
            SelectFormaDTO.NumForma = resultForma[index].Split('/')[1];
            SelectFormaDTO.IntituleFormation = resultForma[index].Split('/')[2];
            SelectFormaDTO.NbHeureForma = Convert.ToInt16(resultForma[index].Split('/')[3]); // c'est du text "string " et il attend du " int"
            SelectFormaDTO.NbHeureCours = Convert.ToInt16(resultForma[index].Split('/')[4]); // idem
            SelectFormaDTO.NbHeureStg = Convert.ToInt16(resultForma[index].Split('/')[5]);   // idem

        
            /*--------------------------------  -----------------------------*/

            /*  ----  ATTENTION au format pour les dates --- */
            /*   ---- Mise en forme des date avec le dateTime du DatePicker  ----- */

            // mettre le DatePiker à la bonne date " DateTime( année,mois,jour,heur,mn,sec ) =>( 2021, 10, 25, 7, 47, 0)

            //pour la date debut formation = resultforma[index].Split('/')[8]; jour->[8],  Mois->[9], Année->[10]                       

            // ce que je reçois de la base
            string interYearDeb = resultForma[index].Split('/')[8].Substring(0, 4); //  Substring(0, 4) => je prends le champ année et on retient que les 4 1ere caractere en partant de 0

            int anneeDebut = Convert.ToInt32(interYearDeb);
            int moisDebut = Convert.ToInt32(resultForma[index].Split('/')[7]);
            int jourDeb = Convert.ToInt32(resultForma[index].Split('/')[6]);

            DateTime laDateDeb = new DateTime(anneeDebut, moisDebut, jourDeb);//

            DateduJourDeb = laDateDeb.ToShortDateString(); // fin de la mise en forme 

            SelectFormaDTO.DtDebForma = DateduJourDeb; // mise dans le DTO de Formation

            /*----------------*/

            //pour la date Fin formation = resultForma[index].Split('/')[11]; jour->[11],  Mois->[12], Année->[13]

            // ce que je reçois de la base 
            string interYearFin = resultForma[index].Split('/')[11].Substring(0, 4); //  Substring(0, 4) => je prends le champ année et on retient que les 4 1ere caractere en partant de 0

            int anneeFin = Convert.ToInt32(interYearFin);
            int moisFin = Convert.ToInt32(resultForma[index].Split('/')[10]);
            int jourFin = Convert.ToInt32(resultForma[index].Split('/')[9]);

            DateTime laDateFin = new DateTime(anneeFin, moisFin, jourFin);//

            DateduJourFin = laDateFin.ToShortDateString();


            SelectFormaDTO.DtFinForma = DateduJourFin;
                                              
            /*  ------------  FIN : la mise en forme des date avec les " DatPiker "  --------------------------*/


            SelectFormaDTO.NombreStage = Convert.ToInt16(resultForma[index].Split('/')[12]); // idem: string -> int
            SelectFormaDTO.NbPeriode = Convert.ToInt16(resultForma[index].Split('/')[13]);   // idem 

            // le clées etrangeres 
            SelectFormaDTO.IdPole = Convert.ToInt16(resultForma[index].Split('/')[14]);
            SelectFormaDTO.IdQualification = Convert.ToInt16(resultForma[index].Split('/')[15]);

            AfficherInfosFormation(SelectFormaDTO);                        
        }


        private void AfficherInfosFormation(DTO_Formation formation)
        {
            // on active les textbox
            txtBoxNumForma.IsEnabled = true;
            txtBoxIntituleForma.IsEnabled = true;
            txtBoxnbHeureForma.IsEnabled = true;
            txtBoxnbHeureCours.IsEnabled = true;
            txtBoxnbHeureStg.IsEnabled = true;
            txtBoxdtDebForma.IsEnabled = true;
            //   txtBoxdtFinForma.IsEnabled = true;
            txtBoxnbStage.IsEnabled = true;
            txtBoxPeriodestg.IsEnabled = true;

            // on active les boutons
            btModif.IsEnabled = true;
            btSupprimer.IsEnabled = true;

            txtBoxNumForma.Text = formation.NumForma;
            txtBoxIntituleForma.Text = formation.IntituleFormation;
            txtBoxnbHeureForma.Text = (formation.NbHeureForma).ToString(); // parser en string car string attendu
            txtBoxnbHeureCours.Text = (formation.NbHeureCours).ToString(); // idem
            txtBoxnbHeureStg.Text = (formation.NbHeureStg).ToString();     // idem
            txtBoxdtDebForma.Text = formation.DtDebForma;
            //    txtBoxdtFinForma.Text = formation.DtFinForma;
            txtBoxnbStage.Text = (formation.NombreStage).ToString();      // idem: int -> string
            txtBoxPeriodestg.Text = (formation.NbPeriode).ToString();     //

            // Je remplis le combobox Pole 
            comboBoxPole.Text = lesPoles[formation.IdPole - 1];// je mets -1 car le idPole commence à 0 et non à 1

            // Je remplis le combobox qualification
            comboBoxQualif.Text = lesQualif[formation.IdQualification - 1];// Je mets -1 car le idqualif commence à 0 et non 1                        
        }

        // Procedure Modifier une Formation
        private void BtModif_Click(object sender, RoutedEventArgs e)
        {
            // le 3 index des combox
            int indexPole = comboBoxPole.SelectedIndex;
            int indexQualif = comboBoxQualif.SelectedIndex;
            int indexForma = comboBoxForma.SelectedIndex;

            // modif c'est comme ajouter pout le datapacker
            /*       debut DateTime   */

            string formatted = string.Empty;// bien que vide il faut lui précisé que la chaine est vide sinon il pense que c'est indeterminé!!!
            string formattedFin = string.Empty; // idem
            
            // selection la date debut
            DateTime? selectedDate = dpDebForma.SelectedDate;// DateTime? avec ? on peut avoir un null: resultat= 14/01/2021 00:00:00
                                                             //    DateTime? dateDebut = dpDebForma.SelectedDate; 

            DateTime? selectedDateFin = dpFinForma.SelectedDate;

            //     DateduJour = dateMachine.ToShortDateString();// retourne que la date : 02/11/2021

            if (selectedDate.HasValue) // si il y a une valeur => true
            {
                formatted = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);//la valeur est mise au forma string : mmois/Jour/Année
                MessageBox.Show(formatted, "c'est la date debut selectionné!! ");
            }

            if (selectedDate.HasValue)
            {
                formattedFin = selectedDateFin.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);//la valeur est mise au forma string : mmois/Jour/Année
                MessageBox.Show(formattedFin, "c'est la date fin selectionné!! ");

            }
                                    
            string[] formaDate = formatted.Split('.'); // car le separateur entre :" jour . mois . année " est un point
            string dateformaBase = formaDate[2] + "-" + formaDate[1] + "-" + formaDate[0];  // la date de debut stage au forma pour la base
                                                                                            // plus besoin car DataPicker est mis au format francais dans Xaml ... Donc formatted est au bon format pour le DataPicker
                                                                                            //  string datformaAffichage = formaDate[1] + "-" + formaDate[0] + "-" + formaDate[2]; // plus besoin

            string[] formaDateFin = formattedFin.Split('.');//car le separateur entre :" jour . mois . année " est un point
            string dateformaFinBase = formaDateFin[2] + "-" + formaDateFin[1] + "-" + formaDateFin[0];// mois-jour-année format pour la base
                        
            /*         fin DateTime*/


            // index ou je fais la modif

            int indexaModifier = Convert.ToInt16(resultForma[indexForma].Split('/')[0]);
            // int indexaModifier = Int16.Parse(resultForma[indexForma].Split('/')[0]);  //  autre methode!!

            // tjrs meme pb on ajoute 1 au index car en informatique le 1er commence à : 0
            DTO_Formation SelecltFormaDTO = new DTO_Formation(indexForma + 1, txtBoxNumForma.Text, txtBoxIntituleForma.Text,
                                                Convert.ToInt16(txtBoxnbHeureForma.Text),
                                                Convert.ToInt16(txtBoxnbHeureCours.Text),
                                                Convert.ToInt16(txtBoxnbHeureStg.Text),
                                                dateformaBase, dateformaFinBase,  //    txtBoxdtDebForma.Text, txtBoxdtFinForma.Text,                                               
                                                Convert.ToInt16(txtBoxnbStage.Text),
                                                Convert.ToInt16(txtBoxPeriodestg.Text), indexPole + 1, indexQualif + 1);

            //je recupere la valeur de la clé 1er :Fonction "recupPK(valeur de la clé)" => faite dans la classe BLL_Formation
            SelecltFormaDTO.IdForma = formaBDD.recupPK(resultForma[indexForma].Split('/')[1]);            

            if (formaBDD.ModifierForma(SelecltFormaDTO))
            {
                MessageBox.Show("la formation à été modifiée");
                Close();
            }
            else
            {
                MessageBox.Show(" Erreur de modification formation ");
            }
        }


        // Procedure supprimer une formation
        private void BtSupprimer_Click(object sender, RoutedEventArgs e)
        {
            // le 3 index des combox
            int indexPole = comboBoxPole.SelectedIndex;
            int indexQualif = comboBoxQualif.SelectedIndex;
            int indexForma = comboBoxForma.SelectedIndex;
            
            // modif c'est comme ajouter pout le datapacker
            /*       debut DateTime   */

            string formatted = string.Empty;// bien que vide il faut lui précisé que la chaine est vide sinon il pense que c'est indeterminé!!!
            string formattedFin = string.Empty; // idem
                        
            // selection la date debut
            DateTime? selectedDate = dpDebForma.SelectedDate;// DateTime? avec ? on peut avoir un null: resultat= 14/01/2021 00:00:00
                                                             //    DateTime? dateDebut = dpDebForma.SelectedDate; 

            DateTime? selectedDateFin = dpFinForma.SelectedDate;

            //     DateduJour = dateMachine.ToShortDateString();// retourne que la date : 02/11/2021

            if (selectedDate.HasValue) // si il y a une valeur => true
            {
                formatted = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);//la valeur est mise au forma string : mmois/Jour/Année
                MessageBox.Show(formatted, "c'est la date debut selectionné!! ");
            }

            if (selectedDate.HasValue)
            {
                formattedFin = selectedDateFin.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);//la valeur est mise au forma string : mmois/Jour/Année
                MessageBox.Show(formattedFin, "c'est la date fin selectionné!! ");
            }
            
            string[] formaDate = formatted.Split('.'); // car le separateur entre :" jour . mois . année " est un point
            string dateformaBase = formaDate[2] + "-" + formaDate[1] + "-" + formaDate[0];  // la date de debut stage au forma pour la base
                                                                                            // plus besoin car DataPicker est mis au format francais dans Xaml ... Donc formatted est au bon format pour le DataPicker
                                                                                            //  string datformaAffichage = formaDate[1] + "-" + formaDate[0] + "-" + formaDate[2]; // plus besoin

            string[] formaDateFin = formattedFin.Split('.');//car le separateur entre :" jour . mois . année " est un point
            string dateformaFinBase = formaDateFin[2] + "-" + formaDateFin[1] + "-" + formaDateFin[0];// mois-jour-année format pour la base
                        
            /* -------      fin DateTime   ------  */

            
            // de la liste "formation via Combo" persité vers la base de données
            // tjrs même pb on ajoute 1 au index car en informatique le 1er commence à : 0
            DTO_Formation SelecltFormaDTO = new DTO_Formation(indexForma + 1, txtBoxNumForma.Text, txtBoxIntituleForma.Text,
                                                Convert.ToInt16(txtBoxnbHeureForma.Text),
                                                Convert.ToInt16(txtBoxnbHeureCours.Text),
                                                Convert.ToInt16(txtBoxnbHeureStg.Text),                                                
                                                dateformaBase, dateformaFinBase,//  txtBoxdtDebForma.Text, txtBoxdtFinForma.Text,
                                                Convert.ToInt16(txtBoxnbStage.Text),
                                                Convert.ToInt16(txtBoxPeriodestg.Text), indexPole, indexQualif);

            //selection avec index du combo = valeur du numeroForma
            // SelecltFormaDTO.IdForma = Convert.ToInt16(resultForma[indexForma].Split('/')[0]);

            //je recupere la valeur de la clé 1er :Fonction "recupPK(valeur de la clé)" => faite dans la classe BLL_Formation
            SelecltFormaDTO.IdForma = formaBDD.recupPK(resultForma[indexForma].Split('/')[1]);
            SelecltFormaDTO.NumForma = resultForma[indexForma].Split('/')[1];
            SelecltFormaDTO.IntituleFormation = resultForma[indexForma].Split('/')[2];
            SelecltFormaDTO.NbHeureForma = Convert.ToInt16(resultForma[indexForma].Split('/')[3]);
            SelecltFormaDTO.NbHeureCours = Convert.ToInt16(resultForma[indexForma].Split('/')[4]);
            SelecltFormaDTO.NbHeureStg = Convert.ToInt16(resultForma[indexForma].Split('/')[5]);
            SelecltFormaDTO.DtDebForma = resultForma[indexForma].Split('/')[6];
            SelecltFormaDTO.DtFinForma = resultForma[indexForma].Split('/')[0];
            SelecltFormaDTO.NombreStage = Convert.ToInt16(resultForma[indexForma].Split('/')[0]);
            SelecltFormaDTO.NombreStage = Convert.ToInt16(resultForma[indexForma].Split('/')[0]);
            SelecltFormaDTO.IdPole = Convert.ToInt16(resultForma[indexForma].Split('/')[0]);
            SelecltFormaDTO.IdQualification = Convert.ToInt16(resultForma[indexForma].Split('/')[0]);
                        
            if (formaBDD.SupprimerForma(SelecltFormaDTO))
            {
                MessageBox.Show(" La Formation " + SelecltFormaDTO.NumForma + " à été supprimé ");
            }

            else
            {
                MessageBox.Show("Erreur de supression ");
            }
        }        
    }
}
