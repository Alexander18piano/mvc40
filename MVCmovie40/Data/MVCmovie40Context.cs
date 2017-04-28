using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCmovie40.Models
{
    public class MVCmovie40Context : DbContext
    {
        public MVCmovie40Context (DbContextOptions<MVCmovie40Context> options)
            : base(options)
        {
        }

        public DbSet<MVCmovie40.Models.Movie> Movie { get; set; }
    }
}
