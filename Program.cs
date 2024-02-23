using System;

namespace HelloWorld 
{
    class Programs
    {
        static void Main(string[] args)
        {
            int a,b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter two number : "+a+" "+b);
            
            Console.WriteLine("{0}+{1}={2}",a,b,a+b);
            Console.WriteLine("{0}-{1}={2}",a,b,a-b);
            Console.WriteLine("{0}*{1}={2}",a,b,a*b);
            Console.WriteLine("{0}/{1}={2}",a,b,a/b);
	        
          
            
        }
    }
}