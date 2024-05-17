using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InMemeoryCarDal : ICarDal
    {
        List<Cars> _cars;

        public InMemeoryCarDal()
        {
            _cars = new List<Cars>
            {
                new Cars{ Id=1,BrandId=1,ModelYear=2012, ColorId=010, DailyPrice=1000000, Description="Sahibinden hatasız boyasız 100bin kmde"},
                new Cars{ Id=2,BrandId=1,ModelYear=2019, ColorId=001, DailyPrice=746000, Description="Sahibinden hatasız boyasız 11bin kmde"},
                new Cars{ Id=3,BrandId=2,ModelYear=2017, ColorId=110, DailyPrice=360000, Description="Sahibinden hatasız boyasız 96bin kmde"},
                new Cars{ Id=4,BrandId=2,ModelYear=2002, ColorId=111, DailyPrice=265000, Description="Sahibinden hatasız boyasız 400bin kmde"}
            };
        }

        public void Add(Cars car)
        {
            _cars.Add(car);
        }

        public void Delete(Cars car)
        {
            Cars carToDelete = _cars.SingleOrDefault(c=> c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Cars> GetAll()
        {
            return _cars;
        }

        public List<Cars> GetById(Cars car)
        {
            return _cars.Where(c=> c.Id==car.Id).ToList();
        }

        public void Update(Cars car)
        {
            
        }
    }
}
