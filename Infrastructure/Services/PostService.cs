namespace Infrastructure.Services;
using Domain.Models;

public class PostService
{
    List<Post> posts;

    public PostService()
    {
        posts = new List<Post>();
    }

    public List<Post> GetPosts()
    {
        return posts;
    }
    public void AddPost(Post Post)
    {
        posts.Add(Post);
    }
    public void UpdatePost(int id, Post Post)
    {
        foreach (var item in posts)
        {
            if (item.Id == id)
            {
                item.Title = Post.Title;
                item.Description = Post.Description;
                item.VoteAmount = Post.VoteAmount;
                item.CreatedAt = Post.CreatedAt;
            }
        }
    }
    public void Delete(int id)
    {
        foreach (var item in posts)
        {
            if (item.Id == id) posts.Remove(item);
        }
    }
}
