using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    internal interface IRepositoryUpdate<T>
    {
        void Update(Guid id,T obj);
    }
}
