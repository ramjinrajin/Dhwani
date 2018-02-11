﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhwani._2.Application.Models
{
   public class User
    {
       public int UserId { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string Email { get; set; }
       public DateTime DateOfBirth { get; set; }
       public long MobileNO { get; set; }
       public string Address { get; set; }
       public int Pincode { get; set; }

    }
}
