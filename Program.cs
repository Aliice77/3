using System;

namespace session1
{
    class Program
    {

        static void Main(string[] args)
        {
            int a;
            int b=0;
            Console.WriteLine("enter a number");
            a=Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=a;i++)
            {
                if(i%2!=0)
                {
                    b=b+i;
                }
            }
            Console.WriteLine(b);
          
        }
    }
    
}
