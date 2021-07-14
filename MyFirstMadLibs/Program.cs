using System;

namespace MyFirstMadLibs
{

    class Program
    {
        static void Intro()
        {
            Console.ReadKey(true);
            Console.WriteLine("What's your name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("And how old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Hello {firstName}, you are {age} years old!");
            Console.ResetColor();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
        static void StoryChoices()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("What's your favorite color?");
            string color = Console.ReadLine();
            
            Console.WriteLine("\nInteresting... Now, who is your favorite movie star?");
            string movieStar = Console.ReadLine();
            
            Console.WriteLine("\nOk, what's your favorite number?");
            int favNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nLets talk about food, what's your favorite dish?");
            string favFood = Console.ReadLine();
            
            Console.WriteLine("\nThat's disgusting! \nRedemption question: latte, cappuchino, tea or hot chocolate?");
            string favDrink = Console.ReadLine();
            
            Console.WriteLine("\nNow were talking! Ok, in what year were you born?");
            int yearBorn = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nI should have known that. You told me your age earlier... My developer is a noob!");
            
            Console.WriteLine("\nIn what city were you born?");
            string city = Console.ReadLine();
            
            Console.WriteLine("\nIf you had to pick one book to read forever, what would it?");
            string favBook = Console.ReadLine();
            
            Console.WriteLine("\nLast question now. What's your partners name?");
            string partName = Console.ReadLine();
            
            Console.WriteLine("\nActually... Lets have one more! What's your favorite alcoholic drink?");
            string favAlc = Console.ReadLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("With the information collected, I'm going to write a story for you");
            Console.WriteLine("Press any key when ready...");
            Console.ReadKey(true);
            
            Console.WriteLine($"\nIt was the year {yearBorn}. Minding your own business in a coffee shop on the outskirts of " +
                              $"{city}, you notice someone that looks familiar. Peering over your {favDrink}, you squint slightly. " +
                              $"To your surprise, it's {movieStar} sat in the corner reading a copy of what looks like {favBook}. " +
                              $"With your {favDrink} now finished, you decide to approach {movieStar} and introduce yourself. You hit " +
                              $"it off instantly and exchange numbers.");
            
            Console.WriteLine($"\nWhether through nerves or other commitments, it took you {favNumber} days to contact {movieStar}. " +
                              $"You propose a dinner at your local restaurant, to which they accept. When the night came, you put on " +
                              $"your favorite {color} outfit. Sadly though, you arrive to the venue 30 minutes late! {movieStar} is ordering " +
                              $"their food which leaves you no time at all to choose. In the panic, you choose {favFood}. A dish that " +
                              $"{movieStar} hates!");
            
            Console.WriteLine($"\nAs the dinner progressed, you soon begin to realise that {movieStar} is not how you imagined. Shortly after " +
                              $"you finish your {favFood}, you decide to call it a night and go home. Feeling disappointed about the experience, " +
                              $"you pour yourself a {favAlc}. Whilst doing so, you cast your gaze to a picture of you and {partName} hanging on the wall. " +
                              $"You smile. {partName} is away on business and isn't due home for another week. Upon refelction, you are happy that the night " +
                              $"ended where it did.");                  
        }
        static void Main()
        {
            Console.WriteLine("Welcome to The Console! Press any key to continue...");
            Intro();
            Console.WriteLine("Lets write a story together shall we?");
            StoryChoices();

        }
    }
}

