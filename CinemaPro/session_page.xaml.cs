using System;
using System.Collections;
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
    /// Interaction logic for session_page.xaml
    /// </summary>
    public partial class session_page : Page
    {
        public static ObservableCollection<Session> session { get; set; }
        public static ObservableCollection<Film> film { get; set; }
        public static FilmInSession selectedFilmInSession { get; set; }
        public static IEnumerable<FilmInSession> filmSessions { get; set; }

        public session_page()
        {
            InitializeComponent();

            session = new ObservableCollection<Session>(cinema_pro_database_conection.connection.Session.ToList());
            film = new ObservableCollection<Film>(cinema_pro_database_conection.connection.Film.ToList());
            //Соединение таблиц Session 
            filmSessions = session.Join(film,
                ses => ses.Film_ID,
                film => film.Film_ID,
                (ses, film) => new FilmInSession
                {
                    DateTime = ses.DateTime,
                    Hall_ID = (int)ses.Hall_ID,
                    Name = film.Name,
                    Year_of_issue = (int)film.Year_of_issue,
                    Duration = (int)film.Duration,
                    AgeCategory_ID = (int)film.AgeCategory_ID,
                    FilmCompany_ID = (int)film.FilmCompany_ID,
                    Country_ID = (int)film.Country_ID,
                    Image = film.Image
                });

            this.DataContext = this;
        }

        private void film_select_event(object sender, RoutedEventArgs e)
        {
            //Передача данных из выбранного элемента ListView
            selectedFilmInSession = list_of_films.SelectedItem as FilmInSession;
            //Переход на страницу с фильмом
            NavigationService.Navigate(new film_page(selectedFilmInSession));
        }
    }
}
