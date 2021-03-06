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
        public static ObservableCollection<Film> film { get; set; }
        public static FilmInSession filmSessions { get; set; }

        public film_page(FilmInSession selectedFilmInSession)
        {
            InitializeComponent();
            
            film = new ObservableCollection<Film>(cinema_pro_database_conection.connection.Film.ToList());
            //Передача данных из предыдущей страницы в текущую
            filmSessions = selectedFilmInSession;           
            
            this.DataContext = this;
        }
    }
}
