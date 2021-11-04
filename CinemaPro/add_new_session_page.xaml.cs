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
    /// Interaction logic for add_new_session_page.xaml
    /// </summary>
    public partial class add_new_session_page : Page
    {
        public static ObservableCollection<Session> session_films { get; set; }
        public static Session newSession { get; set; }
        public add_new_session_page()
        {
            InitializeComponent();
            session_films = new ObservableCollection<Session>(cinema_pro_database_conection.connection.Session.ToList());
            newSession = new Session();
        }

        private void add_new_session_click(object sender, RoutedEventArgs e)
        {
            //Добавление нового сеанса ... какая-то приведения
            newSession.DateTime = DateTime.Parse(dateTimeText.Text);
            newSession.Film_ID = Convert.ToInt32(filmIDText.Text);
            newSession.Hall_ID = Convert.ToInt32(hallIDText.Text);
            cinema_pro_database_conection.connection.Session.Add(newSession);
            cinema_pro_database_conection.connection.SaveChanges();
            this.DataContext = this;
        }

        private void return_click(object sender, RoutedEventArgs e)
        {
            //Переход в предыдущую страницу
            NavigationService.Navigate(new session_edit());
        }
    }
}
