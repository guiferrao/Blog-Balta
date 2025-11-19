using System;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main()
        {
            using (var context = new BlogDataContext())
            {
               using var context = new BlogDataContext();
            // var user = new User
            // {
            //     Name = "André Baltieri",
            //     Slug = "andrebaltieri",
            //     Email = "andre@balta.io",
            //     Bio = "9x Microsoft MVP",
            //     Image = "https://balta.io",
            //     PasswordHash = "123098457"
            // };
            //
            // var category = new Category {Name = "Backend", Slug = "backend"};
            //
            // var post = new Post
            // {
            //     Author = user,
            //     Category = category,
            //     Body = "<p>Hello world</p>",
            //     Slug = "comecando-com-ef-core",
            //     Summary = "Neste artigo vamos aprender EF core",
            //     Title = "Começando com EF Core",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now,
            // };
            //
            // context.Posts.Add(post); 
            // context.SaveChanges();

            // var posts = context
            //     .Posts
            //     .AsNoTracking()
            //     .Include(x => x.Author)
            //     .Include(x => x.Category)
            //     .OrderBy(x => x.LastUpdateDate)
            //     .ToList();
            //
            // foreach (var post in posts) 
            //     Console.WriteLine($"{post.Title} por {post.Author.Name} em {post.Category.Name}");
            
            // var post = context
            //     .Posts
            //     .Include(x => x.Author)
            //     .Include(x => x.Category)
            //     .OrderBy(x => x.LastUpdateDate)
            //     .FirstOrDefault(); 
            //
            // post.Author.Name = "Uncle Bob";
            //
            // context.Posts.Update(post);
            // context.SaveChanges();
            }
        }
    }
}
