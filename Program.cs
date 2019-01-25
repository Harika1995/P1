using System;

namespace P1
{
    class Program
    {
        public decimal totalCost(string itemNo, int quantity, decimal unitCost)
        {
            decimal totalCost = 0.0m;
            switch (itemNo)
            {
                case "1":
                {
                    totalCost = unitCost * quantity;
                    break;
                }
                case "2":
                {
                    totalCost = unitCost * quantity;
                    break;
                }
                case "3":
                {
                    totalCost = unitCost * quantity;
                    break;
                }
                case "4":
                {
                    totalCost = unitCost * quantity;
                    break;
                }
                default:
                {
                    totalCost = totalCost + (10*quantity);
                    break;
                }
            }    
            return totalCost;
        }
        static void Main(string[] args)
        {
            bool exitOpti = true;
            decimal unitCost = 0.0m;
            var purchaseCost = 0.0m;
            string customerName="";
            int age;
            int quantity =0;
            String itemNo;
            while(exitOpti)
            {
                customerName="";
                age =0;
                while(customerName=="")   
                {
                    Console.WriteLine("Enter your Name:");
                    customerName=Console.ReadLine();
                }
                while(age<=0)
                {
                    Console.WriteLine("Enter your age");
                    age=Convert.ToInt32(Console.ReadLine());
                }
                if(age>=21)
                {
                    Console.WriteLine("Alcohol Menu");
                    Console.WriteLine("\n\t 1.Black and white blended scotch");
                    Console.WriteLine("\n\t 2.Kingfisher Bagpiper");
                    Console.WriteLine("\n\t 3.Knock Out Brandy");
                    Console.WriteLine("\n\t 4.Imperier Blue");
                    Console.WriteLine("Enter the Alcohol you want to buy from the list: ");
                    itemNo = Console.ReadLine();
                    if(itemNo == "1")
                    {
                        unitCost =12;
                    }
                    else if(itemNo == "2")
                    {
                        unitCost = 14;
                    }
                    else if(itemNo == "3")
                    {
                        unitCost = 20;
                    }
                    else if(itemNo == "4")
                    {
                        unitCost = 24;
                    }
                    Console.WriteLine("Enter the quantity you need to buy"); 
                    quantity = Convert.ToInt32(Console.ReadLine()); 
                    Program total = new Program();
                    purchaseCost = total.totalCost(itemNo, quantity, unitCost);
                    Console.WriteLine("=================PRICING=============");
                    Console.WriteLine($"Alcohol {itemNo} Total Purchase Cost is: {purchaseCost}$");
                    Console.WriteLine("=====================================");
                }
                else 
                {
                    Console.WriteLine("You are not eligible to buy.");   
                }
                Console.WriteLine("Enter true to continue again or q to quit :");        
                var ch = Console.ReadLine();
                if(ch == "q")
                {
                    Console.WriteLine("You are Done!");
                    break;
                }
            }
        }
    }
}
