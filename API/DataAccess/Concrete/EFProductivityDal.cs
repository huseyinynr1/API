using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.EntityFramework;

namespace DataAccess.Concrete
{
    public class EFProductivityDal : EFEntityRepositoryBase<Productivity, EnergyContext>, IProductivityDal
    {
        public double CalculateEnergyDensity(int ElectricConsumption, int ProductQuantity)
        {
            return (ElectricConsumption / ProductQuantity);
        }

        public double CalculateEnergyEfficiency(int ElectricConsumption, int ProductQuantity)
        {
            return (ProductQuantity / ElectricConsumption);
        }

        public double CalculateEnergyEfficiencyChange(EnergyEfficiencyChange energyEfficiencyChange)
        {//Burada filter yapmam gerekiyor. Kullanıcının istediği zaman aralığını buraya bildirmem gerekiyor.
            return ((energyEfficiencyChange.FinalEfficiency - energyEfficiencyChange.InitialEfficiency) /
                (energyEfficiencyChange.InitialEfficiency) * 100);
        }

        public double EnergyUseEfficiency(int ElectricConsumption, int ProductRequireProduced)
        {
            return (ProductRequireProduced / ElectricConsumption);
        }
    }
}