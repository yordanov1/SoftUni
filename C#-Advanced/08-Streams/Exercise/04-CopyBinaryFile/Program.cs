using System;
using System.IO;

namespace Exer_04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string picDirectory = "../../../copyMe.png";
            string picCopyDirectory = "../../../copyMe-new.png";

            using (var reader = new FileStream(picDirectory, FileMode.Open))
            {
                using (var writer = new FileStream(picCopyDirectory, FileMode.Create))
                {
                    while (true)
                    {
                        var buffer = new byte[4096];

                        int size = reader.Read(buffer, 0, buffer.Length);

                        if (size == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, size);
                    }
                }
            }
        }
    }
}
