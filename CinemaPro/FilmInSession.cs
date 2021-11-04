using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPro
{
    public partial class FilmInSession
    {

        public System.DateTime DateTime { get; set; }
        public int Hall_ID { get; set; }
        public string Name { get; set; }
        public int Year_of_issue { get; set; }
        public int Duration { get; set; }
        public int AgeCategory_ID { get; set; }
        public int FilmCompany_ID { get; set; }
        public int Country_ID { get; set; }
        public string Image { get; set; }
    }
}
