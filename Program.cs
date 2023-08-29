using CRUDoperation.Models;

namespace CRUDoperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            while (true)
            {
                Console.WriteLine("Choose \n1.Create\n2.Read\n3.Update\n4.Delete\n5.Exit  ");
                 int choose= Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("+++++++++++============++++++++++");

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("enter the id");
                        int idPerson = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("enter the Name");
                        string namePerson = Console.ReadLine();

                        AddList1 addList1 = new AddList1(idPerson,namePerson);
                        addList1.AddFunction();
                       
                        Console.WriteLine("+++++++++++============++++++++++");
                        break;
                        case 2:
                        ReadClass readClass = new ReadClass();
                        readClass.ReadFunction();
                        Console.WriteLine("+++++++++++================+++++++++");

                        break;
                        case 3:
                        UpdateList updateList = new UpdateList();
                        Console.WriteLine("+++++++++++================+++++++++");
                        Console.WriteLine();
                            
                        break;
                        case 4:
                        DeletList deletList = new DeletList();
                        Console.WriteLine("+++++++++++================+++++++++");
                        Console.WriteLine();
                        break;
                        case 5:return;
                        default: Console.WriteLine("invalid");
                        break;
                }
            }
            
        }
    }
}