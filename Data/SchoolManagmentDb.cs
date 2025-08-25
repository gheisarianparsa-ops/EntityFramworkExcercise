using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityFramworkExcercise.Data;

    public class SchoolManagmentDb : DbContext
    {
        public SchoolManagmentDb (DbContextOptions<SchoolManagmentDb> options)
            : base(options)
        {
        }

        public DbSet<EntityFramworkExcercise.Data.Course> Course { get; set; } = default!;
    }
