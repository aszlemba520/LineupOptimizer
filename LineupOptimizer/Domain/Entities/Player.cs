using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineupOptimizer.Entities
{
    class Player : IBaseEntity
    {
        public Guid Id { get; set; }

        public Guid OwnerId { get; set; }
    }
}
