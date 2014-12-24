using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Rohit\Desktop\RMHP Documents\DocumentParser11thNov\DocumentParser\DocumentParser\DocumentParserClient\Input\roc02_t112_test_20141008.dat";

            string[] lines = File.ReadAllLines(filePath);
            string[] resLines = new string[15];

            //resLines = resLines.Reverse<string>().ToArray();
            int count=0;

            foreach (var line in lines.Reverse<string>())
            {
                //int length = line.Length;

                if (count < 15 )
                {
                    if (line.Length >= 5116)
                    {
                        resLines[count] = line;
                        count++;
                    }
                }
                else
                    break;
            }

            File.WriteAllLines("SmallTestClaimFile_T112_Test.dat", resLines);
        }
    }
}
