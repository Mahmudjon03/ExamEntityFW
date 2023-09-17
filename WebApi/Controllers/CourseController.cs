using Domain.Entity;
using Infrastructure.Servises.Courses;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

    [ApiController]
     [Route("controller")]
    public class CourseController
    {
    private readonly ICourseServise _coutseServise;

    public CourseController(ICourseServise coutseServise)
    {
        _coutseServise = coutseServise;
    }
    [HttpGet("GetCourse")]
    public async Task<List<Course>> Get() =>await _coutseServise.Get();
    [HttpGet("getByIdCourse")]
    public async Task<Course> getById(int id) => await _coutseServise.GetById(id);
    [HttpDelete("DeleteCourse")]
    public async Task<string> Delete(int id) => await _coutseServise.Delete(id);
    [HttpPost("AddCoutse")]
    public async Task<string> Add( Course c) => await _coutseServise.Add(c);
    [HttpPut("UpdateCourse")]

    public async Task<bool> Update(Course c)  => await _coutseServise.Update(c);
    [HttpGet("CountCourse")]
    public async Task<int> Count()=> await _coutseServise.Count();


    }

