namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        // Entry point
        {
            Console.WriteLine("Car Insurance Application");
            // Name of the application
            Console.WriteLine("What is your age?");
            // Prompt the user to enter their age
            int age = Convert.ToInt32(Console.ReadLine());
            // Converts the user age input in integer, storing it in the "Age" variable
            Console.WriteLine("Have you ever had a DUI? Please answer with Yes or No.");
            // Prompt the User to answer the question by Yes or No
            string Answer = Console.ReadLine();
            // Reads the User input
            bool DUI = Answer == "Yes";
            // converts the string "answer" to a boolean value if "answer" is Yes, DUI becomes true, otherwise it's false.
            Console.WriteLine("How many speeding tickets do you have?");
            // Prompts the user to input the number of tickets they have
            int Tickets = Convert.ToInt32(Console.ReadLine());
            //Converts the user input number into a integer storing it as "Tickets" variable.
            Console.WriteLine("Are you qualified for this car insurance?");
            bool qualifiedforInsurance = (age > 15) && !DUI && (Tickets <= 3);
            // Calculates if the User qualifies to this car insurance based on these 3 conditions: older than 15 years old, no DUI, less than 3 speeding tickets.
            Console.WriteLine(qualifiedforInsurance);
            Console.ReadLine();

        }
    }
}
