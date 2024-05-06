using System;

class Program
{
    static void Main(string[] args) //setting up arrays
    {
        string[] names = { "Justin", "Ethan", "Victoria", "Ethan", "Ben",
            "Kyra", "Jack", "Ramses", "Clare", "Ramsey",
            "Ali", "Pedro" };
        string[] hometowns = {  "Westerville", "Ethan", "Blacksburg", "Bolivar", "Birmingham",
            "Hazel Park", "Trenton", "Wyoming", "Lake Orion", "Brooklyn",
            "Dearborn Heights", "Chicago" };
        string[] favoriteFoods = {  "Baja Blast", "Ethan", "Pho", "Hot Wings", "Crab legs",
            "Sushi", "Hot Wings", "Lasagna", "Cheesy Potatoes", "Dim Sum",
            "Indian", "Italian" };

        bool conLearn = true;

        while (conLearn)
        {
            Console.WriteLine("Welcome, which student would you like to learn about? (Enter a number from 1 to " + names.Length + "):");
            string input = Console.ReadLine();
            int studentNumber;

            if (int.TryParse(input, out studentNumber))
            {
                if (studentNumber >= 1 && studentNumber <= names.Length)
                {
                    int index = studentNumber - 1;
                    Console.WriteLine("You chose: " + names[index]);

                    Console.WriteLine("What would you like to learn more about? (Hometown/Favorite Food)");
                    string category = Console.ReadLine().ToLower();

                    if (category == "hometown" || category == "favorite food")
                    {
                        if (category == "hometown")
                            Console.WriteLine(names[index] + "'s hometown is " + hometowns[index]);
                        else
                            Console.WriteLine(names[index] + "'s favorite food is " + favoriteFoods[index]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid enter 'Hometown' or 'Favorite Food'.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid student number. Please enter a number between 1 and " + names.Length + ".");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.WriteLine("Would you like to learn about another student? (y/n)");
            string response = Console.ReadLine().ToLower();
            conLearn = (response == "y");
        }

        Console.WriteLine("Thank you.");
    }
}
