using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.PostDto.cs
{
    public class PostDto
    {
        public int Id { get; set; }
        public string title { get; set; }

        public string Description { get; set; }
        public int Vote  { get; set; }
        public DateTime CreateAt { get; set; }


    }
}
