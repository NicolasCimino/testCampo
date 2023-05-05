using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cliente
    {
        public Guid id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public Cliente() { }
    }
}
