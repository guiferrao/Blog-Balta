using System;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Blog
{
    class Program
    {
        static void Main()
        {
           using var context = new BlogDataContext();

        //    context.Users.Add(new User
        //    {
        //        Bio = "Estudante",
        //        Email = "emailteste@gmail.com",
        //        Image = "https://...",
        //        Name = "Guilherme Ferrão",
        //        PasswordHash = "12345",
        //        Slug = "guilherme-ferrao"
        //    });
        //    context.SaveChanges();

            var user = context.Users.FirstOrDefault();
            var post = new Post
            {
                Author = user,
                Body = "Meu Artigo",
                Category = new Category
                {
                    Name = "Backend",
                    Slug = "backend"
                },
                CreateDate = System.DateTime.Now,
                //lastUpdateDate=
                Slug = "meu-artigo",
                Summary = "Neste artigo ... ",
                //Tags=null,
                Title = "Meu Artigo",
            };

            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
