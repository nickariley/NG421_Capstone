using AutoMapper.Configuration;
using capstone.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace capstone.Data
{

    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public IConfiguration Configuration { get; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }
        public ApplicationDbContext() : base(new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite("Data Source=app.db").Options,null)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Movie>()
                .HasData(
                    new Movie {
                        Id = 1,
                        MovieTitle = "Back to the Future",
                        Genre = "Sci-fi/Adventure",
                        ReleaseDate = new DateTime(1985, 7, 3),
                        Watched = true,
                        UserId = "86b6a5a5-2da1-4287-a6d6-478b0a7c6072"
                    },
                    new Movie {
                        Id = 2,
                        MovieTitle = "Back to the Future Part II",
                        Genre = "Comedy/Sci-fi",
                        ReleaseDate = new DateTime(1989, 11, 22),
                        Watched = true,
                        UserId = "86b6a5a5-2da1-4287-a6d6-478b0a7c6072"
                    },
                    new Movie {
                        Id = 3,
                        MovieTitle = "Back to the Future Part III",
                        Genre = "Comedy/Western",
                        ReleaseDate = new DateTime(1990, 5, 25),
                        Watched = true,
                        UserId = "86b6a5a5-2da1-4287-a6d6-478b0a7c6072"
                    }
                );
            base.OnModelCreating(builder);
        }
    }
}
