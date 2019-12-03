using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ReadFileName = @"C:\Users\91943\Desktop\MyLearning\BYTE_STREAM_POC\Songs\Move On - Inder Chahal.mp3";

            string CreatingFilePath = @"C:\Users\91943\Desktop\MyLearning\BYTE_STREAM_POC\Songs\copiedSongs.mp3";
            

            

            //Delete if Already Existing file
            if(File.Exists(CreatingFilePath))
                File.Delete(CreatingFilePath);

            FileStream fileStreamForReading = new FileStream(ReadFileName, FileMode.Open, FileAccess.Read);

            FileStream fileStream = new FileStream(CreatingFilePath, FileMode.Create);

            BinaryReader br = new BinaryReader(fileStreamForReading);
            while (true) {
    
                byte[] b = br.ReadBytes(1000);

                Console.WriteLine(b.Length);

                if (b.Length == 0)
                    break;

                for (int i = 0; i < b.Length; i++)
                {
                    fileStream.WriteByte(b[i]);
                }
            }
           // Console.WriteLine(bytes.Length);
            Console.ReadLine();


        }
    }
}
