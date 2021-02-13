using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Luke_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFileContent = File.ReadAllText(@"C:\Users\matth\OneDrive\Desktop\numbers.txt", Encoding.UTF8);
            var list = textFileContent.Split(",").ToList();
            var num = new List<int>();
            foreach (var el in list)
                num.Add(Convert.ToInt32(el));
            num = num.OrderBy(x => x).ToList();

            int answer = -1;

            for(int index = 0; index < num.Count; index++)
            {
                if(index + 1 != num[index])
                {
                    answer = index + 1;
                    break;
                }
            }



            Console.WriteLine(answer);


            Console.ReadKey();



        }
   
    }
}
