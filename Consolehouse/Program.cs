using System;
using System.Threading;

namespace Consolehouse
{
    class Program
    {
        static void HostTalk(string input)
        {
            foreach (char letter in input)
            {
                int typewriterDelay = 75;
                Thread.Sleep(typewriterDelay);
                Console.Write(letter);
            }
        }
        static void HellLogic()
        {
            Console.WriteLine("/placeholder/");
            BedroomLogic();
        }
        static void EndLogic()
        {
            Console.WriteLine("/placeholder/");
            return;
        }
        static void MainRoomLogic()
        {
            Console.WriteLine("(You are in the main room)\n(Take an action or type 'finish')\n'describe'  'ask'  'kitchen'  'bedroom'\n");
            string action = "";//Console.ReadLine();
            while (action != "finish")
            {
                action = Console.ReadLine();
                if (action == "kitchen")
                    KitchenLogic();
                if (action == "bedroom")
                    BedroomLogic();
                if (action == "ask")
                    HostTalk("Why yes, what you see here is what you will have if you decide on this place.\nCable, Wifi, and other utilities are included, but you will need to supply your own TV, of course!\nIt may not seem like much, but I assure you it is worth the price!\n");
                if (action == "describe")
                    Console.WriteLine("The main room is fairly ordinary, as far as you can tell. There is a sofa, a coffee table, and a TV stand. The room, while plain, feels cosy. Grey carpet extends from the edge of the kitchen, all the way to the bedroom.");
                if (action == "finish")
                    EndLogic();
                else
                    Console.WriteLine("\nplease enter a valid command\n'describe'  'ask'  'kitchen'  'bedroom'  'finish'");
            }
        }
        static void KitchenLogic()
        {
            Console.WriteLine("You are in the kitchen\n(Take an action or type 'finish')\n'describe'  'ask'  'main'  'fridge'\n");
            string action = "";
            string answer = "";
            while (action != "finish")
            {
                action = Console.ReadLine();
                if (action == "fridge")
                {
                    Console.WriteLine("It appears to be a newer model of fridge. Upon further investigation, there appears to be bottled waters on the inside.\n");
                    HostTalk("Ah, are you thirsty? You may take one if you like.\n");
                    Console.WriteLine("Take one? (y/n)");
                    answer = Console.ReadLine();
                    if (answer == "y")
                        Console.WriteLine("You take one. The water is cool and refreshing");
                    else
                        Console.WriteLine("You decide against it and close the fridge door");
                }
                KitchenLogic();
                if (action == "main")
                    MainRoomLogic();
                if (action == "ask")
                    HostTalk("Ah yes, the kitchen! We recently renovated it. All the apliances are new.\nI hope you like it.");
                if (action == "describe")
                    Console.WriteLine("The kitchen is sparkling clean. A fridge and an electric oven sit atop black and white checkered tiles.\n There is also a dishwasher, sink and microwave. The sink itself is squeaky clean, and the countertops shine like justice.");
                if (action == "finish")
                    EndLogic();
                else
                    Console.WriteLine("\nplease enter a valid command\n'describe'  'ask'  'main'  'fridge'  'finish'");
            }
        }
        static void BedroomLogic()
        {
            Console.WriteLine("/placeholder/");

            string action = "";
            while (action != "finish")
            {
                action = Console.ReadLine();
                if (action == "main")
                    MainRoomLogic();
                if (action == "closet")
                    HellLogic();
                if (action == "bathroom")
                    BathroomLogic();
                if (action == "ask")
                    Console.WriteLine("/placeholder/");
                if (action == "describe")
                    Console.WriteLine("/placeholder/");
                if (action == "finish")
                    EndLogic();
                else
                    Console.WriteLine("\nplease enter a valid command\n'describe'  'ask'  'kitchen'  'bedroom'  'finish'");
            }
        }
        static void BathroomLogic()
        {
            Console.WriteLine("/placeholder/");

            string action = "";
            while (action != "finish")
            {
                action = Console.ReadLine();
                if (action == "bedroom")
                    BedroomLogic();
                if (action == "ask")
                    Console.WriteLine("/placeholder/");
                if (action == "describe")
                    Console.WriteLine("/placeholder/");
                if (action == "finish")
                    EndLogic();
                else
                    Console.WriteLine("\nplease enter a valid command\n'describe'  'ask'  'kitchen'  'bedroom'  'finish'");
            }
        }
        static void Main(string[] args)
        {
            //   Console.WriteLine("Hello World!");
            MainRoomLogic();
        }
    }
}
