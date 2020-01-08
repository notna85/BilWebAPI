using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilWebAPI.Interfaces
{
    interface IRepository<T>
    {
        void Add(T t);
        void Remove(T t);
        void Update(T t);
        T GetByID(int id);
    }
}
