using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Servises.Teachers
{
    public interface ITeacherServise
    {
        Task<string> Add(Teacher t);
        Task<List<Teacher>> Get();
        Task<Teacher> GetById(int id);
        Task<string> Delete(int id);
        Task<bool> Update(Teacher t);
        Task<int> Count();
    }
}
