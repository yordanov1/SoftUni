using Exer_03.ShoppingSpree.Core;
using System;

namespace Exer_03.ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                Engine engine = new Engine();
                engine.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
