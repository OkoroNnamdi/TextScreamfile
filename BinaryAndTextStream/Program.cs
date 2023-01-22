using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryAndTextStream
{
    class Program
    {

        static void Write(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create,FileAccess.Write);
            if (fs.CanWrite)
            {
                byte[] buffer = Encoding.ASCII.GetBytes("Hello World");
                fs.Write(buffer, 0 ,buffer.Length);
            }
            fs.Flush();
            fs.Close();
        }
        static void Read(string filename)
        {

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            if (fs.CanRead)
            {
                byte[] buffer = new byte[fs.Length];
                int readByte = fs.Read(buffer, 0, buffer.Length);
                Console.WriteLine(Encoding.ASCII.GetString(buffer, 0, readByte));
            }
             
            //fs.Read ()
        }
        static void Main(string[] args)
        {
            string filename = "";
            Write(filename);
            Read(filename);
            Console.Read();
        }
    }
}
