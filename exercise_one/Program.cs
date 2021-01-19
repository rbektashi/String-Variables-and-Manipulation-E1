using System;

namespace exerciseOne
{
    class Program
    {
        private static void Main(string[] args)
        {
           
            {
//Create a string variable to store a message to the user asking them for their full name
                string greetingMessage = "Please enter your full name";
                Console.WriteLine(greetingMessage);
// Use the variable to ask the user for their full name and store the user's input in a different variable
                string fullName = greetingMessage;
                Console.WriteLine(fullName);
// Display their name with all letters as upper case and remove any empty spaces on the right of their input
                string userfullName = " Raeanna Michele Bektashi    ";
                string allUpper = userfullName.ToUpper();
                Console.WriteLine(allUpper);
                Console.WriteLine(userfullName.TrimEnd());
// Display their name with all letters as lower case and remove any empty spaces on the left of the input
                string allLower = userfullName.ToLower();
                Console.WriteLine(allLower);
                Console.WriteLine( userfullName.TrimStart());
// Display the length of their name as they entered it but removing any empty space on either side of the input
                Console.WriteLine( "The length of '{0}' is {1}", userfullName.Trim(), userfullName.Length);
// Display the location of the first space in their name, ignoring spaces on either side of the input
                Console.WriteLine(userfullName.Trim().IndexOf(' '));
// Display the location of the last space in their name, ignoring spaces on either side of the input
                Console.WriteLine(userfullName.Trim().LastIndexOf(' '));

            }
        }
    }
}