using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UserInfoRepository;

namespace PairedProgrammingGame
{
    class ProgramUI
    {
        public void Run()
        {

            var userInfo = GetUserInfo();
            string userInput = Continue();
            if (userInput == "2")
            {
                return;
            }

            Game(userInfo);

        }

        private UserInfo GetUserInfo()
        {
            UserInfo userInfo = new UserInfo();
            //Name
            Console.WriteLine("Welcome to Just Another Day, a text based adventure game based on your life!\n" +
                "To get started, let's get a little bit of information about yourself. What is your name?");
            userInfo.Name = Console.ReadLine();
            Console.Clear();

            //City
            Console.WriteLine($"Thank you, {userInfo.Name}!\n" +
                $"Tell us the name of the city in which you live.");
            userInfo.City = Console.ReadLine();
            Console.Clear();

            //Friend Name
            Console.WriteLine($"I bet {userInfo.City} is a lovely place to live!\n" +
                $"Tell us the name of a close friend.");
            userInfo.FriendName = Console.ReadLine();
            Console.Clear();

            // Age
            Console.WriteLine($"{userInfo.FriendName} sounds lovely! \n" +
                $"Tell us your age.");
            userInfo.Age = Int32.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"{userInfo.Age}? Nice!\n" +
                $"Thank you for all that info!");

            return userInfo;
        }

        private string Continue()
        {
            Console.Clear();
            Console.WriteLine("Ready to get started?\n" +
                    "1. Continue\n" +
                    "2. Exit");
            string userOption = Console.ReadLine();
            var validOption = false;
            while (validOption == false)
            {
                switch (userOption)
                {
                    case "1":
                        validOption = true;
                        return userOption;
                    case "2":
                        Console.WriteLine("Have a good day!");
                        Thread.Sleep(1500);
                        return userOption;
                    default:
                        Console.WriteLine("That is not a valid choice. Please press 1 or 2.");
                        userOption = Console.ReadLine();
                        break;
                }
            }
            return userOption;
        }

        private void Game(UserInfo userInfo)
        {
            Console.Clear();

            // User tools
            var hasGun = false;
            var hasMeleeWeapon = false;
            var hasRangedWeapon = false;
            var hasFood = false;
            var hasBeenHurt = false;
            var hasMedicine = false;
            var hasGymBag = false;
            // User scene options / bools
            var checkFrontDoorFirst = false;
            var areDressed = false;
            var checkBackWindowFirst = false;
            var fleeHouse = false;
            var haveCar = false;
            // User text returns
            string wrongAnswer = "Not a vaild option.";
            string foundGun = "You found a Gun!"; // might try to include amount of bullets
            string foundMeleeWeapon = "You found a Bat!";
            string foundRangedWeapon = "You found a Crossbow!"; // might try to include amount of arrows
            string foundFood = "You found a Ration!";
            string foundMedicine = "You found a Medkit!";
            string hasKeys = "You found your car keys in your pocket!";

            /*
             branch 1 : long length story
                user gets out alive

             branch 2 : medium length story
                user makes a mistake later on

             branch 3 : short length story
                user died instantly
        if(){

               var userOption# = Console.ReadLine();
               var validOption# = false;
               while(validOption#)
                {  
                     switch()
                    {
                        case "1":
                            // validOption# = true;
                            Console.Clear();
                            Console.WriteLine();
                            Console.ReadLine();
                            break;
                        case "2":
                            // validOption# = true;
                            Console.Clear();
                            Console.WriteLine();
                            Console.ReadLine();
                            break;
                        case "3":
                            // validOption# = true;
                            Console.Clear();
                            Console.WriteLine();
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine(wrongAnswer);
                            //userOption# = Console.ReadLine();
                            break;
                        }
                }
            }

            

             */

            // Introduction
            Console.WriteLine($"It is a lovely day in the city of {userInfo.City}. You wake up to the sound of a faint siren, assuming \n" +
                $"it was your alarm you roll over to check your phone. You realize that you did not set your alarm \n" +
                $"the night before, and strangely you see that your phone has no signal. As you pause to consider why this is, \n" +
                $"you hear a knock at the door. You wonder who could be knocking at your door this early only have your thoughts \n" +
                $"interrupted by what sounds like scratching at your back window.\n" +
                $"What would you like to do?\n" +
                $"1. Go see who is at the front door.\n" +
                $"2. Take a minute to get dressed.\n" +
                $"3. Go check out the back window.");
            var userOption1 = Console.ReadLine();
            var validOption1 = false;

            // First User Option Result
            while (validOption1 == false)
            {
                switch (userOption1)
                {
                    case "1":
                        Console.Clear();
                        validOption1 = true;
                        checkFrontDoorFirst = true;
                        Console.WriteLine($"You begrudgingly get out of bed to go see who is knocking at your front door.\n" +
                            $"You think to yourself that it better not be {userInfo.FriendName} at this hour. As you open the door,\n" +
                            $"you are shocked to find a small group of strangers lunge towards you. Their eyes are white and they appear\n" +
                            $"to be injured or sick. You don't have time to think about who they are or why they are at your house before\n" +
                            $"they all grab you and start biting your flesh. You are dead. Game over.");
                        Console.ReadLine();
                        return;
                    case "2":
                        Console.Clear();
                        validOption1 = true;
                        areDressed = true;
                        Console.WriteLine($"As a {userInfo.Age} year old, you understand the importance of getting dressed for the day.\n" +
                            $"You decide to take a moment to choose an outfit for the day and get dressed.");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        validOption1 = true;
                        checkBackWindowFirst = true;
                        Console.WriteLine($"You decide to find out what is scratching at your back window. You think to yourself that it's\n" +
                            $"probably a raccoon. Walking from your bedroom, you feel a bit chilly in your shorts and realize that you should\n" +
                            $"have gotten dressed first. Shrugging it off, you turn the corner from your hallway to look out your window.\n" +
                            $"You are surprised to see a group of people walking around in your backyard. You rub the sleep out of your\n" +
                            $"eyes and walk closer to get a better look. Your heart skips a beat when you notice one of the people is the\n" +
                            $"{userInfo.City} mayor, who died a week ago!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(wrongAnswer);
                        userOption1 = Console.ReadLine();
                        break;
                }

            }
            // Main route choice 1
            if (checkBackWindowFirst)
            {
                Console.Clear();

                Console.WriteLine("You take a second to process the horror scene outside your window, enough time to decide what to do next.\n" +
                    "1. Run out of the house!\n" +
                    "2. Go back to your room and get dressed.");

                var userOption3 = Console.ReadLine();
                var validOption3 = false;
                while (validOption3 == false)
                {
                    switch (userOption3)
                    {
                        case "1":
                            validOption3 = true;
                            fleeHouse = true;
                            Console.Clear();
                            Console.WriteLine($"You panic and decide the best course of action is to get out of the house immediately.\n" +
                                $"You quickly turn and run towards your garage. You notice the gym bag that {userInfo.FriendName}\n" +
                                $"left by the door when you last went to the gym together. You grab it, hoping it has some clothes inside.");
                            Console.ReadLine();
                            break;
                        case "2":
                            validOption3 = true;
                            areDressed = true;
                            Console.Clear();
                            Console.WriteLine($"As a {userInfo.Age} year old, you understand the importance of getting dressed for the day.\n" +
                            $"You decide to take a moment to choose an outfit for the day and get dressed.");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine(wrongAnswer);
                            userOption3 = Console.ReadLine();
                            break;
                    }
                }
            }

            if (areDressed)
            {
                Console.Clear();

                if (checkBackWindowFirst)
                {
                    Console.WriteLine("After quickly getting dressed, you decide the best course of action would be to get into your car\n" +
                        "and drive far away.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("As you get dressed, you hear what sounds like someone walking outside your bedroom window.\n" +
                        "You finish tying your shoes and walk closer to the window to see who it is. As you approace the window,\n" +
                        "it shatters as a bloody hand reaches for you. A large shard of glass slices your arm open and you hear\n" +
                        "mindless groans outside. You decide you better get out of here!");
                    hasBeenHurt = true;
                    Console.ReadLine();
                }
                Console.WriteLine(hasKeys);

                Console.WriteLine("You hear your back window breaking and what sounds like moaning and rustling sounds.\n" +
                    "You realize your house is not safe!\n" +
                    "1. Run to the garage and get in your car.\n" +
                    "2. Look for supplies on your way to your car.");
                var userOption2 = Console.ReadLine();
                var validOption2 = false;
                while (validOption2 == false)
                {
                    switch (userOption2)
                    {
                        case "1":
                            validOption2 = true;
                            Console.Clear();
                            Console.WriteLine("You run as fast as you can to your garage, hoping your car is safe and you can get\n" +
                                "out of here.");
                            haveCar = true;
                            Console.ReadLine();
                            break;
                        case "2":
                            validOption2 = true;
                            if (hasBeenHurt)
                            {
                                Console.Clear();
                                Console.WriteLine("With your arm bleeding, you decide that you have to treat it before leaving the house.\n" +
                                    "You rush across the hall to your bathroom to look for a bandage or something to stop the bleeding.\n" +
                                    "You throw open the cabinet and knock over a stack of extra toilet paper." + foundMedicine + "\n" +
                                    "You quickly wrap your arm up with a bandage from the kit. Then, you take the medkit with you as\n" +
                                    "you rush down the hall to your garage.");
                                hasMedicine = true;
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You decide that you better not leave the house without supplies, so you gather up as\n" +
                                    "much as you can carry from around your room. You grab your backpack and stuff it full of extra clothes.\n" +
                                    "You pick up an old baseball bat from your closet. You see your old trumpet and think to yourself that\n" +
                                    "you'll definitely need that! Carrying as much as you can, you realize that it's past time to get out of\n" +
                                    "the house. You open the door to room and are immediately overwhelmed by the crowd of bloody strangers in\n" +
                                    "your hallway. The last thing you feel are their teeth sinking into your flesh. You also swear you hear\n" +
                                    "the soft blast of a trumpet. You are dead. Game Over.");
                                Console.ReadLine();
                            }
                            return;

                        default:
                            Console.WriteLine(wrongAnswer);
                            userOption2 = Console.ReadLine();
                            break;
                    }
                }
            }

            if (fleeHouse)
            {
                // you checked the window and ran out grabbing a gym bag...you'll have to ride a bike or go back to get your keys (and die)

                var userOption4 = Console.ReadLine();
                var validOption4 = false;
                while (validOption4)
                {
                    switch (userOption4)
                    {
                        case "1":
                            validOption4 = true;
                            Console.Clear();
                            Console.WriteLine();
                            Console.ReadLine();
                            break;
                        case "2":
                            validOption4 = true;
                            Console.Clear();
                            Console.WriteLine();
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine(wrongAnswer);
                            userOption4 = Console.ReadLine();
                            break;
                    }
                }
            }

            if (haveCar)
            {
                // Either get in the car and leave or try to grab a gun from the cabinet
                var userOption5 = Console.ReadLine();
                var validOption5 = false;
                while (validOption5)
                {
                    switch (userOption5)
                    {
                        case "1":
                            validOption5 = true;
                            Console.Clear();
                            Console.WriteLine();
                            Console.ReadLine();
                            break;
                        case "2":
                            validOption5 = true;
                            Console.Clear();
                            Console.WriteLine();
                            Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine(wrongAnswer);
                            userOption5 = Console.ReadLine();
                            break;
                    }
                }
            }

            Console.ReadKey();
        }

    }
}
