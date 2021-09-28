using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);

        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarsByColorAndBrand(int brandId,int colorId);
        IDataResult<List<CarRenameDto>> GetCarsByColorName(string name);
        IDataResult<List<CarRenameDto>> GetCarsByBrandName(string name);
        IDataResult<List<CarDetailDto>> GetCarsByCarId(int id);
        IDataResult<List<CarRenameDto>> GetCarRename();
    }
}
