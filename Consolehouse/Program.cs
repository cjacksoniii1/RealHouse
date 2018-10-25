using System;
using System.Threading;

namespace Consolehouse
{
    class Program
    {
        static void NarrateTalk(string input)
        {
            foreach(char letter in input)
            {
                int typewriterDelay = 65;
                Thread.Sleep(typewriterDelay);
                Console.Write(letter);
            }
        }
        static void HellTalk(string input)
        {
            foreach (char letter in input)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                int typewriterDelay = 50;
                Thread.Sleep(typewriterDelay);
                Console.Write(letter);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
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
            NarrateTalk("Taking a peak inside the closet reveals that it seems to contain an entrance to     \n");
            HellTalk("...Hell...\n");
            HellTalk("You gaze deep into the portal. In the distance, you hear the pained wails of the damned...\n...doomed to forever exist in a swirling vortex of pain and missery...\nIn the center, behind legions of horrible monsters and tormented souls...\nsits an entity that exudes both beauty and terror, the likes of which you have never known before.");
            NarrateTalk("\nYou close the closet door.\n");
            
            BedroomLogic();
        }
        static void EndLogic()
        {
            HostTalk("Oh! You're finished?\nExcellent!\nTell me honestly, what did you think? Do you like it?! (y\n)");

            return;
        }
        static void MainRoomLogic()
        {
            Console.WriteLine("(You are in the main room)\n(Take an action or type 'finish')\n'describe'  'ask'  'kitchen'  'bedroom'\n");
            string action = "";
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
                   NarrateTalk("It appears to be a newer model of fridge. Upon further investigation, there appears to be bottled waters on the inside.\n");
                    HostTalk("Ah, are you thirsty? You may take one if you like.\n");
                    NarrateTalk("Take one? (y/n)");
                    answer = Console.ReadLine();
                    if (answer == "y")
                        NarrateTalk("You take one. The water is cool and refreshing");
                    else
                        NarrateTalk("You decide against it and close the fridge door");
                }
                KitchenLogic();
                if (action == "main")
                    MainRoomLogic();
                if (action == "ask")
                    HostTalk("Ah yes, the kitchen! We recently renovated it. All the apliances are new.\nI hope you like it.");
                if (action == "describe")
                    NarrateTalk("The kitchen is sparkling clean. A fridge and an electric oven sit atop black and white checkered tiles.\n There is also a dishwasher, sink and microwave. The sink itself is squeaky clean, and the countertops shine like justice.");
                if (action == "finish")
                    EndLogic();
                else
                    NarrateTalk("\nplease enter a valid command\n'describe'  'ask'  'main'  'fridge'  'finish'");
            }
        }
        static void BedroomLogic()
        {
            NarrateTalk("(You are in the main room)\n(Take an action or type 'finish')\n'describe'  'ask'  'main'  'bathroom'  'closet'\n");

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
                    HostTalk("Now, I know what you're thinking: It looks a bit plain. But don't you see? That is the beauty of this place!\nThink of it as a blank canvas, all it needs is someone like you to come along and make it your own!");
                if (action == "describe")
                    NarrateTalk("The bedroom seems somewhat barren. A queen-sized bedframe sits in the corner.\n An older style of ceiling fan buzzes above you, illuminating the rooms innoffensivly colored walls and carpet.\nThree wooden doors lead to the main room, a bathroom, and a closet.");
                if (action == "finish")
                    EndLogic();
                else
                    Console.WriteLine("\nplease enter a valid command\n'describe'  'ask'  'main'  'bathroom'  'closet'  'finish'");
            }
        }
        static void BathroomLogic()
        {
            NarrateTalk("You are in the bathroom\n(Take an action or type 'finish')\n'describe  'ask'  'kitchen'  'bedroom'\n");

            string action = "";
            while (action != "finish")
            {
                action = Console.ReadLine();
                if (action == "bedroom")
                    BedroomLogic();
                if (action == "ask")
                    HostTalk("Like most of the appartment, it's a little bit basic. But the shower is hot, the john flushes, and everything is clean!\n What more can you ask for?");
                if (action == "describe")
                    NarrateTalk("The whole room is covered in black and white checkered tile. It contains a shower, toilet, sink, and mirror.");
                if (action == "finish")
                    EndLogic();
                else
                    Console.WriteLine("\nplease enter a valid command\n'describe'  'ask'  'bedroom'  'finish'");
            }
        }
        static void Main(string[] args)
        {
            MainRoomLogic();
        }
    }
}
