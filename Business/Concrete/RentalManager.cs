using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {

        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentdal)
        {
            _rentalDal = rentdal;
        }
        public IResult Add(Rental rental)
        {
         
            bool available = true;

            foreach (var item in _rentalDal.GetRentDetails())
            {
                if(item.CarId == rental.CarId && item.ReturnDate == null)
                {
                    available = false;
                }                              
            }
            if (available)
            {
                _rentalDal.Add(rental);
            return new SuccessResult(Messages.CarRented);
            }
            
            return new ErrorResult(Messages.CarNotAvailable);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<RentCarDetailDto>> GetRentDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
