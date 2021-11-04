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
                //Проверка на корректность логина и пароля
                var entry = users.Where(a => a.login == text_login.Text && a.password == text_password.Password && a.access_level == access_level.SelectedItem.ToString()).FirstOrDefault();
                switch (access_level.SelectedItem)
                {
                    //Если User
                    case "User":
                        if (entry != null)
                        {
                            //Приветствие Пользователя
                            MessageBox.Show($"Welcome {entry.name} ({entry.access_level})");
                            //Инициализация окон
                            UserWindow userWindow = new UserWindow();
                            MainWindow mainWindow = new MainWindow();
                            userWindow.Show();
                            mainWindow.Hide();

                        }
                        else
                        {
                            //Ошибка - "Не корректные логин или пароль"
                            MessageBox.Show("Login or password incorrect", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        break;
                    //Если Manager
                    case "Manager":
                        if (entry != null)
                        {
                            //Приветствие Менеджера
                            MessageBox.Show($"Welcome {entry.name} ({entry.access_level})");
                            //Инициализация окон
                            ManagerWindow managerWindow = new ManagerWindow();
                            MainWindow mainWindow = new MainWindow();
                            managerWindow.Show();
                            mainWindow.Hide();
                        }
                        else
                        {
                            //Ошибка - "Не корректные логин или пароль"
                            MessageBox.Show("Login or password incorrect", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        break;
                    //Если Admin
                    case "Admin":
                        if (entry != null)
                        {
                            //Админа можно не приветствовать
                            //Переход в пространство админа
                            NavigationService.Navigate(new admin_space());
                        }
                        else
                        {
                            //Ошибка - "Не корректные логин или пароль"
                            MessageBox.Show("Login or password incorrect", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        break;
                    default:
                        //Ошибка - "Не выбрано"
                        MessageBox.Show($"Не выбрано");
                        break;
                }
            }
            catch
            {
                //Ошибка - "Не выбрано"
                MessageBox.Show($"Не выбрано");
            }
        }
    }
}
