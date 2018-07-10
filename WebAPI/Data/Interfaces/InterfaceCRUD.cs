using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Interfaces
{

    interface InterfaceCRUD<T> where T : class
    {

        IEnumerable<T> Get();
        T Get(int id);
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
    }
}
 
