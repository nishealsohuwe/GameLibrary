using System;
using System.Collections.Generic; 

namespace GameLibrary.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string developer { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
    }
}
