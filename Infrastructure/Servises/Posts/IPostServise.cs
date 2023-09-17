using Domain.Entity;
namespace Infrastructure.Servises;

public interface IPostServise
{
    Task<string> Add(Post t);
    Task<List<Post>> Get();
    Task<Post> GetById(int id);
    Task<string> Delete(int id);
    Task<bool> Update(Post t);
    Task<int> Count();

}
