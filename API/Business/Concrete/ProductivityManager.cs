using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Utilites.Results;
using Utilities.Messages;
using Utilities.Results;


namespace Business.Concrete
{
    public class ProductivityManager : IProductivityService
    {
        private IProductivityDal _productivityDal;

        public ProductivityManager(IProductivityDal productivityDal)
        {
            _productivityDal = productivityDal;
        }
        public IResult Add(Productivity productivity)
        {
            _productivityDal.Add(productivity);
            return new SuccessResult(Messages.ProductivityAdded);
        }

        public IDataResult<double> CalculateEnergyDensity(int ElectricConsumption, int ProductQuantity)
        {
            return new SuccessDataResult<double>(_productivityDal.CalculateEnergyDensity(ElectricConsumption, ProductQuantity));
        }

        public IDataResult<double> CalculateEnergyEfficiency(int ElectricConsumption, int ProductQuantity)
        {
            return new SuccessDataResult<double>(
                _productivityDal.CalculateEnergyEfficiency(ElectricConsumption, ProductQuantity));
        }

        public IDataResult<double> CalculateEnergyEfficiencyChange(EnergyEfficiencyChange energyEfficiencyChange)
        {
            return new SuccessDataResult<double>(_productivityDal.CalculateEnergyEfficiencyChange(energyEfficiencyChange));
        }

        public IResult Delete(Productivity productivity)
        {
            _productivityDal.Delete(productivity);
            return new SuccessResult(Messages.ProductivityDeleted);
        }

        public IDataResult<double> EnergyUseEfficiency(int ElectricConsumption, int ProductRequireProduced)
        {
            return new SuccessDataResult<double>(
                _productivityDal.EnergyUseEfficiency(ElectricConsumption, ProductRequireProduced));
        }

        public IDataResult<List<Productivity>> GetList()
        {
            return new SuccessDataResult<List<Productivity>>(_productivityDal.GetList().ToList());
        }

        public IResult Update(Productivity productivity)
        {
            _productivityDal.Update(productivity);
            return new SuccessResult(Messages.ProductivityUpdated);
        }
    }
}
