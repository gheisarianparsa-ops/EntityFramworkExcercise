using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityFramworkExcercise.Data;

    public class SchoolManagmenDbContext : DbContext
    {
        public SchoolManagmenDbContext (DbContextOptions<SchoolManagmenDbContext> options)
            : base(options)
        {
        }

        public DbSet<EntityFramworkExcercise.Data.Enrollment> Enrollment { get; set; } = default!;
    }
