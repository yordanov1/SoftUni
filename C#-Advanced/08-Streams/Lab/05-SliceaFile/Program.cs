﻿using System;
using System.IO;

namespace Lab_05.SliceaFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream streamReader = new FileStream("../../../text.txt",
                FileMode.Open))
            {
                int chunkSize = (int)streamReader.Length / 4;

                for (int i = 0; i < 4; i++)
                {
                    byte[] buffer = new byte[1];
                    int count = 0;

                    using (FileStream streamWriter = new FileStream($"../../../slice-" +
                        $"{i + 1}.txt", FileMode.Create, FileAccess.Write))
                    {
                        while (count < chunkSize)
                        {
                            streamReader.Read(buffer, 0, buffer.Length);
                            streamWriter.Write(buffer, 0, buffer.Length);

                            count += buffer.Length;
                        }

                        //if (streamReader.Position != streamReader.Length && i == 3)
                        //{
                        //    int remainingBytes = (int)streamReader.Length -(int)streamReader.Position;
                        //    byte[] lastBuffer = new byte[remainingBytes];
                        //    streamReader.Read(lastBuffer, 0 , remainingBytes);
                        //    streamWriter.Write(lastBuffer, 0, lastBuffer.Length);
                        //}
                        //- пишем този код ако искаме да сложим остатъка в последния фаил.

                    }
                }               
            }
        }
    }
}
