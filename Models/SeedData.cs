using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AlwaysLikeThis.Data;
using System;
using System.Linq;

namespace AlwaysLikeThis.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new AlwaysLikeThisContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<AlwaysLikeThisContext>>()))
        {
            // Look for any articles.
            if (context.Article.Any())
            {
                return;   // DB has been seeded
            }
            context.Article.AddRange(
                new Article
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "G"
                },
                new Article
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "G"
                },
                new Article
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "G"
                },
                new Article
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "PG"
                }
            );
            context.SaveChanges();
        }
    }
}