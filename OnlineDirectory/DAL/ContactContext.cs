using OnlineDirectory.DomainEntites;
using System.Data.Entity;

namespace OnlineDirectory.DAL
{
    public class ContactContext: DbContext
    {
        public ContactContext():base("DefaultConnection")
        {

        }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
