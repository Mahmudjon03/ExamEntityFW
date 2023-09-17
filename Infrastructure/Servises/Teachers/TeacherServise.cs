using Domain.Entity;
using Infrastructure.Data;
using Infrastructure.Servises.Teachers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servises.Teachers;

public class TeacherServise : ITeacherServise
{
    private readonly DataContext _dataContext;

    public TeacherServise(DataContext dataContext) => _dataContext = dataContext;




    public async Task<string> Add(Teacher t)
    {
        await _dataContext.Teachers.AddAsync(t);
        _dataContext.SaveChanges();

        return "Teacher addded";

    }

        public async Task<string> Delete(int id)
    {
      _dataContext.Teachers.Remove(await _dataContext.Teachers.FindAsync(id));
        _dataContext.SaveChanges();

        return "Teacher remotely";
    }

    public async Task<List<Teacher>> Get()=> await _dataContext.Teachers.ToListAsync();
    
        
    

    public  async Task<Teacher> GetById(int id) =>  await _dataContext.Teachers.FindAsync(id);




    public async Task<bool> Update(Teacher t)
    {
        var tech = await _dataContext.Teachers.FindAsync(t.Id);   
        tech.Name=t.Name;
        tech.SurName=t.SurName;
        tech.Position=t.Position;
        tech.Experience=t.Experience;
        _dataContext.SaveChanges();
        return true;
    }
    public async Task<int> Count()=> await _dataContext.Teachers.CountAsync();
}


