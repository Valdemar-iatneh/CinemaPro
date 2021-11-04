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
    /// Interaction logic for films_panel.xaml
    /// </summary>
    public partial class films_panel : Page
    {
        public static int selectedFilmInSession_FilmID { get; set; }
        public static ObservableCollection<Film> films { get; set; }
        public films_panel()
        {
            InitializeComponent();
            films = new ObservableCollection<Film>(cinema_pro_database_conection.connection.Film.ToList());
            this.DataContext = this;
        }

        private void film_select_event(object sender, RoutedEventArgs e)
        {
            //Передача Film_ID из выбранного фильма
            selectedFilmInSession_FilmID = (list_of_films.SelectedItem as Film).Film_ID;
            //Переход на страницу с фильмом
            NavigationService.Navigate(new film_page_in_films(selectedFilmInSession_FilmID));
        }
    }
}
