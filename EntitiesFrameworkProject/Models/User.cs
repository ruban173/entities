using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesFrameworkProject
{
    class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string access { get; set; }
        public DateTime date { get; }
        public Boolean status { get; set; }



    }
}
