using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface ICarDal
    {
        void Add(Cars car);
        void Update(Cars car);
        void Delete(Cars car);



        List<Cars> GetAll();

        List<Cars> GetById(Cars car);
    }
}
