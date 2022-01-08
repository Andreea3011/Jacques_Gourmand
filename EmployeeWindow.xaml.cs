using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Binding = System.Windows.Data.Binding;
using MessageBox = System.Windows.MessageBox;
using TextBox = System.Windows.Controls.TextBox;

namespace Jacques_Gourmand
{
    /// <summary>
    /// Interaction logic for EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {

        public EmployeeWindow()
        {
            InitializeComponent();

        }
        int[] array = new int[9];
        int total;


        RestaurantEntitiesModel dbcontext = new RestaurantEntitiesModel();
        CollectionViewSource meniuVSource;
        CollectionViewSource comenziVSource;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            meniuVSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("meniuViewSource")));
            meniuVSource.Source = dbcontext.Meniu.Local;
            dbcontext.Meniu.Load();
            comenziVSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("comenziViewSource")));
            comenziVSource.Source = dbcontext.Comenzi.Local;
            dbcontext.Comenzi.Load();
            System.Windows.Data.CollectionViewSource meniuViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("meniuViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // meniuViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource angajatiViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("angajatiViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // angajatiViewSource.Source = [generic data source]

            System.Windows.Data.CollectionViewSource comenziViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("comenziViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // comenziViewSource.Source = [generic data source]



        }



        private void paste_click(object sender, RoutedEventArgs e)
        {

            if (int.Parse(bucatipaste1.Text) == 0)
            {
                MessageBox.Show("Introduceti valoare");
            }
            else gridbon1.Items.Add(new { produse = "Paste", cantitate = bucatipaste1.Text, pret = pretpaste1.Text });
            total = Convert.ToInt32(this.bucatipaste1.Text) * Convert.ToInt32(this.pretpaste1.Text);
            array[0] = array[0]+ total;
            
        }

        private void pizza_click(object sender, RoutedEventArgs e)
        {

            if (int.Parse(bucatipizza1.Text) == 0)
            {
                MessageBox.Show("Introduceti valoare");
            }
            else gridbon1.Items.Add(new { produse = "Pizza", cantitate = bucatipizza1.Text, pret = pretpizza1.Text });
            total = Convert.ToInt32(this.bucatipizza1.Text) * Convert.ToInt32(this.pretpizza1.Text);
            array[1] = array[1]+ total;
           
        }

        private void pulpe1_click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(bucatipulpe1.Text) == 0)
            {
                MessageBox.Show("Introduceti valoare");
            }
            else gridbon1.Items.Add(new { produse = "Cartofi piure cu pulpe de puii", cantitate = bucatipulpe1.Text, pret = pretpulpe1.Text });
            total = Convert.ToInt32(this.bucatipulpe1.Text) * Convert.ToInt32(this.pretpulpe1.Text);
            array[3] = array[3]+total;
            
        }

        private void snite1_click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(bucatisnitel1.Text) == 0)
            {
                MessageBox.Show("Introduceti valoare");
            }
            else gridbon1.Items.Add(new { produse = "Snitel cu cartofi pai", cantitate = bucatisnitel1.Text, pret = pretsnitel1.Text });
            total = Convert.ToInt32(this.bucatisnitel1.Text) * Convert.ToInt32(this.pretsnitel1.Text);
            array[2] = array[2]+total;
           
        }

        private void cb1_click(object sender, RoutedEventArgs e)
        {

            if (int.Parse(bucaticb1.Text) == 0)
            {
                MessageBox.Show("Introduceti valoare");
            }
            else gridbon1.Items.Add(new { produse = "Ciorba de burta", cantitate = bucaticb1.Text, pret = pretcb1.Text });
            total = Convert.ToInt32(this.bucaticb1.Text) * Convert.ToInt32(this.pretcb1.Text);
            array[4] = array[4]+ total;
            


        }

        private void ct1_click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(bucatict1.Text) == 0)
            {
                MessageBox.Show("Introduceti valoare");
            }
            else gridbon1.Items.Add(new { produse = "Ciorba taraneasca", cantitate = bucatict1.Text, pret = pretct1.Text });
            total = Convert.ToInt32(this.bucatict1.Text) * Convert.ToInt32(this.pretct1.Text);
            array[5] = array[5] + total;
           

        }

        private void apa1_click(object sender, RoutedEventArgs e)

        {
            if (int.Parse(bucatiapa1.Text) == 0)
            {
                MessageBox.Show("Introduceti valoare");
            }
            else gridbon1.Items.Add(new { produse = "Apa", cantitate = bucatiapa1.Text, pret = pretapa1.Text });

            total = Convert.ToInt32(this.bucatiapa1.Text) * Convert.ToInt32(this.pretapa1.Text);
            array[6] = array[6]+total;

        }

        private void bere1_click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(bucatibere1.Text) == 0)
            {
                MessageBox.Show("Introduceti valoare");
            }
            else
                gridbon1.Items.Add(new
                {
                    produse = "Bere",
                    cantitate = bucatibere1.Text,
                    pret = pretbere1.Text
                });

            total = Convert.ToInt32(this.bucatibere1.Text) * Convert.ToInt32(this.pretbere1.Text);
            array[7] =array[7]+ total;
           

        }

        private void suc_click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(bucatisuc.Text) == 0)
            {
                MessageBox.Show("Introduceti valoare");
            }
            else
                gridbon1.Items.Add(new
                {
                    produse = "Suc",
                    cantitate = bucatisuc.Text,
                    pret = pretsuc.Text
                });
            total = Convert.ToInt32(this.bucatisuc.Text) * Convert.ToInt32(this.pretsuc.Text);
            array[8] = array[8] + total;
            
        }
       

        private void tipareste_bon_click(object sender, RoutedEventArgs e)
        {
            total = 0;
            for (int i = 0; i < 9; i++)
                total = array[i] + total;
            MessageBox.Show("Totalul este: "+total.ToString());
        }

        private void logout_click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Hide();
            mainWindow.Show();
        }
    } 
}
