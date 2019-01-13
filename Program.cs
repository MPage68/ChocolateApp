using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateApp
{
    class Program
    {  
       
        static void Main(string[] args)
        {
            Console.WriteLine("Let's make something with chocolate. ");
            Console.Write("How many pounds should we use ?  ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();           
            int big = 10;
            int med = 5;
            int sm = 1;           
            int bigbar = 0;
            int medbar = 0;
            int smbar = 0;

            while(amt > 0)
            {                
                if(amt >= big)
                {
                    bigbar = amt / big;
                    amt = amt - (bigbar * big);
                    Console.WriteLine("We're going to need " + bigbar + " big bars");
                } 
                else if(amt >= med)
                {
                    medbar = amt / med;
                    amt = amt - (medbar * med);
                    Console.WriteLine("We're going to need " + medbar + " medium bars");
                }
                else if(amt >= sm)
                {
                    smbar = amt / sm;
                    amt = amt - (smbar * sm);
                    Console.WriteLine("We're going to need " + smbar + " small bars");
                }
                else
                {
                    Console.WriteLine("Let's start cooking!");
                }
            }
                    Console.ReadLine();           
        }
    }
}
