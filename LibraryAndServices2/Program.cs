using MyClassLibrary;
using MyClassLibrary.Services;

namespace LibraryAndServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data.SeedData();
            bool run = true;
            var customerService = new CustomerService();
            while (run)
            {
                Console.Clear();
                Console.WriteLine("1: Create a customer");
                Console.WriteLine("2: Read a customer (with Id)");
                Console.WriteLine("3: Read all customers");
                Console.WriteLine("4: Update a customer");
                Console.WriteLine("5: Delete a customer");
                Console.WriteLine("0: Exit");
                Console.Write("\nInput: ");
                var userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        customerService.Create();
                        break;
                    case 2:
                        Console.WriteLine("Id of customer: ");
                        var cIdReadOne = Convert.ToInt32(Console.ReadLine());
                        var readOne = customerService.ReadOne(cIdReadOne);
                        if (readOne != null)
                        {
                            Console.WriteLine(
                            $"{readOne.CustomerId}: {readOne.Name}, {readOne.Email}");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        var customers = customerService.ReadAll();
                        foreach (var c in customers)
                        {
                            Console.WriteLine(
                                $"{c.CustomerId}: {c.Name}, {c.Email}");
                        }
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Id of customer you want to update: ");
                        var cIdUpdate = Convert.ToInt32(Console.ReadLine());
                        customerService.Update(cIdUpdate);
                        break;
                    case 5:
                        Console.WriteLine("Id of customer you want to delete: ");
                        var cIdDelete = Convert.ToInt32(Console.ReadLine());
                        customerService.Delete(cIdDelete);
                        break;
                    case 0:
                        run = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}