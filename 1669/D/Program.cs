using System;
using System.Collections.Generic;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int n;
            string input;
            List<string> ans = new List<string>();
            for (int i = 0; i < t; i++)
            {
                n = int.Parse(Console.ReadLine());
                input = Console.ReadLine();
                int countRed = 0, CountBlue = 0;
                bool flag = true;
                for (int j = 0; j < n; j++)
                {
                    if (input[j] == 'R')
                        countRed++;
                    
                    else if (input[j] == 'B')                  
                        CountBlue++;
                    
                    else
                    {
                        if((countRed > 0 && CountBlue == 0) || (countRed == 0 && CountBlue > 0))
                            flag = false;
                        
                        countRed = 0;
                        CountBlue = 0;
                    }
                }
                if ((countRed > 0 && CountBlue == 0) || (countRed == 0 && CountBlue > 0))
                    flag = false;
                
                if (flag)
                    ans.Add("YES");
                else
                    ans.Add("NO");
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
