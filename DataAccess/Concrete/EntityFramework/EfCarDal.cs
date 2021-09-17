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

        public List<CarDetailDto> GetCarDetails()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join clr in context.Colors
                             on c.ColorId equals clr.Id
                             join cimg in context.CarImages
                             on c.Id equals cimg.CarId
                             select new CarDetailDto { Id = c.Id, BrandName = b.Name, CarName=c.CarName,DailyPrice = c.DailyPrice, Description = c.Description, ColorName = clr.Name, ModelYear = c.ModelYear, CarImages=cimg.ImagePath };
                return result.ToList();
            }

        }

        public List<CarRenameDto> GetCarRename()
        {
            using (DatabaseContext context= new DatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarRenameDto { Id = c.Id, BrandName = b.Name, CarName = c.CarName, ColorName = co.Name, DailyPrice = c.DailyPrice, Description = c.Description, ModelYear = c.ModelYear };
                return result.ToList();
            }
        }
    }
}
