using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessesApi.Database.Enteties
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
