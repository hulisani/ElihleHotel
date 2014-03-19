using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Monitor.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get;set;}
        public string UserName { get; set; }
        public string Password { get; set; }
        public string IdNumber { get; set; }
        public DateTime StartDateOfEmployment { get; set; }


    }
}
