using Microsoft.VisualBasic.ApplicationServices;
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
    /// Interaction logic for admin_space.xaml
    /// </summary>
    public partial class admin_space : Page
    {
        public static ObservableCollection<login_data> users { get; set; }
        public admin_space()
        {
            InitializeComponent();
            users = new ObservableCollection<login_data>(login_database_conection.connection.login_data.ToList());
            this.DataContext = this;
        }

        private void btn_back_event(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new page_authorization());
        }

        private void selected_item(object sender, SelectionChangedEventArgs e)
        {
            var info = (sender as ListView).SelectedItem as login_data;
            //Удаление
            if (MessageBox.Show($"Удалить учетную запись {info.name}", "Удалить?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //Удаление
                login_database_conection.connection.login_data.Remove(info);
                login_database_conection.connection.SaveChanges();
                //Обновление listView 
                list_view.Items.Refresh();
            }
        }
    }
}
