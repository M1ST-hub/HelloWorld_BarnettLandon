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
        }
    }
}