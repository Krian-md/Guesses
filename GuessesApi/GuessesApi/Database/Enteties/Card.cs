using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessesApi.Database.Enteties
{
    public class Card : BaseEntity
    {
        public string WordEn { get; set; }
        public string WordRu { get; set; }
        public string Url { get; set; }
        public string Transcript { get; set; }
    }
}
