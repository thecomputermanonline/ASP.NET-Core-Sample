using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSample.Models
{
    public class Employee :BaseEntity
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }              
        public string BankAccountNo { get; set; }
    }

    public class EmployeeViewModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }        
        public string BankAccountNo { get; set; }
    }
}
