using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilites.Results;



namespace Business.Abstract
{
    public interface IProductivityService
    {
        IResult Add(Productivity productivity);
        IResult Update(Productivity productivity);
        IResult Delete(Productivity productivity);
        IDataResult<List<Productivity>> GetList();
        //List<Productivity>GetListBy
        IDataResult<double> CalculateEnergyDensity(int electricConsumption, int productQuantity);
        IDataResult<double> CalculateEnergyEfficiency(int electricConsumption, int productQuantity);
        IDataResult<double> EnergyUseEfficiency(int electricConsumption, int productRequireProduced);
        IDataResult<double> CalculateEnergyEfficiencyChange(EnergyEfficiencyChange energyEfficiencyChange);

    }
}