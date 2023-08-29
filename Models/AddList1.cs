using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDoperation.Models
{
    internal class AddList1
    {
     
       public int No { get; set; }
        public string FName { get; set; }

        public AddList1(int id, string name)
        {
            No = id;
            FName = name;
        }   

        public void AddFunction() 
        {
            ListStatic.staticList.Add(new ListArray{ Id = No,Name=FName });
        }

     
    }
}
