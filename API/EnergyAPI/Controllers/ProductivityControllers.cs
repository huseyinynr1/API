using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace EnergyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductivityControllers : ControllerBase
    {
        private IProductivityService _productivityService;

        public ProductivityControllers(IProductivityService productivityService)
        {
            _productivityService = productivityService;
        }

        [HttpGet(template: "GetList")]
        public IActionResult GetList()
        {
            var result = _productivityService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpGet(template: "Calculate-Energy-Efficiency")]
        public IActionResult CalculateEnergyEfficiency(int electricConsumption, int productQuantity)
        {
            var result = _productivityService.CalculateEnergyEfficiency(electricConsumption, productQuantity);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost(template: "Added")]
        public IActionResult Add(Productivity productivity)
        {
            var result = _productivityService.Add(productivity);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }
        [HttpPost(template: "Deleted")]
        public IActionResult Delete(Productivity productivity)
        {
            var result = _productivityService.Delete(productivity);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }
        [HttpPost(template: "Updated")]
        public IActionResult Update(Productivity productivity)
        {
            var result = _productivityService.Update(productivity);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }

        [HttpPost]
        public IActionResult CalculateEnergyEfficiencyChange(EnergyEfficiencyChange energyEfficiencyChange)
        {
            var result = _productivityService.CalculateEnergyEfficiencyChange(energyEfficiencyChange);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpGet(template: "CalculateEnergyDensity")]
        public IActionResult CalculateEnergyDensity(int electricConsumption, int productQuantity)
        {
            var result = _productivityService.CalculateEnergyDensity(electricConsumption, productQuantity);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpGet(template: "EnergyUseEfficiency")]
        public IActionResult EnergyUseEfficiency(int electricConsumption, int productRequireProduced)
        {
            var result = _productivityService.EnergyUseEfficiency(electricConsumption, productRequireProduced);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
    }
}
