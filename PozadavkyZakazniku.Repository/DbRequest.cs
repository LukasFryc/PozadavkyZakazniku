using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PozadavkyZakazniku.Model;


namespace PozadavkyZakazniku.Repository
{
    public class DbRequest : DbContext 
    {
        public DbRequest()
            : base("name=DbRequest")
        {
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Request> Requests { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<Module> Modules { get; set; }
    }

    

    public class User
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

    

    public class Request
    {
        public int RequestID { get; set; }

        public DateTime Created { get; set; }

        public Enumerators.Priority Priority { get; set; }

        public virtual User Author { get; set; }

        public string Description { get; set; }

        public virtual Status Status { get; set; }

    }

    public class Status
    {
        public int StatusID { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

    }

    public class Module
    {
        public int ModuleID { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

    }








}
