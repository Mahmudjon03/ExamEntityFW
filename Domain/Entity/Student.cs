using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string firstName { get; set; }
        [MaxLength(30)]
        public string lastName { get; set; }
        [MaxLength(30)]
        public string FatherName { get; set; }
        public DateTime BirthDate { get; set; }
        [MaxLength(30)]
        public string Address { get; set; }
        [MaxLength(30)]
        public string Phone { get; set; }
    }
}
