using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlwaysLikeThis.Models;

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
