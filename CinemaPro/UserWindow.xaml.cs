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
using System.Windows.Shapes;

namespace CinemaPro
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
            //Переход к сеансам фильмов
            films.NavigationService.Navigate(new session_page());
        }

        //Переход в Главное меню
        private void mainMenu_click_event(object sender, RoutedEventArgs e)
        {
            films.NavigationService.Navigate(new session_page());
        }
        //Переход к всем фильмам
        private void allFilms_click_event(object sender, RoutedEventArgs e)
        {           
            films.NavigationService.Navigate(new films_panel());
        }        
    }
}
