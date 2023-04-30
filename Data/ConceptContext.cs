using InternTask.Entities;
using Microsoft.EntityFrameworkCore;

namespace InternTask.Data
{
    public class ConceptContext:DbContext
    {
        public ConceptContext(DbContextOptions<ConceptContext> options)
        : base(options)
        {
        }

        public DbSet<Concept> Concepts
        {
            get;
            set;
        }
    
      
    }
}
