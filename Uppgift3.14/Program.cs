

namespace Uppgift_3._14
{
    class Program
    {
        static void Main(string[]args)
        {
            {
                Console.WriteLine("hur gammal är du? (år)");
                double år = double.Parse(Console.ReadLine());

                if (år >= 0 && år <= 22)
                {
                    Console.WriteLine("en fråga till");
                }
                
            }
            Console.WriteLine("Har du gått ut gymnasiet? j för ja och n för nej");
            string gymnasiet=Console.ReadLine();

            switch(gymnasiet)
            {
                case "n":
                    Console.WriteLine("vi leter tyvär efter annnan personal just nu");
                break;
                case "j":
                    Console.WriteLine("Vi vill gärna anstålla dig");
                break;
                  


            }
        }
    }
}
