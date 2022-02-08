using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessesApi.Database.Enteties
{
    public class RightWrongCard : BaseEntity
    {
        public bool IsRight { get; set; }
        public int ResultId { get; set; }
        public Result ResultGame { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
    }
}
