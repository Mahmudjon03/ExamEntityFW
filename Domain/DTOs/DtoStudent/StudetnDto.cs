using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.DtoStudent
{
    public class StudetnDto
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string FatherName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
