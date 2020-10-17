
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models
{
    public class productcontext : DbContext

    {

        public productcontext(DbContextOptions<productcontext> options)
            : base(options)
        {
        }

        public DbSet<product> products { get; set; }
    }
}
