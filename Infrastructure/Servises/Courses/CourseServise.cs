using Domain.Entity;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Servises.Courses
{
    public class CourseServise : ICourseServise
    {
        private readonly DataContext _dataContext;

        public CourseServise(DataContext dataContext)=> _dataContext = dataContext;



        public async Task<string> Add(Course t)
        {
           await _dataContext.Courses.AddAsync(t);
            _dataContext.SaveChanges();
            return "Course Added";
        }

        public async Task<string> Delete(int id)
        {
            _dataContext.Courses.Remove(await _dataContext.Courses.FindAsync(id));
            _dataContext.SaveChanges();
            return "Student Added";
        }

        public Task<List<Course>> Get() => _dataContext.Courses.ToListAsync();




        public async Task<Course> GetById(int id) => await _dataContext.Courses.FindAsync(id);
       

        public async Task<bool> Update(Course t)
        {
         var res =await _dataContext.Courses.FindAsync(t.Id);
            if (res == null) return false ;
            res.Title = t.Title;
            res.Description = t.Description;
            res.Fee = t.Fee;
            res.HasDiscount = t.HasDiscount;
            _dataContext.SaveChanges();
            return true;
        }
        public async Task<int> Count() => await _dataContext.Courses.CountAsync();





    }
}
