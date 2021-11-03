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
    /// Interaction logic for session_page.xaml
    /// </summary>
    public partial class session_page : Page
    {
        public static ObservableCollection<Session> session { get; set; }
        public static ObservableCollection<Film> film { get; set; }
        public static ObservableCollection<FilmInSession> filmInSession { get; set; }
        public int Film_ID;
       
        public session_page()
        {
            InitializeComponent();
            //CinemaCore core = new CinemaCore();
            //session = new ObservableCollection<Session>(cinema_pro_database_conection.connection.Session.ToList());
            
            session = new ObservableCollection<Session>(cinema_pro_database_conection.connection.Session.ToList());
            film = new ObservableCollection<Film>(cinema_pro_database_conection.connection.Film.ToList());
            
            //hall = new ObservableCollection<Hall>(cinema_pro_database_conection.connection.Hall.ToList());
            //
            //var filmInSes = session.Join(film,
            //    ses => ses.Film_ID,
            //    film => film.Film_ID,
            //    (ses, film) => new
            //    {
            //        DateTime = ses.DateTime,
            //        Hall_ID = ses.Hall_ID,
            //        Name = film.Name,
            //        Year_of_issue = film.Year_of_issue,
            //        Duration = film.Duration,
            //        AgeCategory_ID = film.AgeCategory_ID,
            //        FilmCompany_ID = film.FilmCompany_ID,
            //        Country_ID = film.Country_ID,
            //        Image = film.Image
            //    });
            //
            //filmInSession = new ObservableCollection<FilmInSession>(filmInSes.ToList());
            //foreach (var i in filmInSes)
            //{
            //
            //}
            this.DataContext = this;
        }

        private void film_select_event(object sender, RoutedEventArgs e)
        {
            Film_ID = (int)list_of_films.SelectedItems[Film_ID];
            MessageBox.Show($"{Film_ID}");
            NavigationService.Navigate(new film_page());
        }
    }
}
