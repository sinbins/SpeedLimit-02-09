using System;

namespace SpeedLimit_FA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables for later calculation
            const int DEMERIT_PER_MILES = 5;

            //User inputs speed limit to test whether cars are going above or below speed limit
            Console.WriteLine("Enter the speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            //Loop to ask user to input three different cars
            for (int i = 0; i < 3; i++)
            {
                //Information of the car entered by user(make)
                Console.WriteLine("Enter the car make: ");
                string make = Console.ReadLine();
                
                Car m = new Car();
                m.carMake = make;
                //(Model)
                Console.WriteLine("Enter the model: ");
                string model = Console.ReadLine();
                
                Car m1 = new Car();
                m1.carModel = model;
                //Car's speed
                Console.WriteLine("Enter the speed of the car: ");
                int carSpeed = Convert.ToInt32(Console.ReadLine());
                Car s = new Car();
                s.speed = carSpeed;

                //If the speed of the car is under speed limit, they're "OK"
                if(carSpeed < speedLimit)
                {
                    Console.WriteLine(m.carMake + " " + m1.carModel + " " + s.speed + "mph: " + "OK");
                }
                //else if the car speed is higher than the speed limit
                else if(carSpeed > speedLimit) {
                    //Calculate the demerits per 5 miles to see whether the license is suspended or not
                    int aboveSpeedLimit = carSpeed - speedLimit;
                    int demerits = aboveSpeedLimit / DEMERIT_PER_MILES;
                    //License will suspend if demerits is 10 or over 10
                    if (demerits >= 10)
                    {
                        Console.WriteLine(m.carMake + " " + m1.carModel + " " + s.speed + "mph: " + demerits + " demerits <LICENSE SUSPENDED>");
                    }
                    //demerits prints
                    else
                    {
                        Console.WriteLine(m.carMake + " " + m1.carModel + " " + s.speed + "mph: " + demerits + " demerits");
                    }
                }

            }

          


            
           
            

        }
    }
    //The car has it's own parameters making each car unique
    public class Car
    {
        public string carMake;
        public string carModel;
        public int speed;
    }
    

    
    
}