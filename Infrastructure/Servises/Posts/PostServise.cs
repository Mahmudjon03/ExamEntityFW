using Domain.Entity;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Servises.Posts
{
    public class PostServise : IPostServise
    {
        private readonly DataContext _dataContext;

        public PostServise(DataContext dataContext )=>_dataContext = dataContext;
        
        public async Task<string> Add(Post t)
        {
           await _dataContext.Posts.AddAsync(t);
            _dataContext.SaveChanges();
            return "Post added";
        }

        public async Task<string> Delete(int id)
        {
            _dataContext.Posts.Remove(await _dataContext.Posts.FindAsync(id));
            _dataContext.SaveChanges();
            return "Post delete";
        }

        public Task<List<Post>> Get() => _dataContext.Posts.ToListAsync();

        public async Task<Post> GetById(int id) => await _dataContext.Posts.FindAsync(id);

        public async Task<bool> Update(Post t)
        {

            var res =await _dataContext.Posts.FindAsync(t.Id);
            if (res==null) return false;
            res.title = t.title;
            res.Description = t.Description;
            res.Vote = t.Vote;
            res.CreateAt = t.CreateAt;
            _dataContext.SaveChanges();
            return true;
            
        }
        public async Task<int> Count() => await _dataContext.Posts.CountAsync();
    }
}
