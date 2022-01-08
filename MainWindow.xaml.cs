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
using RestaurantModel;

namespace Jacques_Gourmand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    enum ActionState
    {
        admin,
        vanzator,
        Nothing
    }
    public partial class MainWindow : Window
    {
        ActionState action = ActionState.Nothing;
        public MainWindow()
        {
            InitializeComponent();
        }
        RestaurantEntitiesModel dbcontext = new RestaurantEntitiesModel();
        private void login_click(object sender, RoutedEventArgs e)
        {
            try

            {
                if (action == ActionState.admin)
                {
                    if (dbcontext.Admini.Where(r => r.UserAdmin == txtUsername.Text && r.ParolaAdmin == txtPassword.Text).Count() > 0)
                    {
                        AdminWindow adminWindow = new AdminWindow();
                        this.Hide();
                        adminWindow.Show();

                    }
                    else
                    {
                        MessageBox.Show("Introduceti datele corecte pentru admin!");
                    }
                }
               

                if(action == ActionState.vanzator)
                {
                    if(dbcontext.Angajati.Where(r => r.User == txtUsername.Text && r.Parola == txtPassword.Text).Count() > 0)
                    {
                        EmployeeWindow employeeWindow = new EmployeeWindow();
                        this.Hide();
                        employeeWindow.Show();
                    }
                    else
                    {
                        MessageBox.Show("Introduceti datele corecte pentru angajat!");
                      }
                }
               
            }
            catch
            {
                MessageBox.Show("Alege rolul");
            }
        }


        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            action = ActionState.admin;
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            action = ActionState.vanzator;
        }
    }
}