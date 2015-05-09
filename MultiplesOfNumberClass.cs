using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MultiplesOfNumber
{
    class MultiplesOfNumberClass
    {
        static void Main(string[] args)
        {
            const char DELIM = ',';
            String[] numbers;
            int x = 0;
            int n = 0;

            using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string nextLine = reader.ReadLine();
                if (null == nextLine)
                    continue;
                else
                {
                    numbers = nextLine.Split(DELIM);
                    if (int.TryParse(numbers[0], out x))
                    {
                        n = int.Parse(numbers[1]);
                        int greatestMultiple = n;

                        int acummulator = greatestMultiple;
                        while (x > greatestMultiple)
                        {
                            greatestMultiple += acummulator;
                        }

                        Console.WriteLine(greatestMultiple);
                    }
                }
              
            }
        }
    }
}
