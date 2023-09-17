using System.ComponentModel.DataAnnotations;


namespace Domain.Entity;

    public class Post
    {
    public int Id { get; set; }
    [MaxLength(100)]
    public string title { get; set; }

    public string Description { get; set; }
    
    public int Vote { get; set; }

    public DateTime CreateAt { get; set; }
}

