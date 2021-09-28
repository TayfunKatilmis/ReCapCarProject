using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Post(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {
            
            var result = _carService.GetById(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpDelete]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Car car)
        {
            
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcarsbybrandid")]
        public IActionResult GetCarsByBrandId(int id)
        {
            var result = _carService.GetCarsByBrandId(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }
        [HttpGet("getcarsbycolorid")]
        public IActionResult GetCarsByColorId(int id)
        {
            var result = _carService.GetCarsByColorId(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }
        [HttpGet("getcarsbycolorandbrand")]
        public IActionResult GetCarsByColorAndBrand(int brandId,int colorId)
        {
            var result = _carService.GetCarsByColorAndBrand(brandId, colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcarsbycarid")]
        public IActionResult GetCarsByCarId(int id)
        {
            var result = _carService.GetCarsByCarId(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }


        [HttpGet("getcarsbycolorname")]
        public IActionResult GetCarsByColorName(string name)
        {
            var result = _carService.GetCarsByColorName(name);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("getcarsbybrandname")]
        public IActionResult GetCarsByBrandName(string name)
        {
            var result = _carService.GetCarsByBrandName(name);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("getcarrename")]
        public IActionResult GetCarRename()
        {
            var result = _carService.GetCarRename();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
