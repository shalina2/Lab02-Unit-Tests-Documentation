using System;

namespace LAB02unittest
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Shalom Bank");
            Console.Write("what would you like to do: 1 viewbalance,2 withdraw or 3 Add money: ");
            string userValue = Console.ReadLine();
            int value = Convert.ToInt32(userValue);
            viewbalance(value);

            //string Valuechoose = Console.ReadLine();
            //int number = Convert.ToInt32(Valuechoose);
            withdraw(value);
        }
        static void viewbalance(int value)
        {
            if (value == 1)
            {
                Console.WriteLine("your account balace is $1000");
                Console.ReadLine();
            }
        }
           static void withdraw(int value)
            {
                if (value == 2)
                {
                    Console.WriteLine("how much would you like to withdraw");
                   Console.Write("$20,$40,$80,$100: ");
                Console.ReadLine();
                Console.WriteLine("please take your cash from the ATM,anything else");
                   Console.ReadLine();


            }
            }
        }
        
    } 
    
       
        
            
          
        
       
    

