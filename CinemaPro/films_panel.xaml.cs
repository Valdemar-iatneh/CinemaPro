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
        public static ObservableCollection<Film> films { get; set; }
        public films_panel()
        {
            InitializeComponent();
            films = new ObservableCollection<Film>(cinema_pro_database_conection.connection.Film.ToList());
            
            this.DataContext = this;
            
        }
    }
}
