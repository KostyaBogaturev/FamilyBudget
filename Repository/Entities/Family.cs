using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    class Family
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Budget { get; set; }

        public IEnumerable<Guid> UserId { get; set; }
    }
}
