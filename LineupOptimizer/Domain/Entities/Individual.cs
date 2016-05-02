using System;
using System.Web.Mvc;

namespace LineupOptimizer.Entities
{
    [Bind(Include = "ind_key")]
    class Individual : IBaseEntity
    {        
        public Guid Id{ get; set; }
    }
}
