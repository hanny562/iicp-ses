using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.Schools;

namespace WebApplication1.Models.Users
{
    public class Lecturer : User
    {
        public int LecturerID { get; set; }

        public virtual School School { get; set; }
    }
}