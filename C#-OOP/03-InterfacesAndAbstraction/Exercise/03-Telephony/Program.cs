using Exer_03.Telephony.Contracts;
using Exer_03.Telephony.Core;
using Exer_03.Telephony.IO;
using System;

namespace Exer_03.Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);

            engine.Run();

        }
    }
}
