using System;

namespace Week3Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter the speed limit.");
            string speedL = Console.ReadLine();
            int speedLimit = int.Parse(speedL);
            Car c = new Car();
            Console.WriteLine("Please enter the make of your car.");
            c.make = Console.ReadLine();
            Console.WriteLine("Please enter the model of your car.");
            c.model = Console.ReadLine();
            Console.WriteLine("Please enter how fast you were going in MPH.");
            c.mph = Console.ReadLine();
            int carSpeed = int.Parse(c.mph);
            
            if (carSpeed > speedLimit)
            {
               

                int demeritPoints = 0;
                while (carSpeed < speedLimit)
                {
                    carSpeed -= 5;
                    demeritPoints++;
                }
                if(demeritPoints > 10)
                {
                    Console.WriteLine("<LICENCE SUSPENDED>");
                }
                }
                 else
                {   
                    Console.WriteLine("OK");
                }
           

        }
           
    }
        
        public class Car
        {
 
            public string make;
            public string model;
            public string mph;

                
        }
    
}
