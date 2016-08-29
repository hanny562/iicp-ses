using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.Programs;
using WebApplication1.Models.Users;

namespace WebApplication1.Models.Schools
{
    public class School
    {
        public int SchoolID { get; set; }
        public string SchoolName { get; set; }

        /// <summary>
        /// A list of lecturers teaching in this School
        /// </summary>
        public virtual List<Lecturer> Lecturers { get; set; }
        public virtual List<Program> Programs { get; set; }
    }
}