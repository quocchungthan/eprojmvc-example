﻿using eprojectinstruct.Models;
using System.Data.Entity;

namespace eprojectinstruct
{
    public class EProjectDbContext : DbContext
    {
        public EProjectDbContext(string nameOrConnectionString) : base("eproject_constr")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}