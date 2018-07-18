using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineDirectory.BLL
{
    public interface IContactService<T>
    {
        int Create(T t);
        int Edit(T t);
        int Delete(T t);
        IEnumerable<T> FindAll();
        T FindById(int? id);
    }
}
