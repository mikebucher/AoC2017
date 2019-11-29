using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2017_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string strReadFile = @"C:\Dev\AoC2017\Day2Input1.txt";
            string[] separator = { "\t" };
            int result = 0;
            
            var fileLines = File.ReadAllLines(strReadFile).ToList();
            
            foreach (string line in fileLines)
            {
                List<int> temp = line.Substring(0).Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();


                //step 1
                //result += (temp.Max(x => x) - temp.Min(x => x));

                //step 2
                //find the only two numbers that are divisible by each other
                for (int i = 0; i < temp.Count; i++)
                {
                    for (int j = 0; j < temp.Count; j++)
                    {
                        if(i != j)
                        {
                            if(temp[i] % temp[j] == 0)
                            {
                                if (temp[i] > temp[j])
                                {
                                    result += temp[i] / temp[j];
                                }
                                else
                                {
                                    result += temp[j] / temp[i];
                                }
                            }
                        }
                    }
                }

                here:;
            }

            Console.WriteLine("result: " + result);
            Console.ReadKey();
        }
    }
}
