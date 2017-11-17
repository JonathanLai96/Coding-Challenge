using System;

namespace CODING_CHALLENGES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!!!!!!!!!!!!!!!");
            int[] scores = new int[] {100,200,300};
            foreach(int i in scores)
            {
                Console.WriteLine(i);
            }
            dictionaryHelper test = new dictionaryHelper("what");
            Console.WriteLine(test.matched); 
        }
    }


}
