using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace StringWiterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            StringReadWrite SRW = new StringReadWrite();
        }

        public class StringReadWrite
        {
            StringBuilder StringB = new StringBuilder();

            public StringReadWrite()
            {
                WriteData();
                ReadData();
            }

            #region "WriteData" 
            public void WriteData()
            {
                StringWriter StringW = new StringWriter(StringB);

                Console.WriteLine("Please enter your first name and last name...");
                string name = Console.ReadLine();

                StringW.WriteLine($"Name: {name}");

                StringW.Flush();

                StringW.Close();
            }
            #endregion


            #region "ReadData"
            public void ReadData()
            {
                StringReader StringR = new StringReader(StringB.ToString());
                Console.WriteLine("Reading the information...");

                while (StringR.Peek() > -1)
                {
                    Console.WriteLine(StringR.ReadLine());


                }

                Console.WriteLine("Thank you for using my program.");

                StringR.Close();
            }
            #endregion
        }

    }
}
