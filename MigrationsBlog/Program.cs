using System.Linq.Expressions;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        // static async Task Main()
        // {
        //     // ASYNC E AWAIT
        //     // using var context = new BlogDataContext();

        //     // var post = await context.Posts.ToListAsync();
        //     // var tags = await context.Users.ToListAsync();

        //     // var posts = await GetPosts(context);

        //     // Console.WriteLine("Teste");
        // }

        // public static async Task<IEnumerable<Post>> GetPosts(BlogDataContext context)
        // {
        //     return await context.Posts.ToListAsync();
        // }

        // static void Main()
        // {
        //     // LAZY LOADING
        //     // using var context = new BlogDataContext();

        //     // var posts = context.Posts;
        //     // foreach(var post in posts)
        //     // {
        //     //     foreach(var tags in post.Tags)
        //     //     {
                    
        //     //     }
        //     // }

        //     // EAGER LOADING
        //     // using var context = new BlogDataContext();

        //     // var posts = context.Posts
        //            .Include(x=>x.Author)
        //              .ThenInclude(x=>x.Roles);
        //     // foreach(var post in posts)
        //     // {
        //     //     foreach(var tags in post.Tags)
        //     //     {
                    
        //     //     }
        //     // }
        // }

        // static void Main()
        // {
        // PAGINAÇÃO DOS DADOS
        //     using var context = new BlogDataContext();
        //     var posts = GetPosts(context, 0, 25);
        //     var posts2 = GetPosts(context, 25, 25);
        //     var posts3 = GetPosts(context, 50, 25);
        //     var posts4 = GetPosts(context, 75, 25);
        // }
        
        // public static List<Post> GetPosts(BlogDataContext context, int skip = 0, int take = 25)
        // {
        //     var posts = context
        //         .Posts
        //         .AsNoTracking()
        //         .Skip(skip)
        //         .Take(take)
        //         .ToList();
        //     return posts;
        // }

        // static void Main()
        // {
        // QUERIES PURAS
        //     using var context = new BlogDataContext();
        //     var posts = context.PostWithTagsCount.ToList();
        //     foreach(var item in posts)
        //     {
        //         item.Count;
        //     }
        // }
    }
}
