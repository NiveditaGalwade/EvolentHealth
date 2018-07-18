using System.Collections.Generic;
using System.Linq;
using OnlineDirectory.DomainEntites;
using System.Data.Entity;
namespace OnlineDirectory.DAL
{
    public class ContactRepository : IContactRepository<Contact>
    {
        ContactContext contactDbContext = new ContactContext();
        public int Create(Contact contact)
        {
            if(contact!=null)
            {
                contactDbContext.Contacts.Add(contact);
                contactDbContext.SaveChanges();
                return 1;
            }
            return 0;            
        }

        public int Delete(Contact contact)
        {
            if (contact != null)
            {
                contactDbContext.Contacts.Remove(contact);
                contactDbContext.SaveChanges();
                return 1;
            }
            return 0;
        }

        public int Edit(Contact contact)
        {
            if (contact != null)
            {
                contactDbContext.Entry(contact).State = EntityState.Modified;
                contactDbContext.SaveChanges();
                return 1;
            }
            return 0;
        }

        
        public IEnumerable<Contact> FindAll()
        {
            return contactDbContext.Contacts.ToList();
        }

        public Contact FindById(int? id)
        {
            return contactDbContext.Contacts.Find(id);
        }
    }
}
