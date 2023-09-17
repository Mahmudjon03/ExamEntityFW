using Domain.Entity;
using Infrastructure.Servises.Teachers;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("controller")]
    public class TeacherControllr
    {
        private readonly ITeacherServise _teacherServise;

        public TeacherControllr(ITeacherServise teacherServise)
        {
           _teacherServise = teacherServise;
        }
        [HttpGet("GEtTeachets")]
        public async Task<List<Teacher>> Get() => await _teacherServise.Get();
        [HttpPost("AddTeacher")]
        public async Task<string> Add(Teacher t) => await _teacherServise.Add(t);
        [HttpPut("UpdateTeacher")]
        public async Task<bool> UpdateTeAcher(Teacher t) => await _teacherServise.Update(t);
        [HttpDelete("DeleteTeacher")]
        public async Task<string> Delete(int id) => await _teacherServise.Delete(id);
        [HttpGet("GetByIdTeacher")]
        public async Task<Teacher> GetById(int id)=> await _teacherServise.GetById(id);
        [HttpGet("Countteacher")]
        public async Task<int> Count()=>await _teacherServise.Count();


    }
}
