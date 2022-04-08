﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Yousif_Models.Models;

namespace Yousif_DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opstions) : base(opstions)
        {
            //Start .Net Core Course 2
        }

        public DbSet<Category> Category { get; set; }

        public DbSet<ApplicationType> ApplicationType { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<InquiryHeader> InquiryHeader { get; set; }

        public DbSet<InquiryDetail> InquiryDetail { get; set; }
    }
}
