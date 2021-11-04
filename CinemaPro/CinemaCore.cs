using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPro
{
    class CinemaCore
    {
        public static ObservableCollection<Session> session { get; set; }
        public static ObservableCollection<Film> film { get; set; }
        public static ObservableCollection<Hall> hall { get; set; }
    }
}
