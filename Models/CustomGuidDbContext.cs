using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FrontEnd.Models
{
    public class CustomGuidDbContext:DbContext
    {
        public CustomGuidDbContext():base("CustomGuidConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<AboutSection> AboutSections { set; get; }
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Header> Headers { set; get; }
        public DbSet<Navigation> Navigations { set; get; }
        public DbSet<PortFolio> PortFolios { set; get; }
        public DbSet<Social> Socials { set; get; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}