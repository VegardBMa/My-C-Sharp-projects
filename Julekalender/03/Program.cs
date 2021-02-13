using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace Luke_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "matrix";

            string[] wordList = new string[] {
             "nisseverksted",
             "pepperkake",
              "adventskalender",
              "klementin",
              "krampus",
              "juletre",
              "julestjerne",
              "gløggkos",
             "marsipangris",
             "mandel",
              "sledespor",
              "nordpolen",
              "nellik",
              "pinnekjøtt",
              "svineribbe",
              "lutefisk",
              "medisterkake",
              "grevinne",
              "hovmester",
              "sølvgutt",
              "jesusbarnet",
              "julestrømpem",
              "askepott",
              "rudolf",
              "akevitt"};

            int num = 1000;
            string[] lines = File.ReadAllText("matrix.txt", Encoding.UTF8).Split("\n");
            char[,] matrix = new char[num , num];
            var list = new List<(int lineNum, int linePostionNum)>();
            for (var line = 0; line < num; line++)
            {
                for (var linePosition = 0; linePosition < num; linePosition++)
                {
                    matrix[line, linePosition] = lines[line][linePosition];
                    foreach(string word in wordList)
                    {
                        if (word[0] == matrix[line, linePosition])
                        {
                            list.Add((line, linePosition));
                            break;
                        }
                    }
                }

            }

            for(int index = 0; index < list.Count; index++)
            {
                int lineNum = list[index].lineNum;
                int linePositionNum = list[index].linePostionNum;
                for (int index2 = 0; index < wordList.Length; index2++)
                {

                }
            }

        }
    
        
    
    
    }
}