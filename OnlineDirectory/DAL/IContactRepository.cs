using System.Collections.Generic;

namespace OnlineDirectory.DAL
{
    public interface IContactRepository<T>
    {
        int Create(T t);
        int Edit(T t);
        int Delete(T t);
        IEnumerable<T> FindAll();
        T FindById(int? id);
    }
}
