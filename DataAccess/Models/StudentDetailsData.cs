using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class StudentDetailsData
    {

        public int ID { get; set; }        
        public string UID { get; set; }
        public string NAME { get; set; }
        public double AGE { get; set; }
        public string SEX { get; set; }
        public string CLASS { get; set; }
        public string SUBJECT1 { get; set; }      
        public string SUBJECT2 { get; set; }
        public string ADDRESS { get; set; }
        public double MARKS1 { get; set; }        
        public double MARKS2 { get; set; }

    }
}