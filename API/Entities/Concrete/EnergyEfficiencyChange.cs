using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class EnergyEfficiencyChange : IEntity
    {
        public int EnergyEfficiencyChangeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float InitialEfficiency { get; set; }
        public float FinalEfficiency { get; set; }

        public EnergyEfficiencyChange(DateTime startDate, DateTime endDate, float initialEfficiency, float finalEfficiency)
        {
            StartDate = startDate;
            EndDate = endDate;
            InitialEfficiency = initialEfficiency;
            FinalEfficiency = finalEfficiency;
        }
    }
}