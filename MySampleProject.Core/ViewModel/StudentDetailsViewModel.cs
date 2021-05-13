using MySampleProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySampleProject.Core.ViewModel
{
    class StudentDetailsViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<Subjects> Subject { get; set; }
    }
}
