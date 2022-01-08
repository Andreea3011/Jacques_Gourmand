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
using System.Windows.Shapes;
using RestaurantModel;
using System.Data.Entity;


namespace Jacques_Gourmand
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        RestaurantEntitiesModel dbcontext = new RestaurantEntitiesModel();
        CollectionViewSource produseVSource;
        CollectionViewSource angajatiVSource;
        Produse produse = new Produse();
        Angajati angajati = new Angajati();

        private void add_click(object sender, RoutedEventArgs e)
        {
           

            Produse produse = new Produse()
            {
                ProdId = int.Parse(id.Text.Trim()),
                ProdNume = nume.Text.Trim(),
        
               ProdCantitate = int.Parse(cantitate.Text.Trim()),
                ProdCateg = categorie.Text.Trim(),
                ProdPret = int.Parse(pret.Text.Trim())
            };


          

            dbcontext.Produse.Add(produse);
            produseVSource.View.Refresh();
            dbcontext.SaveChanges();
            MessageBox.Show("s-a introdus");

        }

       

        private void edit_click(object sender, RoutedEventArgs e)
        {

            produse = (Produse)produseDataGrid.SelectedItem;
            produse.ProdNume = nume.Text.Trim();
            produse.ProdCateg = categorie.Text.Trim();
            produse.ProdPret = int.Parse(pret.Text);
            produse.ProdCantitate = int.Parse(cantitate.Text);



            dbcontext.SaveChanges();
            produseVSource.View.Refresh();
            MessageBox.Show("s-a modificat");

        }


        private void delete_click(object sender, RoutedEventArgs e)
        {
            produse = (Produse)produseDataGrid.SelectedItem;
            dbcontext.Produse.Remove(produse);
            dbcontext.SaveChanges();
            MessageBox.Show("s-a sters");

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            produseVSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("produseViewSource")));
            produseVSource.Source = dbcontext.Produse.Local;
            dbcontext.Produse.Load();
            angajatiVSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("angajatiViewSource")));
            angajatiVSource.Source = dbcontext.Angajati.Local;
            dbcontext.Angajati.Load();


            //System.Windows.Data.CollectionViewSource angajatiViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("angajatiViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // angajatiViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource meniuViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("meniuViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // meniuViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource comenziViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("comenziViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // comenziViewSource.Source = [generic data source]
        }

        private void addangajati_click(object sender, RoutedEventArgs e)
        {

            Angajati angajati = new Angajati()
            {
                AngajatId = int.Parse(idangajat.Text.Trim()),
                Functie = functie.Text.Trim(),
                Norma = norma.Text.Trim(),
                NrTelefon = nrtelefon.Text.Trim(),
                Nume = nume.Text.Trim(),
                OreSupl = int.Parse(oresupl.Text.Trim()),
                Parola = parolaangajat.Text.Trim(),
                Prenume = prenumeangajat.Text.Trim(),
                Salariu = int.Parse(salariu.Text.Trim()),
                User = user.Text.Trim()
            };



            dbcontext.Angajati.Add(angajati);
            angajatiVSource.View.Refresh();
            dbcontext.SaveChanges();
            MessageBox.Show("s-a introdus");
           
        }


        private void editangajati_click(object sender, RoutedEventArgs e)
        {
            angajati = (Angajati)angajatiDataGrid.SelectedItem;
            angajati.Functie = functie.Text.Trim();
            angajati.Norma = norma.Text.Trim();
            angajati.NrTelefon = nrtelefon.Text.Trim();
            angajati.Nume = numeangajat.Text.Trim();
            angajati.OreSupl = int.Parse(oresupl.Text);
            angajati.Parola = parolaangajat.Text.Trim();
            angajati.Prenume = prenumeangajat.Text.Trim();
            angajati.User = user.Text.Trim();
            angajati.Salariu = int.Parse(salariu.Text);


            dbcontext.SaveChanges();
            MessageBox.Show("s-a modificat");

        }

        private void deleteangajati_click(object sender, RoutedEventArgs e)
        {
            angajati = (Angajati)angajatiDataGrid.SelectedItem;
            dbcontext.Angajati.Remove(angajati);
            dbcontext.SaveChanges();
            MessageBox.Show("s-a sters");
        }

        private void logout_click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Hide();
            mainWindow.Show();
        }

        private void SetValidationBinding()
        {
            Binding categorieBinding = new Binding();
            categorieBinding.Source = produseVSource;
            categorieBinding.Path = new PropertyPath("ProdCateg");
            categorieBinding.NotifyOnValidationError = true;
            categorieBinding.Mode = BindingMode.TwoWay;
            categorieBinding.UpdateSourceTrigger =
           UpdateSourceTrigger.PropertyChanged;
            categorieBinding.ValidationRules.Add(new StringNotEmpty());
            categorie.SetBinding(TextBox.TextProperty,categorieBinding);
        }

          private void next_click(object sender, RoutedEventArgs e)
            {
               produseVSource.View.MoveCurrentToNext();

          }
           private void next2_click(object sender, RoutedEventArgs e)
            {
                angajatiVSource.View.MoveCurrentToNext();

           }
    }
}