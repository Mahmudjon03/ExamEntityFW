using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.DtoCourse;

    public class CourseDto
    {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Fee { get; set; }
    public bool HasDiscount { get; set; }

}



