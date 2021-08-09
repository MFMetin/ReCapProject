using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentDal : EfEntityRepositoryBase<Rental, ReCapDBContext>, IRentalDal
    {
        public List<RentCarDetailDto> GetRentDetails()
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id

                             select new RentCarDetailDto
                             {
                                CarId = c.Id,
                                CustomerId = r.CustomerId,
                                RentDate = r.RentDate,
                                Id = r.Id,
                                ReturnDate = r.ReturnDate                               
                                 
                             };


                return result.ToList();
            }
        }
    }
}
