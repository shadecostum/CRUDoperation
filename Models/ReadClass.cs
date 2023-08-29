using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDoperation.Models
{
    internal class ReadClass
    {
        public void ReadFunction()
        {
            foreach (var item in ListStatic.staticList)
            {
                Console.WriteLine("Name = "+item.Name + ",ID = " + item.Id);
            }

        }
    }
}
