using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    internal interface IRepositryInsert<T>
    {
        void Insert(T obj);
    }
}
