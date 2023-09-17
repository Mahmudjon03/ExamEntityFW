using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Teacher
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string SurName { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }
    }
}
