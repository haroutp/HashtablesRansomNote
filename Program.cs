using System;
using System.Collections;

namespace HashtablesRansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // Complete the checkMagazine function below.
        static void checkMagazine(string[] magazine, string[] note)
        {
            Hashtable magWordCount = new Hashtable();
            foreach(string item in magazine)
            {
                if(!magWordCount.ContainsKey(item)){
                    magWordCount.Add(item, 1);
                    continue;
                }
                magWordCount[item] = (int)magWordCount[item] + 1;
            }

            foreach (var item in note)
            {
                if(magWordCount.ContainsKey(item) && (int)magWordCount[item] != 0){
                    magWordCount[item] = (int)magWordCount[item] - 1;
                    continue;
                }
                System.Console.WriteLine("No");
                return;
            }
            System.Console.WriteLine("Yes");
        }
    }
}
