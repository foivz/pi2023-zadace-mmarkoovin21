using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanWorks_Scheduler.Models
{
    public abstract class Person : object
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OIB { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

}
