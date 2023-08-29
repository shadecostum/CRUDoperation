using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDoperation.Models
{
    internal class DeletList
    {

        public DeletList() 
        {
            Console.WriteLine("Enter the Id to delete");
            int deletId=Convert.ToInt16( Console.ReadLine());

            ListArray deletingId=ListStatic.staticList.Find(ListArray=>ListArray.Id==deletId);
            if (deletingId != null )
            {
                ListStatic.staticList.Remove(deletingId);
            }
            else { Console.WriteLine("not found ID"); }


            foreach (var item in ListStatic.staticList)
            {
                Console.WriteLine("Name = " + item.Name + ",ID = " + item.Id);
            }
        }
    }
}
