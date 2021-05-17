using System;

namespace YourDestiny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate? YES/NO");
            string noiseChoice = Console.ReadLine();
            noiseChoice = noiseChoice.ToUpper();
            if (noiseChoice == "YES")
            {
                Console.Write("You walk into the hallway and see a light coming from under a door down the hall.You walk towards it. Do you open it or knock?");
                string doorChoice = Console.ReadLine();
                doorChoice = doorChoice.ToUpper();
                if (doorChoice == "KNOCK")
                {
                    Console.Write("A voice behind the door speaks. It says, Answer  riddlePoor people have it. Rich people need it. If you eat it you die. What is it?");
                    string answer = Console.ReadLine();
                    answer = answer.ToUpper();
                    if (answer == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there.dYou turn off the light and run back to your room and lock the door.THE END");
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.THE END.");
                    }


                }
                else if (doorChoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    string keyChoice = Console.ReadLine();
                    keyChoice = keyChoice.ToUpper();
                    switch (keyChoice)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice!");
                    break;
                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open");
                    break;
                        case "3":
                            Console.WriteLine("You choose the third key. The door doesn't open");
                            break;
                    }
               }
            }
            else
            {
                Console.Write("Not much of an adventure if we don't leave our room THE END.");
            }


        }
    }
}
    

