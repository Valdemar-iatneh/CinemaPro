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
    /// Interaction logic for film_page.xaml
    /// </summary>
    public partial class film_page : Page
    {
       // public int film_ID_in_session;
        public static ObservableCollection<Film> film { get; set; }
        public static FilmInSession filmSessions { get; set; }

        public film_page(FilmInSession tot)
        {
            InitializeComponent();
            
            film = new ObservableCollection<Film>(cinema_pro_database_conection.connection.Film.ToList());
            filmSessions = tot;
            
            //test1.Text = film_ID_in_session.ToString();
            //foreach (var e in film_ID_in_session)
            //MessageBox.Show($"{film_ID_in_session}");
            //filmInSes1 = new ObservableCollection<FilmInSession>(film_ID_in_session);
            //filmInSes = new ObservableCollection<Film>(film.Where(f => f.Film_ID == film_ID_in_session).ToList());
            //List<Film> s = new Li st<Film>();
            ///newFil = new ArrayList
            ///{
            ///    film_ID_in_session
            ///};
            ///foreach(var i in newFil)
            ///{
            ///    //MessageBox.Show($"{i}");
            ///    newFil2 = new ArrayList { i };
            ///    dynamic d = i;
            ///    MessageBox.Show($"{d}");
            ///    foreach (var o in d)
            ///    {
            ///        MessageBox.Show($"{o}");
            ///    }
            ///    //for (int y = 0; y < i.GetType)
            ///}
            //string area = 
            //foreach(var f in newFil2)
            //{
            //    MessageBox.Show($"{f}");
            //}
            //test1.Text = film_ID_in_session.ToString();

            this.DataContext = this;
            //var fo = filmInSes as Film;
            //foreach (var f in filmInSes)
            //{
            //    s.Add(f);
            //}
            //var fil = s[0];
            //testo.Text = filmInSes.Film_ID;
            
            
            //int a = filmInSes.
            //string b = fil.Name;
            //MessageBox.Show($"{fo.Name} ");
            //ror.Text = filmInSes.Film_ID;
        }
    }
}
