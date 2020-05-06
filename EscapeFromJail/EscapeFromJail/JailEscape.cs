using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

namespace EscapeFromJail
{
    public class JailEscape
    {
        //Console.Write - one char at a time
        string npcName;
        bool hasCellKey = false;
        bool chowBerating = false;
        bool fatTonyInfo = false;
        bool secGuardInfo = false;
        bool hasShowered = false;
        bool hasUniform = false;
        bool hasOutfit = false;
        string password;
        Random randColor = new Random();



     

        public void Intro()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Hello and welcome to Escape From Jail!\n" +
                "This is a text adventure game where you will have options on how to progress the story, but be careful!\n" +
                "Not all choices will lead to the desired ending.\n\n" +
                "If you think what you have the wit to get yourself out of prison, go ahead an tell us your name!\n");
            npcName = Console.ReadLine();

            Console.WriteLine($"\nAlright {npcName}, let's see if you can make your way out! Good luck!");
            Console.ReadLine();
            JailCell();
        }

        public void JailCell()
        {

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("You wake up on a not-so-comfy cot, in a not-so-spacious jail cell. You look around the room and see\n" +
                "your well-used toilet-sink combo, a high-set window, and the bars you've been viewing for the past three months,\n" +
                "with a fresh tray of food near the sliding iron door. You've decided that today is the day.\n\n" +
                "Today is the day that you make your escape.\n\n" +
                "What do you decide to do?\n\n" +
                "1. Examine the window.\n" +
                "2. Examine the food.\n" +
                "3. Examine the toilet-sink.\n" +
                "4. Try to go back to sleep.\n" +
                "5. Try to open the door.\n\n");
            string cellResponse = Console.ReadLine();
            if (cellResponse == "1")
            {
                Console.Clear();
                Console.WriteLine("The window is just as wide as your face, but is set so high that you need to stand\n" +
                    "on the tips of your toes to see out of it.\n\n" +
                    "What you manage to see isn't much, just some barbed-wire fencing surrounding the yard you and\n" +
                    "your fellow inmates share for rec time.\n\n" +
                    "You decide that what's there isn't much to look at. You turn from the window...");
                Console.ReadLine();
                JailCell();
            }
            else if (!hasCellKey && cellResponse == "2")
            {
                Console.Clear();
                Console.WriteLine("The food is the cafeteria's finest, same gruel that they've been slinging since day one.\n" +
                    "Just as you second-guess you being hungry enough to eat any of that, you notice that this time\n" +
                    "lunch has come with a napkin, which is rare considering the most you've ever been given is a spoon.\n\n" +
                    "What do you decide to do?\n\n" +
                    "1. Examine the napkin.\n" +
                    "2. Leave the so-called food be.\n\n");
                string cellResponse2 = Console.ReadLine();
                if (cellResponse2 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("As you unfold the napkin, a key falls out onto the tray, straight into the gravy.\n" +
                        "You wipe it off and place it inside your shoe. This may come in handy.\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("***YOU'VE GAINED A KEY***\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You stand up and consider your cell once more.");
                    hasCellKey = true;
                    Console.ReadLine();
                    JailCell();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"You decide that you are not hungry, and the napkin is just a jab\n" +
                        $"from when the guard {npcName} called you a dirty piece of trash.\n\n" +
                        $"You turn away from your lunch.");
                    Console.ReadLine();
                    JailCell();
                }
            }
            else if (cellResponse == "2" && hasCellKey)
            {
                Console.Clear();
                Console.WriteLine("The food is the cafeteria's finest, same gruel that they've been slinging since day one.\n" +
                    "Without the napkin here, there's nothing of note.\n\n" +
                    "You decide to leave the so-called food be.");
                Console.ReadLine();
                JailCell();
            }
            else if (cellResponse == "3")
            {
                Console.Clear();
                Console.WriteLine("Ahh, the trusty old toilet-sink combo. This thing has been your companion through and through.\n\n" +
                    "It's held and embraced you while the cafeteria food held you hostage. If you're planning to escape today,\n\n" +
                    "there is nothing here that would want for your journey.\n\n" +
                    "You decide to turn back to your cell.");
                Console.ReadLine();
                JailCell();
            }
            else if (cellResponse == "4")
            {
                Console.Clear();
                Console.WriteLine("You decide that there's nothing important to check out in your room. It's always been the same,\n" +
                    "always will be. Might as well spend this time the way you usually do and catch some shut eye.\n\n" +
                    "That is until your slumber is met with a clanging that startles you awake.\n" +
                    "The guard outside is banging his baton against the bars of your cell.\n" +
                    "The nurse next to him is obviously displeased with the manner he chose to wake you\n\n" +
                    "'Hey, wake up in there! It's time for your appointment.'\n\n" +
                    "What do you do?\n\n" +
                    "1. Go along with the nurse.\n" +
                    "2. 'Screw off man, I'm not going anywhere'.\n\n");
                string cellResponse4 = Console.ReadLine();
                if (cellResponse4 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("The guard looks at you, almost like he's disappointed you didn't put up a fight.\n\n" +
                        "'Alright, come along then, but stay where I can see you.'\n\n" +
                        "You proceed to get up and follow the nurse to your appointment.");
                    Console.ReadLine();
                    NursesOffice();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("The guard's face seems to light up.\n\n" +
                        "'Ohoho! Alright, I've been waiting for this!'\n\n" +
                        "He proceeds to pummel you with his baton. All you hear is him huffing with each swing,\n" +
                        "while the nurse screams and runs to get help.\n\n" + //Possibly too dark?
                        "You are not escaping today. Game over.");
                    Console.ReadLine();
                    Console.Clear();
                    RunGame game = new RunGame();
                    game.Run();
                }
            }
            else if (cellResponse == "5" && !hasCellKey)
            {
                Console.Clear();
                Console.WriteLine("You try to open the door, but it is locked shut. You turn back to your cell.");
                Console.ReadLine();
                JailCell();
            }
            else if (cellResponse == "5" && hasCellKey)
            {
                Console.Clear();
                Console.WriteLine("You try to open the door, but even the key doesn't seem to help. It may come in user later.");
                Console.ReadLine();
                JailCell();
            }
        }

        public void NursesOffice()
        {
            Console.Clear();
            Console.WriteLine("You arrive in the nurse's room and are seated on the examination table.\n" +
                "You are a bit thrown off by how bright the room is thanks to the vastly superior windows.\n" +
                "As you sit in on the examination chair, the nurse approaches you.\n\n" +
                "'Okay, as usual with inmates with memory loss, we are going to ask you a few basic questions, then we'll progress to more difficult ones.'\n\n" +
                "'First, where are you right now?'\n\n");
            string location = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"'That's right, you are in {location}'s finest prison.\n\n" +
                $"Next up, how long have you been here?'\n\n");
            string nurseResponse1 = Console.ReadLine().ToLower();
            if (nurseResponse1 == "3 months" || nurseResponse1 == "three months")
            {
                Console.Clear();
                Console.WriteLine("'That is correct, you have been here for three months. Glad to hear you're keeping it together,\n" +
                    "a few others tend to lose track of time during their stay here.'\n\n" +
                    "Now it's time for some mildly harder questions.");
                Console.ReadLine();
                HarderQuestions();
                //    "'And that concludes the checkup! You can go with the guard now.'\n\n" +
                //    "As you get up, the guard is there to greet you at the door of the nurse's office.\n\n" +
                //    "'It's chow-time, bub. Get yourself to the cafeteria'\n\n" +
                //    "You leave the nurse's office and head into the drab hallway, making your way to the cafeteria.");
                //Console.ReadLine();
                //Cafeteria();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("'Huh... my records show you being here for 3 months. Well, it's fairly common\n" +
                    "for inmates to lose track of time during their time here, so just try to remember next time, will you?'\n\n" +
                    "Now it's time for some mildly harder quetions.");
                Console.ReadLine();
                HarderQuestions();
                //    "'In the meantime, you're free to go with the guard.'\n\n" +
                //    "As you get up, the guard is there to greet you at the door of the nurse's office.\n\n" +
                //    "'It's chow-time, bub. Get yourself to the cafeteria'\n\n" +
                //    "You leave the nurse's office and head into the drab hallway, making your way to the cafeteria.");
                //Console.ReadLine();
                //Cafeteria();
            }
        }

        public void HarderQuestions()
        {

            Random rndNum = new Random();
            Console.WriteLine("I am think of a number between 1 and 10, let's see if you can guess it within 5 guesses.");
            int randomNumber = rndNum.Next(1, 11);
            for (int i = 0; i < 5; i++)
            {
                int guess;
                Console.WriteLine("{0} tries left, try again.", 5 - i);
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == randomNumber)
                {
                    Console.WriteLine("That's correct! Now let's try a harder question...", i + 1);
                    Console.ReadLine();
                    break;
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("No, that's a bit higher than my number.");
                }
                else
                {
                    Console.WriteLine("No, that's a bit lower than my number.");
                }
                if (i == 4)
                {
                    Console.WriteLine("You have one guess left. Let's see if you can get it.");
                }
                if (i == 5)
                {
                    Console.Clear();
                    Console.WriteLine("I'm afraid you just aren't getting it. As part of a new initiative we are going to up dosages starting immediately.'\n" +
                        "She hands you some pills to take. What do you do?\n\n" +
                        "1. Take the pills.\n" +
                        "2. Toss the pills and make a run for it.");
                    string hardestResponse2 = Console.ReadLine();
                    if (hardestResponse2 == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("You take the pills in one fell swoop. You think that it shouldn't affect your goal today.\n\n" +
                            "But right as you are done thinking that, your vision begins to skew, and you fall out of the chair.\n\n" +
                            "You are not escaping today. Game over.");
                        Console.ReadLine();
                        Console.Clear();
                        RunGame game = new RunGame();
                        game.Run();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You throw the pills in the nurse's face and make a run for the door.\n" +
                            "Unfortunately, the guard is there and strikes you with the baton, knocking you out cold.\n\n" +
                            "You are not escaping today. Game over.");
                        Console.ReadLine();
                        Console.Clear();
                        RunGame game = new RunGame();
                        game.Run();
                    }
                }
            }
            //Console.Clear();
            //Console.WriteLine("'Okay! First up, what number between one and ten am I thinking of?'  (Use numpad)\n\n");
            //int nurseNumber = 7;
            //string playerGuess = Console.ReadLine();
            //int playGuesNum = Convert.ToInt32(playerGuess);
            //if (playGuesNum == nurseNumber)
            //{
            //    Console.WriteLine("Good job! I was thinking of 7! Now for a bit of a harder question...");
            //    Console.ReadLine();
            //}
            //else if (playGuesNum >= nurseNumber)
            //{
            //    Console.WriteLine("Not quite! Maybe try a smaller number.");
            //    Console.ReadLine();
            //    HarderQuestions();
            //}
            //else if (playGuesNum <= nurseNumber)
            //{
            //    Console.WriteLine("Not quite! Maybe try a larger number.");
            //    Console.ReadLine();
            //    HarderQuestions();
            //}

            Console.Clear();
            Console.WriteLine("Okay, now for the harder question. What is the color of the word below?");
            Console.ReadLine();

            string[] colors = { "Red", "Yellow", "Green", "Blue" };
            Random rndColor = new Random();
            int colorIndex = rndColor.Next(colors.Length);
            if (colors[colorIndex] == "Red")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (colors[colorIndex] == "Yellow")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (colors[colorIndex] == "Green")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (colors[colorIndex] == "Blue")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            // Change for color blind

            Console.WriteLine($"{colors[colorIndex]}");
            Console.ForegroundColor = ConsoleColor.White;
            string stroopAnswer = Console.ReadLine().ToLower();
            string colorAnswer = colors[colorIndex].ToLower();
            if (stroopAnswer != colorAnswer)
            {
                Console.WriteLine("\nGood job! Other inmates have answered differently and we've unfortunately had to up their\n" +
                    "doses because of it. Anyways! You're free to go along with the guard now.\n\n" +
                    "As you get up, the guard is there to greet you at the door of the nurse's office.\n\n" +
                    "'It's chow-time, bub. Get yourself to the cafeteria'\n\n" +
                    "You leave the nurse's office and head into the drab hallway, making your way to the cafeteria.");
                Console.ReadLine();
                Cafeteria();
            }
            else if (stroopAnswer == colorAnswer)
            {
                Console.WriteLine("\nHmm... I'm afraid that's incorrect, the color of the word is green. As part of a new initiative we are going to up dosages starting immediately.'\n" +
                    "She hands you some pills to take. What do you do?\n\n" +
                    "1. Take the pills.\n" +
                    "2. Toss the pills and make a run for it.");
                string hardestResponse = Console.ReadLine();
                if (hardestResponse == "1")
                {
                    Console.Clear();
                    Console.WriteLine("You take the pills in one fell swoop. You think that it shouldn't affect your goal today.\n\n" +
                        "But right as you are done thinking that, your vision begins to skew, and you fall out of the chair.\n\n" +
                        "You are not escaping today. Game over.");
                    Console.ReadLine();
                    Console.Clear();
                    RunGame game = new RunGame();
                    game.Run();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You throw the pills in the nurse's face and make a run for the door.\n" +
                        "Unfortunately, the guard is there and strikes you with the baton, knocking you out cold.\n\n" +
                        "You are not escaping today. Game over.");
                    Console.ReadLine();
                    Console.Clear();
                    RunGame game = new RunGame();
                    game.Run();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("'I'm afraid that is just plain wrong. We're going to need to up your dosage to correct this.'\n\n" +
                    "The nurse tilts your head back and throws some pills into your mouth, followed by water.\n" +
                    "You start to worry how this would affect you, then your vision starts to skew, and you fall to the floor.\n\n" +
                    "You are not escaping today. Game Over.");
                Console.ReadLine();
                RunGame game = new RunGame();
                game.Run();
            }





            //    int randomNumber = rndNum.Next(1, 11);
            //    string hardResponse1 = Console.ReadLine();
            //    int hardRespNumb = Convert.ToInt32(hardResponse1);
            //    if (hardRespNumb == randomNumber)
            //    {
            //        Console.WriteLine("That is correct! Good job! Now for a harder question.");
            //        Console.ReadLine();
            //    }
            //    else if (hardRespNumb >= randomNumber)
            //    {
            //        Console.WriteLine("Not quite! Try a smaller number.");
            //        Console.ReadLine();
            //    }
            //    else if (hardRespNumb <= randomNumber)
            //    {
            //        Console.WriteLine("Not quite! Try a larger number.");
            //        Console.ReadLine();
            //    }

            //    //int hardRespInt = Convert.ToInt32(hardResponse1);

            //    //string[] hardNumb = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            //    //if (hardNumb.Any(hardResponse1.Contains)/* || hardRespInt <= 10 || hardRespInt >= 0*/)
            //    //{
            //    //    Console.WriteLine($"\nThat is correct, I am holding up {hardResponse1} fingers");
            //    //    Console.ReadLine();
            //    //}

            //    Console.Clear();
            //    Color[] colors = { Color.Yellow, Color.Red, Color.Green, Color.Blue, Color.Purple, Color.Orange };
            //    string[] words = { "yellow", "red", "green", "blue", "purple", "orange" };
            //    string[] randomColors = words.OrderBy(x => randColor.Next()).ToArray();
            //    Console.WriteLine($"What color is the word below?\n\n" +
            //        $"{randomColors}");
            //    string stroopResponse = Console.ReadLine();


            //    ////////////////////////////////////////////////////////

            //    Console.Clear();
            //    Console.WriteLine("'Alright! That concludes the test! You are free to go your next scheduled activity.'\n\n" +
            //        "As you get up, the guard is there to greet you at the door of the nurse's office.\n\n" +
            //        "'It's chow-time, bub. Get yourself to the cafeteria'\n\n" +
            //        "You leave the nurse's office and head into the drab hallway, making your way to the cafeteria.");
            //    Console.ReadLine();
            //    Cafeteria();

        }
        public void Cafeteria()
        {
            string[] password = { "hamburger", "popcorn", "pizza", "quesadilla" };
            Random randPass = new Random();
            int index = randPass.Next(password.Length);
            Console.Clear();
            Console.WriteLine("You enter the cafeteria as it is bustling with activity. The chow-line is moving at the\n" +
                "standard snail's pace, the group that tends to be a bit rougher isn't doing doing their usual brooding,\n" +
                "but is instead chatting up something fierce, and your spot remains vacant. It's a guaranteed spot as many \n" +
                "choose not to smell the fragance that seeps out from the restrooms five feet away.\n\n" +
                "What do you choose to do?\n\n" +
                "1. Enter the chow-line.\n" +
                "2. Wander over to the group.\n" +
                "3. Sit in your seat.\n" +
                "4. Go back to your cell.\n\n");
            string cafeResponse1 = Console.ReadLine();
            if (cafeResponse1 == "1" && !chowBerating)
            {
                Console.Clear();
                Console.WriteLine("You decide to enter the chow-line to see what is on the menu.\n" +
                    "You grab a tray and keep pace behind the inmate in front of you. As you reach the food,\n" +
                    "the inmate working the chow-line grabs your tray.\n\n" +
                    "'You dumb or somethin'?! We already sent your food to you! I REALLY hope you ate it. We're all VERY concerned\n" +
                    "about your eating habits. Matter of fact, you look full, how about you talk to the gang about how delicious\n" +
                    "your meal was. I'm sure they'd be very interested.'\n\n" +
                    "He takes your tray away and you leave the chow-line, reconsidering your options.");
                Console.ReadLine();
                chowBerating = true;
                Cafeteria();
            }
            else if (cafeResponse1 == "1" && chowBerating)
            {
                Console.Clear();
                Console.WriteLine("You re-enter the chow-line, hoping to make sense of what went down earlier.\n" +
                    "The inmate working the chow-line approaches you, visibly upset.\n\n" +
                    "'Are you serious right now?! I couldn't have been more clear earlier. Go talk to the group.\n" +
                    "They'll be interested to hear about your meal.'\n\n" +
                    "You leave the chow-line, and you reconsider your options.");
                Console.ReadLine();
                Cafeteria();
            }
            else if (cafeResponse1 == "2" && !fatTonyInfo)

            {
                Console.Clear();
                Console.WriteLine("As you approach the group, a hush starts to fall over their discusion, heads all turning\n" +
                    "to size you up. You start to get a feeling this wasn't the best idea. The inmate nearest the your end of\n" +
                    "the table leans closer to you.\n\n" +
                    "'So... did you enjoy your meal?'\n\n" +
                    "How do you respond?\n\n" +
                    "1. 'Yeah, it was pretty good this time around!\n" +
                    "2. 'What? Was there something special about it? The food here sucks.\n" +
                    "3. 'Yep, ate everything on my place' (look down and tap your shoe)\n\n");
                string chowGroupResp = Console.ReadLine();
                if (chowGroupResp == "1")
                {
                    Console.Clear();
                    fatTonyInfo = true;
                    Console.WriteLine($"The inmate eyes you up and down, considering your response for a moment.\n\n" +
                        $"'Yeah, I think we're good. Okay, what you are to do next is go out to the yards and find Big Tony.\n" +
                        $"Apparently he has some piece of information that'll drive all of this home. But Big Tony is a bit paranoid\n" +
                        $"about this plan, so you need to use the password of {password[index]}. Say that, and we'll be one step closer to getting out of here.\n\n" +
                        $"1. Head to the yard.\n" +
                        $"2. Stay in the cafeteria\n\n");
                    string chowGroupResp2 = Console.ReadLine();
                    if (chowGroupResp2 == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("You are one step closer to getting yourself, and apparently others, out of here. You head to the yard.");
                        Console.ReadLine();
                        PrisonYard();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You decide to take in the cafeteria a bit more");
                        Console.ReadLine();
                        Cafeteria();
                    }
                }
                else if (chowGroupResp == "2")
                {
                    Console.Clear();
                    Console.WriteLine("The group doesn't seem to like your answer. They turn their gaze from you to inmate who was speaking to you.\n" +
                        "You wait there for a response for what seems like minutes, when the inmate finally says,\n\n" +
                        "'Do it'\n\n");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("They all slowly stand up and make their way towards you. As you turn to leave, you realize a hulking inmate is already there.\n" +
                        "They proceed to surround and restrain you. The lead inmate makes his way through the group and meets you face-to-face.\n\n" +
                        "'We were ALL depending on this. You screwed ALL of us. You have this coming.'\n\n" +
                        "He and the inmates proceed to attack you. It goes dark, and all you hear are guards yelling, and an alarm blaring.\n\n" +
                        "You are not escaping today. Game over.");
                    Console.ReadLine();
                    Console.Clear();
                    RunGame game = new RunGame();
                    game.Run();
                }
                else if (chowGroupResp == "3")
                {
                    Console.Clear();
                    fatTonyInfo = true;
                    Console.WriteLine($"'Okay, not so obvious!' Glad you go it. Look, we're SO close to this. Okay, what you are to do\n" +
                        $"next is go out to the yards and find Big Tony. Apparently he has some piece of information that'll drive all\n" +
                        $"of this home. But Big Tony is a bit paranoid about this plan, so you need to use the password of {password[index]}.\n" +
                        $"Say that, and we'll be one step closer to getting out of here.\n\n" +
                        $"1. Head to the yard.\n" +
                        $"2. Stay in the cafeteria\n\n");
                    string chowGroupResp3 = Console.ReadLine();
                    if (chowGroupResp3 == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("You are one step closer to getting yourself, and apparently others, out of here. You head to the yard.");
                        Console.ReadLine();
                        PrisonYard();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You decide to take in the cafeteria a bit more");
                        Console.ReadLine();
                        Cafeteria();
                    }
                }

            }
            else if (cafeResponse1 == "2" && fatTonyInfo)
            {
                Console.Clear();
                Console.WriteLine("You approach the table again.\n\n" +
                    "'Man, we already told you how to go about this. Get a move on and don't mess this up!'\n\n" +
                    "You return to the cafe entrance.");
                Console.ReadLine();
                Cafeteria();
            }
            else if (cafeResponse1 == "3")
            {
                Console.Clear();
                Console.WriteLine("You decide to head over to the familiar spot and sit down. No other inmate is around to\n" +
                    "accompany you, only the stench creeping out from the restrooms. You've decided you've had enough of this\n" +
                    "terrible isolation, and head back to the front of the cafeteria.");
                Console.ReadLine();
                Cafeteria();
            }
            else if (cafeResponse1 == "4" && hasCellKey)
            {
                Console.Clear();
                Console.WriteLine("You make your way back to your cell.");
                Console.ReadLine();
                BackToCell();
            }
            else if (cafeResponse1 == "4" && !hasCellKey)
            {
                Console.Clear();
                Console.WriteLine("You make your way back to your cell.");
                Console.ReadLine();
                BackToCellNoKey();
            }
            else if (cafeResponse1 == "4" && secGuardInfo && !hasCellKey)
            {
                Console.Clear();
                Console.WriteLine("You make your way back to your cell.");
                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("As you approach your cell, you see a group of guards around your cell. Just as you\n" +
                    "start thinking you should head back, one guard notices you and send the group over to you. They restrain you.\n\n" +
                    "'You mind telling me where you found this?'\n\n" +
                    "He brings up his hand, inside a folded napking. He starts unfolding it to reveal a key hidden inside.\n\n" +
                    "'Yeah... looks like you've lost your freedom for a bit longer.'\n\n" +
                    "They toss you back in the cell and lock it.\n\n" +
                    "You are not escaping today. Game over.");
                Console.ReadLine();
                Console.Clear();
                RunGame game = new RunGame();
                game.Run();
            }
        }
        public void BackToCell()
        {
            Console.Clear();
            Console.WriteLine("You look around the room and see your well-used toilet-sink combo,\n" +
                "a high-set window, and the bars you've been viewing for the past three months, with\n" +
                "a fresh tray of food near the sliding iron door.\n\n" +
                "What do you do?\n\n" +
                "1. Examine the window.\n" +
                "2. Examine the food.\n" +
                "3. Examine the toilet-sink.\n" +
                "4. Back to cafeteria.\n" +
                "What do you do?\n\n");
            string cellResponseA = Console.ReadLine();
            if (cellResponseA == "1")
            {
                Console.Clear();
                Console.WriteLine("The window is just as wide as your face, but is set so high that you need to stand\n" +
                    "on the tips of your toes to see out of it.\n\n" +
                    "What you manage to see isn't much, just some barbed-wire fencing surrounding the yard you and\n" +
                    "your fellow inmates share for rec time.\n\n" +
                    "You decide that what's there isn't much to look at. You turn from the window...");
                Console.ReadLine();
                BackToCell();
            }
            else if (cellResponseA == "2")
            {
                Console.Clear();
                Console.WriteLine("The food is the cafeteria's finest, same gruel that they've been slinging since day one.\n" +
                    "Without the napkin here, there's nothing of note.\n\n" +
                    "You decide to leave the so-called food be.");
                Console.ReadLine();
                BackToCell();
            }
            else if (cellResponseA == "3")
            {
                Console.Clear();
                Console.WriteLine("Ahh, the trusty old toilet-sink combo. This thing has been your companion through and through.\n\n" +
                    "It's held and embraced you while the cafeteria food held you hostage. If you're planning to escape today,\n\n" +
                    "there is nothing here that would want for your journey.\n\n" +
                    "You decide to turn back to your cell.");
                Console.ReadLine();
                BackToCell();
            }
            else
            {
                Console.WriteLine("You make your way back to the cafeteria.");
                Console.ReadLine();
                Cafeteria();
            }
        }
        public void BackToCellNoKey()
        {
            Console.Clear();
            Console.WriteLine("You look around the room and see your well-used toilet-sink combo,\n" +
                "a high-set window, and the bars you've been viewing for the past three months, with\n" +
                "a fresh tray of food near the sliding iron door.\n\n" +
                "What do you do?\n\n" +
                "1. Examine the window.\n" +
                "2. Examine the food.\n" +
                "3. Examine the toilet-sink.\n" +
                "4. Back to cafeteria.\n" +
                "What do you do?\n\n");
            string cellResponseA = Console.ReadLine();
            if (cellResponseA == "1")
            {
                Console.Clear();
                Console.WriteLine("The window is just as wide as your face, but is set so high that you need to stand\n" +
                    "on the tips of your toes to see out of it.\n\n" +
                    "What you manage to see isn't much, just some barbed-wire fencing surrounding the yard you and\n" +
                    "your fellow inmates share for rec time.\n\n" +
                    "You decide that what's there isn't much to look at. You turn from the window...");
                Console.ReadLine();
                BackToCellNoKey();
            }
            else if (cellResponseA == "2")
            {
                Console.Clear();
                Console.WriteLine("The food is the cafeteria's finest, same gruel that they've been slinging since day one.\n" +
                    "Just as you second-guess you being hungry enough to eat any of that, you notice that this time\n" +
                    "lunch has come with a napkin, which is rare considering the most you've ever been given is a spoon.\n\n" +
                    "What do you decide to do?\n\n" +
                    "1. Examine the napkin.\n" +
                    "2. Leave the so-called food be.\n\n");
                string cellResponse2 = Console.ReadLine();
                if (cellResponse2 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("As you unfold the napkin, a key falls out onto the tray, straight into the gravy.\n" +
                        "You wipe it off and place it inside your shoe. This may come in handy.\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("***YOU'VE GAINED A KEY***\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You stand up and consider your cell once more.");
                    hasCellKey = true;
                    Console.ReadLine();
                    BackToCellNoKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"You decide that you are not hungry, and the napkin is just a jab\n" +
                        $"from when the guard {npcName} called you a dirty piece of trash.\n\n" +
                        $"You turn away from your lunch.");
                    Console.ReadLine();
                    BackToCellNoKey();
                }
            }
            else if (cellResponseA == "3")
            {
                Console.Clear();
                Console.WriteLine("Ahh, the trusty old toilet-sink combo. This thing has been your companion through and through.\n\n" +
                    "It's held and embraced you while the cafeteria food held you hostage. If you're planning to escape today,\n\n" +
                    "there is nothing here that would want for your journey.\n\n" +
                    "You decide to turn back to your cell.");
                Console.ReadLine();
                BackToCellNoKey();
            }
            else
            {
                Console.WriteLine("You make your way back to the cafeteria.");
                Console.ReadLine();
                Cafeteria();
            }
        }

        public void PrisonYard()
        {
            Console.Clear();
            Console.WriteLine("You enter a long hallway lit by flourescent lights, the only natural light coming from\n" +
                "the doors at the end leading to the yard. As you push through the doors you are embraced by the light and\n" +
                "heat of the sun. For a moment you feel free, with nothing holding you back. The mirage quickly dissappears as\n" +
                "you open your eyes. The yard is completely surrounded by fencing with guard towers on each corner. You are constantly\n" +
                "supervised. The majority of activity is focused on the game of basketball happening on the far end, which is a vast contrast\n" +
                "to the subtle grunts of those working out nearest the door.\n\n" +
                "You need to find Fat Tony and figure out your next step in escaping the prison.\n\n" +
                "Where do you go?\n\n" +
                "1. Basketball Courts\n" +
                "2. Workout area\n" +
                "3. Back inside\n\n");
            string yardResponse = Console.ReadLine();
            if (yardResponse == "1")
            {
                BasketballCourt();
            }
            else if (yardResponse == "2")
            {
                WorkoutArea();
            }
            else if (yardResponse == "3")
            {
                Console.Clear();
                Console.WriteLine("You decide that you may have missed something, and head back in to the cafeteria.");
                Console.ReadLine();
                Cafeteria();
            }
            void BasketballCourt()
            {
                Console.Clear();
                Console.WriteLine("You head over to the basketball courts. The game of shirts vs skins is intense.\n" +
                    "All inmates are giving it their all, and the crowd is no different, cheering for their favorites,\n" +
                    "jeering those they want to slip up. As you scan the crowd you can make out an obese man sitting on the bleachers.\n\n" +
                    "What do you decide to do?\n\n" +
                    "1. Try to play a game of basketball\n" +
                    "2. Approach the obese man\n" +
                    "3. Go back to the yard\n\n");
                string yardResponse2 = Console.ReadLine();
                if (yardResponse2 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("You try your best to get in on the game, but no one notices you. You decide to back off.");
                    Console.ReadLine();
                    BasketballCourt();
                }
                else if (yardResponse2 == "2")
                {
                    Console.Clear();
                    Console.WriteLine("The obese man is sitting in the middle of the bleachers, front-row, the most expensive seat\n" +
                        "in the entire prison. He notices you approach him from the corner of his eye, but does nothing to acknowledge your presence.\n\n" +
                        "What do you do?\n\n" +
                        "1. 'Hey Fatso! How're things hanging?'\n" +
                        "2. 'Excuse me, are you Fat Tony?'\n" +
                        "3. Turn away and try again later.\n\n");
                    string yardResponse3 = Console.ReadLine();
                    if (yardResponse3 == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("The big man does nothing, just continues to watch the game motionless. Next thing you know\n" +
                            "an inmate grabs the back of your collar and takes you to the ground. Next thing you notice is a man looming\n" +
                            "over you. His tattoos alone tell you that you've made a mistake.\n\n" +
                            "'Wish it didn't have to be this way, but it's obivous you're a mistake just waiting to happen.'");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("'Wait...'\n");
                        Console.ReadLine();
                        Console.WriteLine($"\n'Heh heh heh... you've got gall, I'll give you that.'\n\n" +
                            $"From the bass in his voice and uncanny Queens accent you decide this man is 100% a mobster stereotype.\n\n" +
                            $"'So, you're the one leading the charge, eh? Well, hopefully that bravado works in your favor, cuz your\n" +
                            $"next bit is gonna be hard. In just about 15 minutes that shmuck of a guard {npcName} is gonna be in\n" +
                            $"the showers. You're gonna head in there, steal their uniform, and open the loading doors. We'll be ready\n" +
                            $"and waiting for you. But I tell you this: You mess up in any way, no matter where you end up, I have guys\n" +
                            $"everywhere that will make you pay, you understand?'\n\n" +
                            $"1. <nod>\n" +
                            $"2. 'You know I'm good for this.\n" +
                            $"3. 'No'\n\n");
                        string yardResponse4 = Console.ReadLine();
                        if (yardResponse4 == "1" || yardResponse4 == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("'Alright good, now go on outta here before any guards think we're\n" +
                                "actually up to somethin'. Remember, showers, then loading area doors, then we're home free.'\n\n" +
                                "You are almost there. You decide to head to the showers.");
                            secGuardInfo = true;
                            Console.ReadLine();
                            LockerRoom();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("His face falls, as if he's no longer amused by your antics.\n\n" +
                                "'Okay then... Luis, continue doing what you do best. Looks like we have some replanning to do.'\n\n");
                            Console.Clear();
                            Console.WriteLine("The tattooed man, who we can now assume is Luis, stands over you once again, fist cocked. As the fist\n" +
                                "comes down, you start to think that may have messed up. That would be correct.\n\n" +
                                "You get knocked out.\n\n" +
                                "You are not escaping today. Game over.");
                            Console.ReadLine();
                            Console.Clear();
                            RunGame game = new RunGame();
                            game.Run();
                        }
                    }
                    else if (yardResponse3 == "2" && fatTonyInfo)
                    {
                        Console.Clear();
                        Console.WriteLine($"'Depends on who's askin'. You got something to tell me?'\n\n" +
                            $"1. 'Yeah, I'm here to escape the jail'.\n" +
                            $"2. 'Yeah, {password}.'\n\n");
                        string yardResponse5 = Console.ReadLine();
                        if (yardResponse5 == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("'That so?'\n\n" +
                                "Fat Tony scans you up and down, then continues watching the game.\n\n" +
                                "'No you're not. I have no idea who you are. Get lost.\n\n'" +
                                "You back away from the bleachers, but continue watching the game.");
                            Console.ReadLine();
                            BasketballCourt();
                        }
                        else if (yardResponse5 == "2")
                        {
                            Console.Clear();
                            Console.WriteLine($"\n'Heh heh heh... you've got gall, I'll give you that.'\n\n" +
                            $"From the bass in his voice and uncanny Queens accent you decide this man is 100% a mobster stereotype.\n\n" +
                            $"'So, you're the one leading the charge, eh? Well, hopefully that bravado works in your favor, cuz your\n" +
                            $"next bit is gonna be hard. In just about 15 minutes that shmuck of a guard {npcName} is gonna be in\n" +
                            $"the showers. You're gonna head in there, steal their uniform, and open the loading doors. We'll be ready\n" +
                            $"and waiting for you. But I tell you this: You mess up in any way, no matter where you end up, I have guys\n" +
                            $"everywhere that will make you pay, you understand?'\n\n" +
                            $"1. <nod>\n" +
                            $"2. 'You know I'm good for this.\n" +
                            $"3. 'No'\n\n");
                            string yardResponse6 = Console.ReadLine();
                            if (yardResponse6 == "1" || yardResponse6 == "2")
                            {
                                Console.Clear();
                                Console.WriteLine("'Alright good, now go on outta here before any guards think we're\n" +
                                    "actually up to somethin'. Remember, showers, then loading area doors, then we're home free.'\n\n" +
                                    "You are almost there. You decide to head to the showers.");
                                secGuardInfo = true;
                                Console.ReadLine();
                                LockerRoom();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("His face falls, as if he's no longer amused by your antics.\n\n" +
                                    "'Okay then... Luis, do what you do best. Looks like we have some replanning to do.'\n\n");
                                Console.Clear();
                                Console.WriteLine("You feel a sudden push from behind that knocks you to the ground. As you turn over,\n" +
                                    "you see that Luis now has a fist cocked. As the fist starts to come down, you start to think that may\n" +
                                    "have messed up. That would be correct.\n\n" +
                                    "You get knocked out.\n\n" +
                                    "You are not escaping today. Game over.");
                                Console.ReadLine();
                                Console.Clear();
                                RunGame game = new RunGame();
                                game.Run();
                            }
                        }
                    }
                    else if (yardResponse3 == "2" && !fatTonyInfo)
                    {
                        Console.Clear();
                        Console.WriteLine($"'Depends on who's askin'. You got something to tell me?'\n\n" +
                            $"1. 'Yeah, I'm here to escape the jail'.\n\n");
                        string yardResponse7 = Console.ReadLine();
                        if (yardResponse7 == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("'That so?'\n\n" +
                                "Fat Tony scans you up and down, then continues watching the game.\n\n" +
                                "'No you're not. I have no idea who you are. Get lost.\n\n'" +
                                "You back away from the bleachers, but continue watching the game.");
                            Console.ReadLine();
                            BasketballCourt();
                        }
                    }
                }
                else if (yardResponse2 == "3")
                {
                    Console.Clear();
                    Console.WriteLine("You decide nt to interrupt the game nor those watching, and return to the yard.");
                    Console.ReadLine();
                    PrisonYard();
                }
            }
            void WorkoutArea()
            {
                Console.Clear();
                Console.WriteLine("As you approach, you notice about 5 inmates all working out.\n" +
                    "You see a larger man benchpressing like its nothing, and a few other average-sized inmates.\n\n" +
                    "What do you do?\n\n" +
                    "1. Approach the larger man.\n" +
                    "2. Try to get a worout in.\n" +
                    "3. Back away\n\n");
                string workoutResponse1 = Console.ReadLine();
                if (workoutResponse1 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("You approach the bench and the large man seems to ignore you. You continue to\n" +
                        "stand there until you hear a deep sigh from the large man as he sets the bar, apparently finished\n" +
                        "with his workout. As he approaches you, you realize that the garb made him appear more out-of-shape\n" +
                        "than he really is. As he stands there looming over you, he awaits your response.\n\n" +
                        "What do you do?\n\n" +
                        "1. 'Uhh... so are you Fat Tony?'\n" +
                        "2. Slowly back away.\n\n");
                    string workoutResponse2 = Console.ReadLine();
                    if (workoutResponse1 == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("The man starts turning beet red.\n\n" +
                            "'What, you think you're a funny man, huh?'\n\n" +
                            "He shoves you, gaining the attention of the guards on duty. They rush over and restrain\n" +
                            "both you and the larger man. As it settles, you see the larger man being escorted back inside, while\n" +
                            "another guard props you up.\n\n" +
                            "'Yeah sorry, son. You're going back to your cell too.'\n\n" +
                            "You're locked up for the rest of the day.\n\n" +
                            "You are not escaping today. Game over.");
                        Console.ReadLine();
                        Console.Clear();
                        RunGame game = new RunGame();
                        game.Run();
                    }
                    else
                    {
                        WorkoutArea();
                    }
                }
                else if (workoutResponse1 == "2")
                {
                    Console.Clear();
                    Console.WriteLine("You start pumping some iron for a few seconds. You breathe a bit more quickly, but walk away feeling energized.");
                    Console.ReadLine();
                    WorkoutArea();
                }
                else if (workoutResponse1 == "3")
                {
                    Console.Clear();
                    Console.WriteLine("You head back out to the yard.");
                    Console.ReadLine();
                    PrisonYard();
                }
            }

        }
        public void LockerRoom()
        {
            Console.Clear();
            Console.WriteLine("You arrive in the hallways where the locker rooms are held, guards' on the left and inmates' on the right.\n" +
                "The loading area is right ahead of you.\n\n" +
                "Which way do you go?\n\n" +
                "1. Guard-side\n" +
                "2. Inmate-side\n" +
                "3. Head into the loading area.\n" +
                "4. Back to the yard.\n\n");
            string lockerResponse1 = Console.ReadLine();
            if (lockerResponse1 == "1" && !hasCellKey)
            {
                Console.Clear();
                Console.WriteLine("You try to open the door, but obviously, it is locked.\n\n" +
                    "What do you do?\n\n" +
                    "1. Knock.\n" +
                    "2. Back away.\n\n");
                string lockerResponse2 = Console.ReadLine();
                if (lockerResponse2 == "1")

                {
                    Console.Clear();
                    Console.WriteLine("You knock on the door...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Nothing happens. You back up to the hallway.");
                    Console.ReadLine();
                    LockerRoom();
                }
                else if (lockerResponse2 == "2")
                {
                    Console.Clear();
                    Console.WriteLine("You back away to the middile of the hallway.");
                    Console.ReadLine();
                    LockerRoom();
                }
            }
            else if (lockerResponse1 == "1" && hasCellKey)
            {
                Console.Clear();
                Console.WriteLine("You try to open the door, but obviously, it is locked.\n\n" +
                    "What do you do?\n\n" +
                    "1. Knock.\n" +
                    "2. Use key.\n" +
                    "3. Back away.\n\n");
                string lockerResponse3 = Console.ReadLine();
                if (lockerResponse3 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("You knock on the door...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Nothing happens. Anything else you'd like to try?\n\n" +
                        "1. The key...\n" +
                        "2. Nope! I'll go back to the hallway!\n\n");
                    string lockerResponse4 = Console.ReadLine();
                    if (lockerResponse4 == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("You reach into your shoe and dig out the key hidden inside. As you unlock the door,\n" +
                            "you start to hear guards inside. Are you sure this is the route you'd like to go with?\n\n" +
                            "1. Continue inside.\n" +
                            "2. Head back into the hallway.\n\n");
                        string lockerResponse5 = Console.ReadLine();
                        if (lockerResponse5 == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("Determined, you head inside.");
                            Console.ReadLine();
                            GuardLockerRoom();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("You decide to reconsider your options and head back into the hallway.");
                            Console.ReadLine();
                            LockerRoom();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You return to the hallway...");
                        Console.ReadLine();
                        LockerRoom();
                    }

                }
                else if (lockerResponse3 == "2")
                {
                    Console.Clear();
                    Console.WriteLine("You reach into your shoe and dig out the key hidden inside. As you unlock the door,\n" +
                        "you start to hear guards inside. Are you sure this is the route you'd like to go with?\n\n" +
                        "1. Continue inside.\n" +
                        "2. Head back into the hallway.\n\n");
                    string lockerResponse5 = Console.ReadLine();
                    if (lockerResponse5 == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Determined, you head inside.");
                        Console.ReadLine();
                        GuardLockerRoom();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You decide to reconsider your options and head back into the hallway.");
                        Console.ReadLine();
                        LockerRoom();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You back away into the hallway.");
                    Console.ReadLine();
                    LockerRoom();
                }
            }
            else if (lockerResponse1 == "2")
            {
                Console.Clear();
                Console.WriteLine("You head into the inmate locker room. Since you're in jail, your lot doesn't really have lockers,\n" +
                    "really only showers, and none in use.\n\n" +
                    "What do you do?\n\n" +
                    "1. Take a Shower.\n" +
                    "2. Go back to the hallway.\n\n");
                string lockerResponse6 = Console.ReadLine();
                if (lockerResponse6 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("You head into the shower and wash up. Once you are finished and dressed, you head back out\n" +
                        "into the hallway, just as a guard leaves the locker room, the hydraulics still propping the door open.\n\n" +
                        "What do you do?\n\n" +
                        "1. Go for the door.\n" +
                        "2. Stay in the hallway.\n\n");
                    hasShowered = true;
                    string lockerResponse7 = Console.ReadLine();
                    if (lockerResponse7 == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("You head through the door, into the Guard's locker room.");
                        Console.ReadLine();
                        GuardLockerRoom();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You stay in the hallway.");
                        Console.ReadLine();
                        LockerRoom();
                    }
                }
                else if (lockerResponse6 == "1" && hasShowered)
                {
                    Console.Clear();
                    Console.WriteLine("You head into the shower and wash up.Once you are finished and dressed, you head back out\n" +
                        "into the hallway, just as a guard leaves the locker room, the hydraulics still propping the door open.\n\n" +
                        "You head back into the hallway.");
                    Console.ReadLine();
                    LockerRoom();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You head back into the hallway.");
                    Console.ReadLine();
                    LockerRoom();
                }
            }
            else if (lockerResponse1 == "3" && hasUniform)
            {
                Console.Clear();
                Console.WriteLine("The guard watching the entrance to the loading area gives you a nod as you enter. You're almost there.");
                Console.ReadLine();
                LoadingArea();
            }
            else if (lockerResponse1 == "3" && !hasUniform && !hasOutfit)
            {
                Console.Clear();
                Console.WriteLine("As you approach the loading area, the guard posted out front stops you.\n\n" +
                    "'Whoa, what business do you have here? Get outta here.'\n\n" +
                    "You return to the hallway, thinking of your next step.");
                Console.ReadLine();
                LockerRoom();
            }
            else if (lockerResponse1 == "3" && hasOutfit)
            {
                Console.Clear();
                Console.WriteLine("As you approach the loading area, the guard posted out front stops you.\n\n" +
                    "'Whoa, what are you doing here? Visitors are to enter through the visitation entrance. You're going to have to wait here as I call this in.'\n\n" +
                    "You post up there as two guards come to collect you.\n\n" +
                    "You are not escaping today. Game over.");
                Console.ReadLine();
                Console.Clear();
                RunGame game = new RunGame();
                game.Run();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You head back to the yard.");
                Console.ReadLine();
                PrisonYard();
            }
        }
        public void GuardLockerRoom()
        {
            Console.Clear();
            Console.WriteLine($"As you enter the guards' locker room, you notice guard {npcName} showering like Fat Tony said, guard\n" +
                $"uniform folded neatly on the bench along with his civilian clothes. As you continue to scan the room, you notice two guards\n" +
                $"leave through an emergency door, one that apparently isn't hooked up to an alarm.\n\n" +
                $"What do you do?\n\n" +
                $"1. Make a run for the emergency door.\n" +
                $"2. Steal guard {npcName}'s uniform.\n" +
                $"3. Steal guard {npcName}'s civilian clothes.\n" +
                $"4. Go back into the hallway.\n\n");
            string guardLockResponse1 = Console.ReadLine();
            if (guardLockResponse1 == "1" && !hasUniform)
            {
                Console.Clear();
                Console.WriteLine("You make a mad dash towards the door, the taste of freedom just in front of you. On your way, a guard steps out\n" +
                    "of a shower and sees you. They call out for you to stop, but you're this close now, you're not stopping. You hit the door running,\n" +
                    "you do not and will not stop for anything. An alarm soon goes off, the music to your escape and your feet hitting the pavement is the applause.");
                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("You continue running until the alarm starts to become distant. A black car pulls up beside you,\n" +
                    "rear-window rolling down revealing a man inside.\n\n" +
                    "'Fat Tony--'\n\n" +
                    "A ringing hits your ears. You know how this ends. You escaped, but Fat Tony didn't. Meaning you escaped, but you didn't\n" +
                    "even make it out of eyesight of the prison.");
            }
            else if (guardLockResponse1 == "1" && hasUniform)
            {
                Console.Clear();
                Console.WriteLine("With the guards uniform on, you go out the emergency door and start walking towards the road.");
                Console.ReadLine();

                Console.Clear();
                Console.WriteLine($"A guard calls out to you.\n\n" +
                    $"'Hey! Where do you think you're going? You can't leave prison grounds while in uniform.'\n\n" +
                    $"As he approches, he seems to notice your nametag on the uniform, and now knows you aren't {npcName}.\n\n" +
                    $"'HEY I NEED BACKUP OVER HERE!'\n\n" +
                    $"'Okay, you're going back in.'\n\n" +
                    $"He takes you down, cuffs you, takes you back in, and throws you in the cell.\n\n" +
                    $"You are not escaping today. Game over.");
                Console.ReadLine();
                Console.Clear();
                RunGame game = new RunGame();
                game.Run();
            }
            else if (guardLockResponse1 == "1" && hasOutfit)
            {
                Console.Clear();
                Console.WriteLine("With the outfit on, you go out the emergency door and start walking towards the road.");
                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("This is it, you've made it. You left Fat Tony and the rest, but you've made it. This feels like the freshest air you've\n" +
                    "breathed, the warmest the sun has felt.\n\n" +
                    "You. Are. Free.");
                Console.ReadLine();
            }
            else if (guardLockResponse1 == "2" && !hasOutfit && !hasUniform)
            {
                Console.Clear();
                Console.WriteLine($"You slowly sneak over to the shower and steal {npcName}'s uniform.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***YOU'VE GAINED GUARD UNIFORM***\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                hasUniform = true;
                Console.ReadLine();
                GuardLockerRoom();
            }
            else if (guardLockResponse1 == "2" && hasUniform && !hasOutfit)
            {
                Console.Clear();
                Console.WriteLine("You already have the guard uniform!");
                Console.ReadLine();
                GuardLockerRoom();
            }
            else if (guardLockResponse1 == "2" && hasOutfit && !hasUniform)
            {
                Console.Clear();
                Console.WriteLine("You cannot have both outfits. Take the guard uniform, or keep civilian outfit?\n\n" +
                    "1. Civilian Outfit.\n" +
                    "2. Guard uniform.\n" +
                    "3. Back away.\n\n");
                string guardLockResponse2 = Console.ReadLine();
                if (guardLockResponse2 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("You decide to keep the civilian outfit.");
                    Console.ReadLine();
                    GuardLockerRoom();
                }
                else if (guardLockResponse2 == "2")
                {
                    Console.Clear();
                    Console.WriteLine("You take off the outfit and switch into the guard uniform.");
                    hasUniform = true;
                    hasOutfit = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("***YOU'VE LOST THE CIVILIAN OUTFIT***\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("***YOU'VE GAINED GUARD UNIFORM***\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    GuardLockerRoom();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You back away from the clothes.");
                    Console.ReadLine();
                    GuardLockerRoom();
                }
            }
            else if (guardLockResponse1 == "3" && !hasUniform && !hasOutfit)
            {
                Console.Clear();
                Console.WriteLine($"You slowly sneak over to the shower and steal {npcName}'s civilian clothes.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***YOU'VE GAINED CIVILIAN CLOTHES***\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                hasOutfit = true;
                Console.ReadLine();
                GuardLockerRoom();
            }
            else if (guardLockResponse1 == "3" && hasOutfit && !hasUniform)
            {
                Console.Clear();
                Console.WriteLine("You already have the civilian clothes!");
                Console.ReadLine();
                GuardLockerRoom();
            }
            else if (guardLockResponse1 == "3" && hasUniform && !hasOutfit)
            {
                Console.Clear();
                Console.WriteLine("You cannot have both outfits. Keep the guard uniform, or take the civilian clothes?\n\n" +
                    "1. Guard Uniform.\n" +
                    "2. Civilian outfit.\n" +
                    "3. Back away.\n\n");
                string guardLockResponse3 = Console.ReadLine();
                if (guardLockResponse3 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("You decide to keep the guard uniform.");
                    Console.ReadLine();
                    GuardLockerRoom();
                }
                else if (guardLockResponse3 == "2")
                {
                    Console.Clear();
                    Console.WriteLine("You take off the uniform and switch into the civilian outfit.");
                    hasUniform = false;
                    hasOutfit = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("***YOU'VE LOST THE GUARD UNIFORM***\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("***YOU'VE GAINED CIVILIAN CLOTHES***\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    GuardLockerRoom();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You back away from the clothes.");
                    Console.ReadLine();
                    GuardLockerRoom();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You exit the guard's locker room and enter the hallway.");
                Console.ReadLine();
                LockerRoom();
            }
        }
        public void LoadingArea()
        {
            Console.Clear();
            Console.WriteLine("As you enter, you see a single truck in the midst of being unloaded. It just so happens that the\n" +
                "crew unloading the truck belong to Fat Tony and the lot you saw in the cafeteria. To your right are stairs that\n" +
                "lead to the room overwatching the inmates.\n\n" +
                "What do you do?\n\n" +
                "1. Go right up the stairs.\n" +
                "2. Go to the truck.\n" +
                "3. Leave to the locker hallway.\n\n");
            string loadingResponse1 = Console.ReadLine();
            if (loadingResponse1 == "1")
            {
                Console.Clear();
                Console.WriteLine("As you head up and inside the room, you notice there is no one inside this room. You figure it must\n" +
                    "be Fat Tony's doing, that he has someone on the inside working for him. You see a wide control board at the front, a\n" +
                    "bunch of buttons with convenient text on top telling you what they do.\n\n" +
                    "What do you do?" +
                    "1. Press OPEN LOADING BAY DOORS.\n" +
                    "2. Throw the switch to turn out the lights.\n" +
                    "3. Press the red button that reads BACKUP\n" +
                    "4. Step away\n\n");
                string loadingResponse2 = Console.ReadLine();
                if (loadingResponse2 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("You press the button and see that the loading bay doors are open.\n\n" +
                        "What do you do now?\n\n" +
                        "1. Throw the switch to turn out the lights.\n" +
                        "2. Press the red button that reads BACKUP\n" +
                        "3. Step away\n\n");
                    string loadingResponse3 = Console.ReadLine();
                    if (loadingResponse3 == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("With the doors open and the lights out, the guards start to shout out. An inmate enters the room.\n\n" +
                            "'It's time, follow me!'\n\n" +
                            "You follow the inmate down the steps and into the back of the truck");
                        Console.ReadLine();
                        Truck();
                    }
                    else if (loadingResponse3 == "2")
                    {
                        Console.Clear();
                        Console.WriteLine($"An alarm sounds and guards run to each prisoner and restrain them, as another group of guards enter. They immediately\n" +
                            $"enter the room. One in particular notices that you are not {npcName}, and restrains you.\n\n" +
                            $"You were close, but you are not escaping today. Game over.");
                        Console.ReadLine();
                        Console.Clear();
                        RunGame game = new RunGame();
                        game.Run();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You step out of the room, back to the entrance.");
                        Console.ReadLine();
                        LoadingArea();
                    }
                }
                else if (loadingResponse2 == "2")
                {
                    Console.Clear();
                    Console.WriteLine("You throw the lights off, guards begin to shout out.\n\n" +
                        "What do you do next?\n\n" +
                        "1. Press OPEN LOADING BAY DOORS.\n" +
                        "2. Press the red buttom that reads BACKUP.\n" +
                        "3. Step away.\n\n");
                    string loadingResponse4 = Console.ReadLine();
                    if (loadingResponse4 == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("With the doors open and the lights out, the guards start to shout out. An inmate enters the room.\n\n" +
                            "'It's time, follow me!'\n\n" +
                            "You follow the inmate down the steps and into the back of the truck");
                        Console.ReadLine();
                        Truck();
                    }
                    else if (loadingResponse4 == "2")
                    {
                        Console.Clear();
                        Console.WriteLine($"An alarm sounds and guards run to each prisoner and restrain them, as another group of guards enter. They immediately\n" +
                            $"enter the room. One in particular notices that you are not {npcName}, and restrains you.\n\n" +
                            $"You were close, but you are not escaping today. Game over.");
                        Console.ReadLine();
                        Console.Clear();
                        RunGame game = new RunGame();
                        game.Run();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You step out of the room, back to the entrance.");
                        Console.ReadLine();
                        LoadingArea();
                    }
                }
                else if (loadingResponse2 == "3")
                {
                    Console.Clear();
                    Console.WriteLine($"An alarm sounds and guards run to each prisoner and restrain them, as another group of guards enter. They immediately\n" +
                        $"enter the room. One in particular notices that you are not {npcName}, and restrains you.\n\n" +
                        $"You were close, but you are not escaping today. Game over.");
                    Console.ReadLine();
                    Console.Clear();
                    RunGame game = new RunGame();
                    game.Run();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You step out of the room, back to the entrance.");
                    Console.ReadLine();
                    LoadingArea();
                }
            }
            else if (loadingResponse1 == "2")
            {
                Console.Clear();
                Console.WriteLine($"You approach the truck and stand at the driver-side door, driver still within.\n\n" +
                    $"Sorry boss, guards ordered me to stay indoors. Could we hurry this up, though? Once this is done I've got a date with a {password}. Yup, once it's nighttime, I'm gonna open that door and order it.'\n\n" +
                    $"You step away, back to the entrance.");
                Console.ReadLine();
                LoadingArea();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You head back to the locker hallway");
                Console.ReadLine();
                LockerRoom();
            }
        }
        public void Truck()
        {
            Console.Clear();
            Console.WriteLine("As you enter the back of the truck, you can tell there's about 7-10 other\n" +
                "people in their with you. The truck starts and everyone remains quiet as the truck exits the compound.\n\n");
            Console.ReadLine();
            Console.WriteLine("After what seems like a solid 30-minutes of silence, a single light brightens the back of the truck, Fat Tony standing in front of you.\n\n" +
                "'You did a good job today. You freed the lot of us. For that, I will be sure to make certain that you are set for life.'\n\n" +
                "A giant weight has lifted your shoulders. Not only did you escape, you'll be getting paid for helping others escape as well.\n\n" +
                "'You did such fine work in fact, I may call upon you later for another gig.'\n\n" +
                "Your good news of the day starts to fade, as not knowing what this man has in store for you starts to make you doubt what kind of future you'll have.");
            Console.ReadLine();
            Console.WriteLine("But for now, just congratulate yourself. You've escaped.");
            Console.ReadLine();

        }
    }
}
