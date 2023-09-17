using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Servises.Courses
{
    public  interface ICourseServise
    {
        Task<string> Add(Course t);
        Task<List<Course>> Get();
        Task<Course> GetById(int id);
        Task<string> Delete(int id);
        Task<bool> Update(Course t);
        Task<int> Count();
    
}
}
