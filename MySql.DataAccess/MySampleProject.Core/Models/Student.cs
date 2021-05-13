using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySampleProject.Core.Models
{
    public class Student 
    {
        

        public int ID { get; set; }
        [StringLength(20)]
        public string UID { get; set; }
        [DisplayName("Student name")]
        public string NAME { get; set; }
        [Range(4, 20)]

        [DisplayName("Student age")]
        public double AGE { get; set; }

        [DisplayName("Student sex")]
        public string SEX { get; set; }
        [Range(1, 12)]
        public string CLASS { get; set; }
       
        [DisplayName("First subject")]
        public string SUBJECT1 { get; set; }
        [DisplayName("Second subject")]     
        public string SUBJECT2 { get; set; }
        [StringLength(500)]

        [DisplayName("Residental address")]
        public string ADDRESS { get; set; }
        [Range(0, 1000)]

        [DisplayName("First subject mark")]
        public double MARKS1 { get; set; }
        [Range(0, 1000)]
        [DisplayName("Second subject mark")]
        public double MARKS2 { get; set; }


    }
}
