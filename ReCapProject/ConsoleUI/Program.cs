using Business;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new InMemeoryCarDal());



            foreach (var product in carManager.GetAll())
            {
                Console.WriteLine(product.Description);
            }

            Console.ReadKey();









        }

       

    }

}
