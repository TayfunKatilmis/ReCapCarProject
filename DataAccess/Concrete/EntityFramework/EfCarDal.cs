using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DatabaseContext>, ICarDal
    {

        public List<CarDetailDto> GetCarsByCarId(Expression<Func<CarDetailDto, bool>> filter)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join clr in context.Colors
                             on c.ColorId equals clr.ColorId
                             join cimg in context.CarImages
                             on c.CarId equals cimg.CarId
                             select new CarDetailDto { Id = c.CarId,ColorId=clr.ColorId,BrandId=b.BrandId ,BrandName = b.Name, CarName=c.CarName,DailyPrice = c.DailyPrice, Description = c.Description, ColorName = clr.Name, ModelYear = c.ModelYear, CarImages=cimg.ImagePath };
                return filter == null
                    ? result.ToList() : result.Where(filter).ToList();
            }

        }

        public List<CarRenameDto> GetCarRename(Expression<Func<CarRenameDto,bool>> filter=null)
        {
            using (DatabaseContext context= new DatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join cimg in context.CarImages
                             on c.CarId equals cimg.CarId
                             select new CarRenameDto { Id = c.CarId, BrandName = b.Name, CarName = c.CarName, ColorName = co.Name, DailyPrice = c.DailyPrice, Description = c.Description, ModelYear = c.ModelYear, CarImages=cimg.ImagePath };
                return filter==null
                    ? result.ToList():result.Where(filter).ToList();
            }
        }
    }
}
