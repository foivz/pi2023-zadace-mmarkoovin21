using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanWorks_Scheduler.Models
{
    public class Worker : Person

    {
        public string MailWorker { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
    }
}
