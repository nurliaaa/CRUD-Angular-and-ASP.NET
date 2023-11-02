using System;
using System.Collections.Generic;

#nullable disable

namespace Angular2.Models
{
    public partial class Positions
    {
        public Positions()
        {
            Players = new HashSet<Players>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? DisplayOrder { get; set; }

        public virtual ICollection<Players> Players { get; set; }
    }
}
