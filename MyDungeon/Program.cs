// My Dungeon
Console.ForegroundColor = ConsoleColor.White;   // Changes colour of text
Console.WriteLine("The brave hero raced down the stairs two at a time and kicked open the door.");
Thread.Sleep(2000);
Console.WriteLine("They beheld a woman sat looking bored as if waiting for someone. Open seeing them she got up and remarked");
Thread.Sleep(2000);
Console.WriteLine("'My hero! pray, tell me what is your name?'");
Thread.Sleep(2000);                             // Pause for two seconds
Console.WriteLine("\nEnter your name");
string name = Console.ReadLine();
Console.WriteLine("\n'Well then " + name + ", thanks for saving me and I hope you have a wonderful day.'");
Thread.Sleep(2000);
Console.WriteLine("'Because it will be the last one you ever have.'");
Console.ForegroundColor = ConsoleColor.Red;
Thread.Sleep(2000);
Console.WriteLine("'Mwahahaha'");
Thread.Sleep(2000);
Console.WriteLine("'Mwahahaha'");
Thread.Sleep(2000);
Console.WriteLine("'Mwahahaha'");
Thread.Sleep(2000);
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Many hours and many evil laughs later...");
Thread.Sleep(2000);
Console.WriteLine(@" 
   _________________________________________________________
 /|     -_-                                             _-  |\
/ |_-_- _                                         -_- _-   -| \   
  |                            _-  _--                      | 
  |                            ,                            |
  |      .-'````````'.        '(`        .-'```````'-.      |
  |    .` |           `.      `)'      .` |           `.    |          
  |   /   |   ()        \      U      /   |    ()       \   |
  |  |    |    ;         | o   T   o |    |    ;         |  |
  |  |    |    ;         |  .  |  .  |    |    ;         |  |
  |  |    |    ;         |   . | .   |    |    ;         |  |
  |  |    |    ;         |    .|.    |    |    ;         |  |
  |  |    |____;_________|     |     |    |____;_________|  |  
  |  |   /  __ ;   -     |     !     |   /     `'() _ -  |  |
  |  |  / __  ()        -|        -  |  /  __--      -   |  |
  |  | /        __-- _   |   _- _ -  | /        __--_    |  |
  |__|/__________________|___________|/__________________|__|
 /                                             _ -        lc \
/   -_- _ -             _- _---                       -_-  -_ \");  // The @ allows for multi line comments
Thread.Sleep(2000);
Console.WriteLine("\n'My oh my, we are in trouble now aren't we?'");
Thread.Sleep(2000);
Console.WriteLine("'That's another fine mess you've gotten into.'");
Thread.Sleep(2000);
Console.WriteLine("'I told you not to go in there but would you listen to me? oh noooo.'");
Thread.Sleep(2000);
Console.WriteLine("'I'm only your brain, what do I matter?'");
Thread.Sleep(2000);
Console.WriteLine("'You heard the stories of the beautiful princess locked in this creepy place and rushed right in.'");
Thread.Sleep(2000);
Console.WriteLine("'If you want to get out of this " + name + " then we have to start working together.'");
Thread.Sleep(2000);
Console.WriteLine("'You're not much of a body admittedly, but it's the only one I have to work with right now.'");
Thread.Sleep(2000);
Console.WriteLine("'Plus if anything happens to you I'm toast.'");
Thread.Sleep(2000);
Console.WriteLine("\nYou look around and see nothing but walls and an empty bucket placed for reasons you do not even want to imagine.");
Thread.Sleep(2000);
Console.WriteLine("There is a door with no bars or any visible means of escape. That explains how you were brought here at least.\n");
Thread.Sleep(2000);
Console.WriteLine(@"Your choices are numerous, as in two. 

a) Lie on the floor and wait to be saved
b) Beg and plead for mercy
");  

string input = Console.ReadLine().ToLower();    // Converts input to lowercase

while (input != "a" && input != "b")        // Loops until a valid input is entered
{
    Console.WriteLine("Invalid input. Please enter 'a' or 'b'.");
    input = Console.ReadLine().ToLower();
}

Console.Clear();
if (input == "a")
{
    Console.WriteLine("Who would save a quitter like you who does not wish to play this wonderful game?!!");
    Thread.Sleep(2000);
    Console.WriteLine("Begone with you vile weakling and good riddance to thee!");
    Thread.Sleep(2000);
    Console.WriteLine("GAME OVER");
}
else if (input == "b")
{
    Console.WriteLine("You beg and plead for mercy, shouting to whoever is out there that you will do anything.");
    Thread.Sleep(2000);
    Console.WriteLine("You hear footsteps from outside. The door swings open after a few seconds and.... ");
    Thread.Sleep(2000);
    Console.WriteLine("It's the devious, dastardly, despicable, deadly, disgusting, definitely NOT a princess with a terrifying grin.");
    Thread.Sleep(4000);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("'Guess who?'");
    Thread.Sleep(2000);
    Console.WriteLine("'Was that my brave little hero " + name + " I could hear begging me to save them?'");
    Thread.Sleep(2000);
    Console.WriteLine("'Awww. did da nasty smelly dungeon fwighten them den'");
    Thread.Sleep(2000);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("She turns serious which is a relief after what you just heard.");
    Thread.Sleep(2000);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("'I will save you under one condition, you become my thrall for all eternity and do whatever I command.'\n");
    Thread.Sleep(2000);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(@"Another choice? Aren't we excited? So many possi... actually it's just two again I'm afraid.
a) Accept
b) Refuse
");
    input = Console.ReadLine().ToLower();

    Console.Clear();

    if (input == "a")
    {
        Console.WriteLine("Seeing no choice you give in to the temptress and become her thrall for eternity.");
        Thread.Sleep(2000);
        Console.WriteLine("Over time you lose yourself completely and live to please her in all things.");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You are so glad you opened that door and wish you had ignored your brain sooner.");
        Console.ForegroundColor = ConsoleColor.White;
        Thread.Sleep(2000);
        Console.WriteLine("THE END");
    }
    else if (input == "b")
    {
        Console.WriteLine("The temptress gazes at you for a moment, then simply turns back around and shuts the door.");
        Thread.Sleep(2000);
        Console.WriteLine("Better to die on your feet than to live on your knees is what you tell yourself.");
        Thread.Sleep(2000);
        Console.WriteLine("Your last thought is that you wish you had never opened that silly door.");
        Thread.Sleep(2000);
        Console.WriteLine("The END");
    }
}