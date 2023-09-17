using Domain.Entity;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Servises.Students
{
    public class StudentServise : IStudentServise
    {
        private readonly DataContext _dataContext;

        public StudentServise(DataContext dataContext)  => _dataContext = dataContext;



        public async Task<string> AddStudents(Student student)
        {
           await _dataContext.Students.AddAsync(student);
            _dataContext.SaveChanges();
            return "Student added";

        }
        public async Task<List<Student>> GetStudent() => await _dataContext.Students.ToListAsync();




        public async Task<Student> GetByIdStudent(int id)  =>  await _dataContext.Students.FindAsync(id);
        
        public async Task<string> DleteStudent(int id)
        {
          _dataContext.Students.Remove(await _dataContext.Students.FindAsync(id));
            _dataContext.SaveChanges();
            return "Student remotely" ;
        }
        public async Task<bool> UpdateStudent(Student s)
        {
            var res =await _dataContext.Students.FindAsync(s.Id);
            if(res==null) return false;

           res.firstName = s.firstName;
            res.lastName = s.lastName;
            res.FatherName= s.FatherName;
            res.BirthDate= s.BirthDate;
            res.Address = s.Address;
            res.Phone = s.Phone;
            _dataContext.SaveChanges();
                return true;
           
        }
        public async Task<int> Count()  => await _dataContext.Students.CountAsync();
          
    }
}
