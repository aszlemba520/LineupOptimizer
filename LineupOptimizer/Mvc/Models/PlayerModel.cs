using LineupOptimizer.Domain.Services;
using System;

namespace LineupOptimizer.Models
{
    public class PlayerModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string IdString { set { Id = DataTypeConverter.StringToInt(value); } }
        public string Position { get; set; }
        public bool IsActive { get; set; }
        public string IsActiveString { set { IsActive = DataTypeConverter.StringToBool(value); } }
        public string Team { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public int JerseyNumber { get; set; }
        public string JerseyNumberString { set { JerseyNumber = DataTypeConverter.StringToInt(value); } }
        public string DOB { get; set; }
    }
}
