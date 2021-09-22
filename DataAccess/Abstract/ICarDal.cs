using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarsByCarId(Expression<Func<CarDetailDto, bool>> filter);
        List<CarRenameDto> GetCarRename(Expression<Func<CarRenameDto,bool>> filter =null);
    }
}
