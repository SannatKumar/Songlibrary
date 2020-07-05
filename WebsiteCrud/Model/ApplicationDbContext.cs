﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteCrud.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Song> Song { get; set; }

        public static implicit operator ApplicationDbContext(ApplicationExceptionDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}
