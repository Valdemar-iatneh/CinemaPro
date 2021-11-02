using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace CinemaPro
{
    /// <summary>
    /// Interaction logic for page_authorization.xaml
    /// </summary>
    public partial class page_authorization : Page
    {
        public static ObservableCollection<login_data> users { get; set; }
       
        public page_authorization()
        {
            InitializeComponent();
               
        }

        private void authoriz_click_event(object sender, RoutedEventArgs e)
        {
            users = new ObservableCollection<login_data>(login_database_conection.connection.login_data.ToList());
            try
            {
                var entry = users.Where(a => a.login == text_login.Text && a.password == text_password.Password && a.access_level == access_level.SelectedItem.ToString()).FirstOrDefault();
                switch (access_level.SelectedItem)
                {
                    case "User":
                        if (entry != null)
                        {
                            MessageBox.Show($"{entry.name} {entry.access_level}");
                            UserWindow userWindow = new UserWindow();
                            MainWindow mainWindow = new MainWindow();
                            mainWindow.Close();
                            userWindow.Show();
                            
                        }
                        else
                        {
                            MessageBox.Show("Login or password incorrect", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        break;
                    case "Manager":
                        if (entry != null)
                        {
                            MessageBox.Show($"{entry.name} {entry.access_level}");
                        }
                        else
                        {
                            MessageBox.Show("Login or password incorrect", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        break;
                    case "Admin":
                        if (entry != null)
                        {
                            NavigationService.Navigate(new admin_space());
                        }
                        else
                        {
                            MessageBox.Show("Login or password incorrect", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        break;
                    default:
                        MessageBox.Show($"Не выбрано");
                        break;
                }
            }
            catch
            {
                MessageBox.Show($"Не выбрано");
            }
        }
    }
}
