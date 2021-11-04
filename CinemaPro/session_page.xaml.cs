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
        public static ObservableCollection<FilmInSession> filmInSession { get; set; }
        public static Film film_ID_in_session { get; set; }
        public static ArrayList ex { get; set; }
        public static Film tot { get; set; }

        public session_page()
        {
            InitializeComponent();
            //CinemaCore core = new CinemaCore();
            //session = new ObservableCollection<Session>(cinema_pro_database_conection.connection.Session.ToList());

            session = new ObservableCollection<Session>(cinema_pro_database_conection.connection.Session.ToList());
            film = new ObservableCollection<Film>(cinema_pro_database_conection.connection.Film.ToList());

            //hall = new ObservableCollection<Hall>(cinema_pro_database_conection.connection.Hall.ToList());
            //
            ex = new ArrayList(session.Join(film,
                ses => ses.Film_ID,
                film => film.Film_ID,
                (ses, film) => new
                {
                    DateTime = ses.DateTime,
                    Hall_ID = ses.Hall_ID,
                    Name = film.Name,
                    Year_of_issue = film.Year_of_issue,
                    Duration = film.Duration,
                    AgeCategory_ID = film.AgeCategory_ID,
                    FilmCompany_ID = film.FilmCompany_ID,
                    Country_ID = film.Country_ID,
                    Image = film.Image
                }).ToList());

            //foreach (var o in rotv)
            //{
            //    MessageBox.Show($"{o.DateTime} - {o.Hall_ID} . {o.Name} ({o.Duration}, {o.Year_of_issue} )");
            //}
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
            //foreach (ListViewItem item in list_of_films.SelectedItems)
            //{
            //    film_ID = item.Name;
            //}
            //var a = (sender as ListView).SelectedItem as Session;
            //film_ID = a.Film_ID;
            film_ID_in_session = new Film
            {
                //DateTime = a.DateTime,
                //Hall_ID = a.Hall_ID,
                Name = tot.Name,
                Year_of_issue = tot.Year_of_issue,
                Duration = tot.Duration,
                AgeCategory_ID = tot.AgeCategory_ID,
                FilmCompany_ID = tot.FilmCompany_ID,
                Country_ID = tot.Country_ID,
                Image = tot.Image
            };
            NavigationService.Navigate(new film_page(film_ID_in_session));
        }

        private void film_S(object sender, SelectionChangedEventArgs e)
        {
            var tot2 = (sender as ListView).SelectedItem;
            //MessageBox.Show($"{a.Name}");

            //ArrayList ki = new ArrayList { film_ID_in_session };
            //foreach (var i in ki)
            //{
            //    MessageBox.Show($"{i}");
            //    string[] ko = i.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    foreach (var o in ko)
            //    {
            //        MessageBox.Show($"{o}");
            //    }
            //}
            //MessageBox.Show($"{a}");

            //MessageBox.Show($"{a.DateTime}");
        }
    }
}
