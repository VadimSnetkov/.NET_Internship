using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modules.Module1();
            Modules.Module2();
        }
    }

    class Modules
    {
        public static void Module1()
        {
            //Unit 2
            // Console.WriteLine("Hello, World!");

            Console.WriteLine("Congratulations!");
            Console.Write("You wrote your first lines of code.");

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");

            //Unit 4
            string write1 = "This is the ";
            string write2 = " line of code.";
            string line;

            for (int i = 1; i < 3; i++)
            {
                if (i == 1)
                {
                    line = "first";
                    Console.WriteLine(write1 + line + write2);
                }
                if (i == 2)
                {
                    line = "second";
                    Console.WriteLine(write1 + line + write2);
                }
            }

            Console.WriteLine("-----------------------------------");
            //Unit 5

            Console.WriteLine("This is the first line.");

            Console.Write("This is ");
            Console.Write("the second ");
            Console.Write("line.");

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");

        }
        public static void Module2()
        {
            //Unit 2
            Console.WriteLine('b');
            //Console.WriteLine('Hello World!');
            Console.WriteLine(123);
            Console.WriteLine(0.25f);
            Console.WriteLine(2.625);
            Console.WriteLine(12.39816m);
            Console.WriteLine(true);
            Console.WriteLine(false);
            // Output: 123
            Console.WriteLine("123");
            // Output: 123
            Console.WriteLine(123);

            // Output: true
            Console.WriteLine("true");
            // Output: True
            Console.WriteLine(true);
            Console.WriteLine("-----------------------------------------");

            //Unit 3
            string firstName;
            char userOption;

            int gameScore;

            decimal particlesPerMillion;

            bool processedCustomer;

            //Unit 4
            firstName = "Bob";
            //"Bob" = firstName;

            int intFirstName;
            //firstName2 = "Bob";

            Console.WriteLine(firstName);

            firstName = "Bob";
            Console.WriteLine(firstName);
            firstName = "Liem";
            Console.WriteLine(firstName);
            firstName = "Isabella";
            Console.WriteLine(firstName);
            firstName = "Yasmin";
            Console.WriteLine(firstName);

            //string firstName3;
            //Console.WriteLine(firstName3);

            string firstName4 = "Bob";
            Console.WriteLine(firstName4);

            Console.WriteLine("-----------------------------------------");

            //Unit 5
            var message = "Hello world!";

            //Unit 6
            string firstName5 = "Bob";
            int howManyPets = 3;
            decimal temperatureOutside = 34.4m;

            Console.WriteLine($"Hello, {firstName5}! You have to feed {howManyPets} pets and the temperature outside is {temperatureOutside} degrees celsius.");
            Console.WriteLine("-----------------------------------------");

            //Unit 7
            string name = "Bob";
            int messages = 3;
            decimal temperature = 34.4m;

            Console.Write("Hello, ");
            Console.Write(name);
            Console.Write("! You have ");
            Console.Write(messages);
            Console.Write(" messages in your inbox. The temperature is ");
            Console.Write(temperature);
            Console.Write(" celsius.");


        }
    }
}