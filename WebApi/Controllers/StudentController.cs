
using Domain.Entity;
using Infrastructure.Servises.Students;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

[ApiController]
[Route("[controller]")]
    public class StudentController
    {
    private readonly IStudentServise _studentServise;

   
    public StudentController(IStudentServise studentServise)
    {
        _studentServise = studentServise;
    }
    [HttpPost]
    public async Task<string> AddStudent(Student s) =>await _studentServise.AddStudents(s);
    [HttpGet("GetStudent")]
    public async Task<List<Student>> GetStudents() => await _studentServise.GetStudent();
    [HttpDelete]
    public async Task<string> DeleteStudent(int id)=> await _studentServise.DleteStudent(id);
    [HttpGet("GEtByIdStudent")]
    public async Task<Student> GetbyIdStudent(int id) => await _studentServise.GetByIdStudent(id);
    [HttpPut]
    public async Task<bool> UpdateStudent(Student s)=> await _studentServise.UpdateStudent(s);
    [HttpGet("CountStudent")]
    public async Task<int> Count()=> await _studentServise.Count(); 
    

    }

