using OnlineDirectory.DAL;
using OnlineDirectory.DomainEntites;
using System.Collections.Generic;

namespace OnlineDirectory.BLL
{
    public class ContactService : IContactService<Contact>
    {
        private readonly IContactRepository<Contact> _contactRepository;
        public ContactService(IContactRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public int Create(Contact contact)
        {
            return _contactRepository.Create(contact);
        }

        public IEnumerable<Contact> FindAll()
        {
            return _contactRepository.FindAll();
        }

        public Contact FindById(int? id)
        {
            return _contactRepository.FindById(id);
        }
        public int Edit(Contact contact)
        {
            return _contactRepository.Edit(contact);
        }

        public int Delete(Contact contact)
        {
            return _contactRepository.Delete(contact);
        }
    }
}
