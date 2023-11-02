using System;
using System.Collections.Generic;

#nullable disable

namespace Angular2.Models
{
    public partial class Players
    {
        public int Id { get; set; }
        public int? ShirtNo { get; set; }
        public string Name { get; set; }
        public int? PositionId { get; set; }
        public int? Apperances { get; set; }
        public int? Goals { get; set; }

        public virtual Positions Position { get; set; }
    }
}
