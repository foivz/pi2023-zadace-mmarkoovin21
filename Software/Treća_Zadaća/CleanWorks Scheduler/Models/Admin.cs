﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanWorks_Scheduler.Models
{
    public class Admin : Person
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
