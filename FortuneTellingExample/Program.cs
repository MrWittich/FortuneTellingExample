using System;

namespace FortuneTellingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();

            Console.WriteLine("{0}, Welcome to my Fortune Telling Application!\n", name);
            
            Console.WriteLine("Please select a Color (Red, Blue, or Yellow).");
            string color = Console.ReadLine();

            color = color.ToLower();

            Console.WriteLine("\nPlease select a Number (1, 2, 3, or 4).");
            string number = Console.ReadLine();

            if(color == "red")
            {
                if(number == "1")
                {
                    Console.WriteLine("Your ability for accomplishment will follow with success.");
                }
                else if(number == "2")
                {
                    Console.WriteLine("The love of your life is stepping into your planet this summer.");
                }
                else if(number == "3")
                {
                    Console.WriteLine("When fear hurts you, conquer it and defeat it!");
                }
                else if(number == "4")
                {
                    Console.WriteLine("You learn from your mistakes... You will learn a lot today.");
                }
                else
                {
                    Console.WriteLine("That is not one of the lucky numbers, please try again.");
                }
            }
            else if (color == "blue")
            {
                if (number == "1")
                {
                    Console.WriteLine("It's better to be alone sometimes.");
                }
                else if (number == "2")
                {
                    Console.WriteLine("A stranger, is a friend you have not spoken to yet.");
                }
                else if (number == "3")
                {
                    Console.WriteLine("You can make your own happiness.");
                }
                else if (number == "4")
                {
                    Console.WriteLine("If winter comes, can spring be far behind?");
                }
                else
                {
                    Console.WriteLine("That is not one of the lucky numbers, please try again.");
                }
            }
            else if (color == "yellow")
            {
                if (number == "1")
                {
                    Console.WriteLine("When fear hurts you, conquer it and defeat it!");
                }
                else if (number == "2")
                {
                    Console.WriteLine("You already know the answer to the questions lingering inside your head.");
                }
                else if (number == "3")
                {
                    Console.WriteLine("Land is always on the mind of a flying bird.");
                }
                else if (number == "4")
                {
                    Console.WriteLine("Life consists not in holding good cards, but in playing those you hold, well.");
                }
                else
                {
                    Console.WriteLine("That is not one of the lucky numbers, please try again.");
                }
            }
            else
            {
                Console.WriteLine("That is not a true color, I cannot tell your fourtune with that. Please try again.");
            }


            Console.WriteLine("Goodbye, " + name);

        }
    }
}
