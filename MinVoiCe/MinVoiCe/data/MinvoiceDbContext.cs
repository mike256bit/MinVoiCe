﻿using MinVoiCe.Models;
using Microsoft.EntityFrameworkCore;

namespace MinVoiCe.data
{
    public class MinvoiceDbContext : DbContext
    {
        public MinvoiceDbContext(DbContextOptions<MinvoiceDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Project> Projects { get; set; }
    }
}