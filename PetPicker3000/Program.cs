// Written by Ashley Butela
// Last edited: Feb. 27 2023

namespace PetPickerBUTELA
{
    internal class Program
    {
        static void Main()
        {
            string name = "";                                                   // User's name, just for politeness
            string response;                                                    // Holds user's responses
            string[] pets = new string[] { "calico",
                                            "ragdoll",
                                            "chihuahua",
                                            "pomeranian",
                                            "beagle",
                                            "samoyed",
                                            "labrador",
                                            "newfoundland",
                                            "mystery???" };                     // possible choices
            string exitString = "\n--------------------------------\r\n" +
                                "|   Press Any Key To Exit....  |" +
                                "\r\n--------------------------------";         // Message upon end of program
            bool isInvalid = false;
            string[] asciiRobot = new string[] { "         O           _|||||      P  E  T",
                                                " -------|------      \\\\||||      _____ ______ _____ _  ________ _____  ",
                                                "|    -     -   |      |___|      |  __ \\_   _/ ____| |/ /  ____|  __ \\ ",
                                                "|    @     @   |      |___|      | |__) || || |    | ' /| |__  | |__) |",
                                                "|              |     /___/       |  ___/ | || |    |  < |  __| |  _  / ",
                                                "|    [=====]   |    /___/        | |    _| || |____| . \\| |____| | \\ \\ ",
                                                "|______________|   /   /         |_|   |_____\\_____|_|\\_\\______|_|  \\_\\"};  // It looks better in the console, I promise

            Boolean repeat = true;                                              // Controls repeat of program

            do
            {
                Console.Title = "Pet Picker 3000";
                Console.WriteLine("");  //Just setting the stage
                for (int n = 0; n < asciiRobot.Length; n++)
                {
                    Console.WriteLine(asciiRobot[n]);
                }
                //Ask the person's name. Nobody's afraid of computers getting too personal, right?
                if (name == "" || name == null)
                {
                    Console.WriteLine("\nHi! What's your name?");
                    Console.Write("--Type your name here: ");
                    name = Console.ReadLine(); // Note: name passed directly as typed to pass "the Turkey test"

                    // Double check that the input is correct - let the user decide.
                    Console.WriteLine($"\n{name}? Is that right?");
                    Console.Write("-->Enter 'yes' or 'no' here: ");
                    response = Console.ReadLine().ToLower();

                    switch (response)
                    {
                        case string s when s.StartsWith("y"):
                            break;
                        case string s when s.StartsWith("n"):
                            Console.WriteLine("Oh, ok. What's your name?");
                            Console.Write("-->Enter your name here: ");
                            name = Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"\nHi, {name}!");
                }


                // Confirm that there's actually something there.
                while (name == null || name == "")
                {
                    Console.WriteLine("No seriously, what's your name?");
                    Console.Write("--Type your name here: ");
                    name = Console.ReadLine(); // Note: name passed directly as typed to pass "the Turkey test"
                }

                // Present the user with menu and request input
                Console.WriteLine("\n----------------------------------------------------");
                Console.WriteLine("|          What would you like to do?              |");
                Console.WriteLine("|        1. Access the Pet Picker 3000             |");
                Console.WriteLine("|        2. View all possible options              |");
                Console.WriteLine("|        3. Exit                                   |");
                Console.WriteLine("----------------------------------------------------");
                Console.Write("--Please enter the number of your selection: ");

                // Repeat selection while input is invalid
                do
                {
                    response = Console.ReadLine();
                    switch (response)
                    {
                        case "1":
                            RunPetPicker(name);
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Here's the possible pets you'll get from using Pet Picker 3000:\n");
                            foreach (var pet in pets)
                            {
                                System.Threading.Thread.Sleep(300);
                                Console.WriteLine("      " + pet);
                            }
                            break;
                        case "3":
                            Console.WriteLine(exitString);
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine($"\nI'm sorry, {name}, I can't do that.");
                            isInvalid = true;
                            Console.Write("Try again: ");
                            break;
                    }
                } while (isInvalid == true);

                // Ask if user wants to redo the program
                System.Threading.Thread.Sleep(200);
                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine("|   Would you like to play again? (yes / no)   |");
                Console.WriteLine("-----------------------------------------------");
                Console.Write("\nType yes or no here: ");
                response = Console.ReadLine().ToLower();

                do
                {
                    switch (response)
                    {
                        case string s when s.Contains("ye") || s.Contains("yu"):
                            isInvalid = false;
                            System.Threading.Thread.Sleep(200);
                            Console.Clear();
                            break;
                        case string s when s.Contains("no"):
                            isInvalid = false;
                            repeat = false;
                            Console.WriteLine(exitString);
                            break;
                        default:
                            isInvalid = true;
                            Console.WriteLine("That's not valid. Try again: ");
                            response = Console.ReadLine().ToLower();
                            break;
                    }
                } while (isInvalid == true);

            } while (repeat == true);
        }

        /**
         * The RunPetPicker suggests a pet based on user input on multiple questions.
         */
        static void RunPetPicker(string name)
        {
            string petType = "cat";         // Holds type of pet
            int wantsDog = 0;               // Specifies pet type
            string size = "small";          // Holds size of pet
            int wantsBig = 0;               // Specifies pet size
            string hair = "short-haired";   // Holds hair length of pet
            int wantsLongHair = 0;          // Specifies hair length
            int choice;                     // Holds calculated value
            string response;                // holds user response
            string[] pets = new string[] { "calico", "ragdoll", "chihuahua", "pomeranian", "beagle", "samoyed", "labrador", "newfoundland" };

            // Explain the goal.
            Console.Clear();
            Console.WriteLine($"\n\nHi, {name}. I'm gonna help you pick a pet.");

            // First question
            Console.WriteLine("First things first: Do you want a cat, or a dog?");
            Console.Write("\nType your response here: ");
            response = Console.ReadLine().ToLower();

            // Validate user input
            while (response.Contains("both") || ((response.Contains("cat") || response.Contains("kit")) && (response.Contains("dog")) || response.Contains("pup")))
            {
                Console.WriteLine("Sorry, you can't pick both this time. Cat or dog?");
                Console.Write("\nType your response here: ");
                response = Console.ReadLine().ToLower();
            }

            // Validate user input
            while (!response.Contains("cat") && !response.Contains("kit") && !response.Contains("dog") && !response.Contains("pup"))
            {
                if (response.Contains("llama") || response.Contains("robot") || response.Contains("mogwai") || response.Contains("dragon"))
                {
                    switch (response)
                    {
                        case string s when s.Contains("llama"):
                            petType = "llama";
                            break;
                        case string s when s.Contains("robot"):
                            petType = "robot";
                            break;
                        case string s when s.Contains("mogwai"):
                            petType = "mogwai";
                            break;
                        case string s when s.Contains("dragon"):
                            petType = "dragon";
                            break;
                    }
                    RunWeirdPet(name, petType);
                    return;
                }

                Console.WriteLine("\nThat wasn't really an option. Cat or dog?");
                Console.Write("\nType your response here: ");
                response = Console.ReadLine().ToLower();
            }

            if (response.Contains("dog") || response.Contains("pup"))
            {
                petType = "dog";
                wantsDog = 2;
            }

            // Confirm and ask follow up questions.
            if (petType == "cat")
            {
                Console.WriteLine("\nA cat! Great!");
            }
            else if (petType == "dog")
            {
                // Ask dog-specific question
                Console.WriteLine("\nA dog! Great!");
                Console.WriteLine("Do you want a small, medium, or large dog?");
                Console.Write("\nType your response here: ");
                response = Console.ReadLine().ToLower();

                // Validate user input
                while (response == null || response == "")
                {
                    Console.WriteLine("Surely you have an opinion! Big or small?");
                    response = Console.ReadLine().ToLower();
                }

                if (response.Contains("med") || response.Contains("not too"))
                {
                    size = "medium";
                    wantsBig = 2;
                }
                else if (response.Contains("big") || response.Contains("hu"))
                {
                    size = "big";
                    wantsBig = 4;
                }
            }
            else
            {
                Console.WriteLine($"You really want a {petType}, huh.");
            }

            Console.WriteLine("\nOk, last question!");
            do
            {
                Console.WriteLine($"Do you want a longhaired {petType}, or a shorthaired {petType}?");
                Console.Write("\nType your response here: ");
                response = Console.ReadLine().ToLower();
            } while (response == null || response == "");

            if (response.Contains("long") || response.Contains("flu"))
            {
                hair = "long-haired";
                wantsLongHair = 1;
            }

            Console.Clear();
            // Calculate the responses and give the answer.
            Console.WriteLine($"\nOk, {name}. You said you wanted a {size}, {hair} {petType}.\n");
            choice = wantsDog + wantsBig + wantsLongHair;
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("---------------------------------------------------------");
            System.Threading.Thread.Sleep(100);
            Console.Write("|           ");


            for (int i = 0; i < "thinking..".Length; i++)
            {
                System.Threading.Thread.Sleep(100);
                Console.Write($" {"THINKING.."[i]} ");
            }
            Console.WriteLine(" .            |");

            for (int j = 0; j < 56; j++)
            {
                Console.Write("-");
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine("-\n\n");

            Console.WriteLine("Got it!\n");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine($"I recommend you get a {pets[choice]}!\n\n");
        }

        /**
        * The RunWeirdPet is an easter egg response based on three odd keywords.
        */
        static void RunWeirdPet(string name, string pt)
        {
            string petType = pt;
            string response = "";
            string article = "a";
            string[] skepticalRobot = new string[] { "\n         O",
                                                    "\n -------|------",
                                                    "\n|    _     ^   |",
                                                    "\n|    @     @   |",
                                                    "\n|              |",
                                                    "\n|   |=======   |",
                                                    "\n|______________|"};

            Console.Clear();
            foreach (var line in skepticalRobot)
            {
                Console.Write(line);
            }

            Console.SetCursorPosition(20, 3);
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(250);
                Console.Write(" . ");
            }
            Console.SetCursorPosition(20, 4);
            System.Threading.Thread.Sleep(300);
            Console.Write($" A {petType}, huh.");

            System.Threading.Thread.Sleep(300);
            Console.Write(" Ok. ");

            System.Threading.Thread.Sleep(300);
            Console.SetCursorPosition(20, 5);
            Console.WriteLine(" That wasn't on the list, you know.");
            System.Threading.Thread.Sleep(500);

            Console.SetCursorPosition(20, 7);
            Console.WriteLine($"\nWell, if we're gonna go down this route, what color do you want?");
            Console.Write("--> Enter a color here: ");
            response = Console.ReadLine().ToLower();
            if (response.StartsWith("o") || response.StartsWith("a") || response.StartsWith("u"))
            {
                article = "an";
            }

            // Calculate the responses and give the answer.
            Console.WriteLine($"\nOk, {name}. For some reason you said you wanted {article} {response} {petType}.\n");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("---------------------------------------------------------");
            System.Threading.Thread.Sleep(100);
            Console.Write("|           ");
            for (int i = 0; i < "thinking..".Length; i++)
            {
                System.Threading.Thread.Sleep(100);
                Console.Write($" {"THINKING.."[i]} ");
            }
            Console.WriteLine(" .            |");

            for (int j = 0; j < 56; j++)
            {
                Console.Write("-");
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine("-\n\n");

            Console.WriteLine("Got it!\n");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine($"I guess you're getting {article} {response} {petType}.");
            Console.WriteLine("You didn't really need me for this, did you?\n\n");
            switch (petType)
            {
                case "mogwai":
                    Console.WriteLine("One more thing! Don't feed it after midnight!!!");
                    break;
                case "robot":
                    Console.WriteLine("If he starts disobeying you, just run, ok?");
                    break;
                case "llama":
                    Console.WriteLine("Probably best to just run now if his name is Carl.");
                    break;
                case "dragon":
                    Console.WriteLine("They breathe fire, you know. Probably best to double check your home insurance.");
                    break;
            }
        }
    }
}