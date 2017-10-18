using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozadavkyZakazniku.Model
{
    public class RequestModel
    {
        public int RequestID { get; set; }

        public DateTime Created { get; set; }

        public Enumerators.Priority Priority { get; set; }

        public virtual UserModel Author { get; set; }

        public string Description { get; set; }

        public virtual StatusModel Status { get; set; }

    }

    
}
