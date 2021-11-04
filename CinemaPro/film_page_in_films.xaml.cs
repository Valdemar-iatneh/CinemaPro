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
    /// Interaction logic for film_page_in_films.xaml
    /// </summary>
    public partial class film_page_in_films : Page
    {
        public static ObservableCollection<Film> film { get; set; }
        public static ObservableCollection<Film> filmInSes { get; set; }
        public film_page_in_films(int selectedFilmInSession_FilmID)
        {
            InitializeComponent();
            film = new ObservableCollection<Film>(cinema_pro_database_conection.connection.Film.ToList());
            //Выборка среди фильмов где Film_Id соответствует выбранному фильму
            filmInSes = new ObservableCollection<Film>(film.Where(f => f.Film_ID == selectedFilmInSession_FilmID).ToList());
            this.DataContext = this;
        }
    }
}
