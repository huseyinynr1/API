using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductivityDal : IEntityRepository<Productivity>
    {
        double CalculateEnergyDensity(int ElectricConsumption, int ProductQuantity);
        double CalculateEnergyEfficiency(int ElectricConsumption, int ProductQuantity);
        double EnergyUseEfficiency(int ElectricConsumption, int ProductRequireProduced);
        double CalculateEnergyEfficiencyChange(EnergyEfficiencyChange energyEfficiencyChange);

    }
}