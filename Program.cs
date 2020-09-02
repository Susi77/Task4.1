using System;

namespace MobiHier
{
    class Program
    {
        static void Main(string[] args)
        {

            //Apple 

            Console.WriteLine("Apple ");
            Console.WriteLine("----------------");

            var i = new Apple();
            Console.WriteLine(i.OperationSystem());
            Console.WriteLine(i.SIM());
            Console.WriteLine(i.Camera());
            Console.WriteLine(i.InternalMemory());
            Console.WriteLine(i.RAM());
            Console.WriteLine(i.CPU());
            Console.WriteLine();

            Console.WriteLine("Iphone 9");
            Console.WriteLine("----------------");

            var ip = new Iphone9();
            Console.WriteLine(ip.OperationSystem());
            Console.WriteLine(ip.SIM());
            Console.WriteLine(ip.Camera());
            Console.WriteLine(ip.InternalMemory());
            Console.WriteLine(ip.RAM());
            Console.WriteLine(ip.CPU());
            Console.WriteLine(ip.Chip());

            Console.WriteLine();

            //Nokia , Nokia x6

            Console.WriteLine("Nokia ");
            Console.WriteLine("----------------");

            var n = new Nokia();
            Console.WriteLine(n.OperationSystem());
            Console.WriteLine(n.SIM());
            Console.WriteLine(n.Camera());
            Console.WriteLine(n.InternalMemory());
            Console.WriteLine(n.RAM());
            Console.WriteLine(n.CPU());
            Console.WriteLine();

            Console.WriteLine("Nokia x6 ");
            Console.WriteLine("----------------");

            var no = new Nokia.NokiaX6();
            Console.WriteLine(no.OperationSystem());
            Console.WriteLine(no.SIM());
            Console.WriteLine(no.Camera());
            Console.WriteLine(no.InternalMemory());
            Console.WriteLine(no.RAM());
            Console.WriteLine(no.CPU());
            Console.WriteLine(no.UsePrivateMember());
            Console.WriteLine();

            //Xiaomi ,Xiaomi Note 9s
            Console.WriteLine("Xiaomi ");
            Console.WriteLine("----------------");

            var x = new Xiaomi();
            Console.WriteLine(x.OperationSystem());
            Console.WriteLine(x.SIM());
            Console.WriteLine(x.Camera());
            Console.WriteLine(x.InternalMemory());
            Console.WriteLine(x.RAM());
            Console.WriteLine(x.CPU());
          
            Console.WriteLine();

            Console.WriteLine("Xiaomi Note 9s   ");
            Console.WriteLine("----------------");

            var xi = new Note9s();
            Console.WriteLine(xi.OperationSystem());
            Console.WriteLine(xi.SIM());
            Console.WriteLine(xi.Camera());
            Console.WriteLine(xi.InternalMemory());
            Console.WriteLine(xi.RAM());
            Console.WriteLine(xi.CPU());
            Console.WriteLine(xi.UseProtectedMember());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
