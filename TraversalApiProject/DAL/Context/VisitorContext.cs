using Microsoft.EntityFrameworkCore;
using TraversalApiProject.DAL.Entities;

namespace TraversalApiProject.DAL.Context
{
    public class VisitorContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-39CPBHK\\KOCABAY; initial catalog= TraversalDbApi; integrated security=true; TrustServerCertificate=true;");

        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
