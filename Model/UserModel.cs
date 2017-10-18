using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozadavkyZakazniku.Model
{
    public class UserModel
    {
        // Primary key 
        public int UserID { get; set; }

        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string LoginName { get; set; }

        public string LoginPassword { get; set; }

        public Enumerators.Roles Role { get; set; }

        // Navigation property 
        //public virtual ICollection<Course> Courses { get; set; }
    }



    
}
