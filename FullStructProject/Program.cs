using System.Text;

namespace FullStructProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Day la \" 1 dong\" j do");
            Console.WriteLine("Random thing go fr fr");
            Console.WriteLine("Doi so dau vao:");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);

            }
                Console.ReadLine(); 
        }
    }
}