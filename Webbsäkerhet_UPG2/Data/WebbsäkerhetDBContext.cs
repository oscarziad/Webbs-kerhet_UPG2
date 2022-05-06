using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Webbsäkerhet_UPG2.Models;

    public class WebbsäkerhetDBContext : DbContext
    {
        public WebbsäkerhetDBContext (DbContextOptions<WebbsäkerhetDBContext> options)
            : base(options)
        {
        }

        public DbSet<Comment> Comment { get; set; }
        public DbSet<ForumFile> File { get; set; }
}
