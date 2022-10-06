using System;
namespace uppgift_3_14
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet?");
            Console.WriteLine("svara j eller n");
            string svar = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            string x = Console.ReadLine();
            int a = int.Parse(x);
            if (svar == "j" && a < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig.");
            }
            else
            {
                Console.WriteLine("Vi letar tyvär efter annan personal just nu.");
            }










        }
    }
}
