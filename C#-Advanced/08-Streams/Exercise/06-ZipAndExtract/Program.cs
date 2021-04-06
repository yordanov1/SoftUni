using System;
using System.IO;
using System.IO.Compression;

namespace Exer_06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string zipFile = "../../../result.zip";
            string picPath = "../../../copyMe.png";

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(picPath, Path.GetFileName(picPath));
            }

            ZipFile.ExtractToDirectory("../../../result.zip", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            // -> картинката е в директорията на прохграмата.
            // -> прави zip фаила в директориата на програмата.
            // -> разархивира zip фаила на Декстопа.
        }
    }
}
