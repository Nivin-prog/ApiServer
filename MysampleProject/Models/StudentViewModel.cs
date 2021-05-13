using MySampleProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MysampleProject.Models
{
    public class StudentViewModel
    {
        public Student StudentDetails { get; set; }

        public IEnumerable<Subjects> subjects { get; set; }

        public IEnumerable<SexModel> sex { get; set; }
    }
}