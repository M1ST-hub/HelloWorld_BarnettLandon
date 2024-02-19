namespace HelloWorld_BarnettLandon
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Allows to grab first and last names
            string firstName;
            string lastName;

            //prints the first question to the console
            Console.WriteLine("Wuss yo name cuhh");
            
            //Allows user to respond to the question
            firstName = Console.ReadLine();

            //Prints response back to user
            Console.WriteLine($"Wsg {firstName}");
            Console.WriteLine($"Wuss yo last name, {firstName}");

            //Allows user to respond to the second question
            lastName = Console.ReadLine();

            //Greets the user
            Console.WriteLine($"Nice to meet you {firstName} {lastName}");

            //
            char firstLetter = firstName.ToUpper()[0];

            
            switch( firstLetter )
            {
                case 'A':
                    Console.WriteLine("You're so awesome. The letter A is the best first inital ever.");
                    break;

                case 'B':
                    Console.WriteLine("Do you think, hypothetically, that there's more than one Santa");
                    break;

                case 'C':
                    Console.WriteLine("I used to know someone with a name like that. They got murdered for yapping excessively");
                    break;

                case 'D':
                    Console.WriteLine("You seem like you enjoy watching short people struggle to reach something up high");
                    break;

                case 'E':
                    Console.WriteLine("I wouldn't go by that name 'round these parts");
                    break;

                case 'F':
                    Console.WriteLine("I like watching kids fall");
                    break;

                case 'G':
                    Console.WriteLine("I like listening to music while shredding cheese");
                    break;

                case 'H':
                    Console.WriteLine("That was sarcasm");
                    break;

                case 'I':
                    Console.WriteLine("You sound like you'd eat chocolate lucky charms with a broken fork");
                    break;

                case 'J':
                    Console.WriteLine("Just kidding, I hope I never have to hear that name again");
                    break;

                case 'L':
                    Console.WriteLine("You sound like you'd eat chocolate lucky charms with a broken fork");
                    break;

                case 'M':
                    Console.WriteLine("That was sarcasm by the way");
                    break;

                case 'N':
                    Console.WriteLine("I like watching kids fall");
                    break;

                case 'O':
                    Console.WriteLine("I like listening to music while shredding cheese");
                    break;

                case 'P':
                    Console.WriteLine("Pterodactyls are my favorite dinosaur");
                    break;

                case 'Q':
                    Console.WriteLine("I've never heard a name like that");
                    break;

                case 'R':
                    Console.WriteLine("I used to know someone with a name like that. They got murdered for yapping excessively");
                    break;

                case 'S':
                    Console.WriteLine("Most people with your name are 50/50 Dope as fluff or rude as fu-");
                    break;

                case 'T':
                    Console.WriteLine("Oh look, 2 planes");
                    break;

                case 'U':
                    Console.WriteLine("All women are queens");
                    break;

                case 'V':
                    Console.WriteLine("I eat my bananas sideways");
                    break;

                case 'W':
                    Console.WriteLine("With a name like that you can cover me in mustard and call me a wiener");
                    break;

                case 'X':
                    Console.WriteLine("You probably play bass");
                    break;

                case 'Y':
                    Console.WriteLine("I used to know someone with a name like that. They got murdered for yapping excessively");
                    break;

                case 'Z':
                    Console.WriteLine("Ran out of dialogue, like who's name starts with 'Z' anyways");
                    break;

                default: Console.WriteLine("WUH");
                    break;
            }
        }
    }
}