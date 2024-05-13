using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Productivity : IEntity
    {
        public int ProductivityId { get; set; }
        public int ElectricConsumption { get; set; }
        public DateTime Date { get; set; }
        public int Temperature { get; set; }
        public int ProductQuantity { get; set; }
        public int Carbondioxide { get; set; }
        public int ProductRequireProduced { get; set; }
    }
}