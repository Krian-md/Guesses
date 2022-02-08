using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessesApi.Database.Enteties
{
    public class Result : BaseEntity
    {
        public string Name { get; set; }
        public string ResultGame { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
