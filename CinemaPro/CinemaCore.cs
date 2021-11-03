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
        //public List<> getFullSession()
        //{
        //    session = new ObservableCollection<Session>(cinema_pro_database_conection.connection.Session.ToList());
        //    film = new ObservableCollection<Film>(cinema_pro_database_conection.connection.Film.ToList());
        //    //hall = new ObservableCollection<Hall>(cinema_pro_database_conection.connection.Hall.ToList());
        //
        //    var filmInSession = session.Join(film,
        //        ses => ses.Film_ID,
        //        film => film.Film_ID,
        //        (ses, film) => new
        //        {
        //            DateTime = ses.DateTime,
        //            Hall_ID = ses.Hall_ID,
        //            Name = film.Name,
        //            Year_of_issue = film.Year_of_issue,
        //            Duration = film.Duration,
        //            AgeCategory_ID = film.AgeCategory_ID,
        //            FilmCompany_ID = film.FilmCompany_ID,
        //            Country_ID = film.Country_ID,
        //            Image = film.Image
        //        });
        //
        //    filmInSession.ToList();
        //
        //    //var filmInSessionAndInHall = filmInSession.Join(hall,
        //    //    filmses => filmses.Hall_ID,
        //    //    hall => hall.Hall_ID,
        //    //    (filmses, hall) => new
        //    //    {
        //    //        DateTime = filmses.DateTime,
        //    //        Hall = hall.Name,
        //    //        Name = filmses.Name,
        //    //        Year_of_issue = filmses.Year_of_issue,
        //    //        Duration = filmses.Duration,
        //    //        AgeCategory_ID = filmses.AgeCategory_ID,
        //    //        FilmCompany_ID = filmses.FilmCompany_ID,
        //    //        Country_ID = filmses.Country_ID,
        //    //        Image = filmses.Image,
        //    //    });
        //}
    }
}
