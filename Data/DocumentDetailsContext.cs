using Document_Saver.Models;
using Microsoft.EntityFrameworkCore;

namespace Document_Saver.Data
{
    public class DocumentDetailsContext : DbContext
    {
        public DocumentDetailsContext(DbContextOptions<DocumentDetailsContext> options) : base(options)
        {

        }

        public DbSet<User> UserDetails { get; set;  }
        //public DbSet<ProjectDetails> ProductDetails { get; set; }

        //public DbSet<Documents> Documents { get; set; }

        //public DbSet<Activities> Activities { get; set; }

        //public DbSet<ProjectMember> ProjectMember { get; set; }




    }


}
