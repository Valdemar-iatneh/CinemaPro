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
    /// Interaction logic for session_edit.xaml
    /// </summary>
    public partial class session_edit : Page
    {
        public static ObservableCollection<Session> session_films { get; set; }
        public static ObservableCollection<Ticket> ticket { get; set; }
        public session_edit()
        {
            InitializeComponent();
            session_films = new ObservableCollection<Session>(cinema_pro_database_conection.connection.Session.ToList());
            ticket = new ObservableCollection<Ticket>(cinema_pro_database_conection.connection.Ticket.ToList());
            this.DataContext = this;
        }

        private void selected_session(object sender, SelectionChangedEventArgs e)
        {
            var info = (sender as ListView).SelectedItem as Session;
            //Удаление
            if (MessageBox.Show($"Удалить сеанс на {info.DateTime}", "Удалить?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //Удаление
                cinema_pro_database_conection.connection.Session.Remove(info);
                cinema_pro_database_conection.connection.SaveChanges();
                //Обновление listView 
                list_of_films.Items.Refresh();
            }
        }

        private void add_new_session_click(object sender, RoutedEventArgs e)
        {
            //переход к созданию нового элемента
            NavigationService.Navigate(new add_new_session_page());
        }
    }
}
