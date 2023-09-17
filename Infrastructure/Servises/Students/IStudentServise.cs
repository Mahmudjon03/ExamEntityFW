using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Servises.Students
{
    public interface IStudentServise
    {
        Task<string> AddStudents(Student student);
        Task<List<Student>> GetStudent();
        Task<Student>   GetByIdStudent(int id);
        Task<string> DleteStudent(int id);
        Task<bool> UpdateStudent(Student s);
        Task<int> Count();

    }
}
