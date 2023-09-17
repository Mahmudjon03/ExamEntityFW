using Domain.Entity;
using Infrastructure.Servises;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

    [ApiController]
    [Route("controller")]

    public class PotsController
    {
        private readonly IPostServise _postServise;

        public PotsController(IPostServise postServise)
        {
            _postServise = postServise;
        }
        [HttpGet("GetPost")]
        public async Task<List<Post>> Get() => await _postServise.Get();
        [HttpGet("getByIdPost")]
        public async Task<Post> getById(int id) => await _postServise.GetById(id);
        [HttpDelete("DeletePost")]
        public async Task<string> Delete(int id) => await _postServise.Delete(id);
        [HttpPost("AddPost")]
        public async Task<string> Add(Post c) => await _postServise.Add(c);
        [HttpPut("UpdatePost")]

        public async Task<bool> Update(Post c) => await _postServise.Update(c);
    [HttpGet("CountPost")]
    public async Task<int> Count()=> await _postServise.Count();

    }

