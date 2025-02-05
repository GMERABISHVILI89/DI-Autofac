using DemoLibrary;

namespace DI_AutofacTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic businessLogic = new BusinessLogic();
            businessLogic.ProcessData();
            Console.ReadLine();
        }
    }
}
