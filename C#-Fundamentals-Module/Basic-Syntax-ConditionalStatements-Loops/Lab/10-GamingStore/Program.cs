using System;

namespace MORE_03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double moneyFirst = double.Parse(Console.ReadLine());
            double balance = moneyFirst;         

            string command = Console.ReadLine();


            while(command != "Game Time")
            {
                if(command == "OutFall 4")
                {
                    balance = balance - 39.99;
                    if(balance < 0)
                    {
                        Console.WriteLine("Too Expensive");                     
                    }
                    if(balance >= 0)
                    {
                        Console.WriteLine("Bought OutFall 4");
                    }
                    if(balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    if(balance < 0)
                    {
                        balance = balance + 39.99;
                    }   
                    
                }
                else if(command == "CS: OG")
                {
                    balance = balance - 15.99;
                    if (balance < 0)
                    {
                        Console.WriteLine("Too Expensive");                     
                    }
                    if (balance >= 0)
                    {
                        Console.WriteLine("Bought CS: OG");
                    }
                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    if(balance < 0)
                    {
                        balance = balance + 15.99;
                    }
                    
                }
                else if (command == "Zplinter Zell")
                {
                    balance = balance - 19.99;
                    if (balance < 0)
                    {
                        Console.WriteLine("Too Expensive");   
                    }
                    if (balance >= 0)
                    {
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    if(balance < 0)
                    {
                        balance = balance + 19.99;
                    }
                    
                }
                else if (command == "Honored 2")
                {
                    balance = balance - 59.99;
                    if (balance < 0)
                    {
                        Console.WriteLine("Too Expensive");    
                    }
                    if (balance >= 0)
                    {
                        Console.WriteLine("Bought Honored 2");
                    }
                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    if(balance < 0)
                    {
                        balance = balance + 59.99;
                    }
                    
                }
                else if (command == "RoverWatch")
                {
                    balance = balance - 29.99;
                    if (balance < 0)
                    {
                        Console.WriteLine("Too Expensive");   
                    }
                    if (balance >= 0)
                    {
                        Console.WriteLine("Bought RoverWatch");
                    }
                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    if(balance < 0)
                    {
                        balance = balance + 29.99;
                    }
                    
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    balance = balance - 39.99;
                    if (balance < 0)
                    {
                        Console.WriteLine("Too Expensive");   
                    }
                    if (balance >= 0)
                    {
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    if(balance < 0)
                    {
                        balance = balance + 39.99;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Not Found");
                }              

                command = Console.ReadLine();
                
            }

            if(balance > 0)
            {
                Console.WriteLine($"Total spent: ${(moneyFirst - balance):f2}. Remaining: ${balance:f2}");
            }

        }
    }
}


