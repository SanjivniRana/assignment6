using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Data.Entity_Models
{
    public class Employee1
    {
        [Key]
        public int EId { get; set; }
        public string EName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public bool MaritalStatus { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        
    }
}
