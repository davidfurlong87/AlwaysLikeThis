using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlwaysLikeThis.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using AlwaysLikeThis.Migrations;

// created via: "Add-Migration InitialCreate" -> "Update - Database"

// The InitialCreate argument is the migration name.
// Add-Migration InitialCreate: Generates a Migrations/{timestamp}_InitialCreate.cs migration file.

// Update - Database: Updates the database to the latest migration.
// Runs the Up method in the Migrations/{time-stamp}_InitialCreate.cs file, which creates the database.



namespace AlwaysLikeThis.Data
{
    public class AlwaysLikeThisContext : DbContext
    {
        public AlwaysLikeThisContext (DbContextOptions<AlwaysLikeThisContext> options)
            : base(options)
        {
        }

        public DbSet<AlwaysLikeThis.Models.Article> Article { get; set; } = default!;
    }
}
