﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Server.Data
{
    public class ApplicationContext : IdentityDbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
