using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using superHerosproject.Models;

namespace superHerosproject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<SuperHero>Heros { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
