namespace User_Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // curits
            Part1();


        }

        public static void Part1()
        {

            //String name;
            //int age;
            //double money;
            //Console.Write("What is your name?:");

            //name = Console.ReadLine();

            //Console.Write("Hi " + name + " How old are you?");
            //age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("So you're " + age + " wow that's not old at all! How much money do you make, " + name + "?");
            //money = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(money + "! I really hope that's per hour and not per year!");

            //Part 2
            string firstName, lastName, login;
            int id;
            double grade, average;
            Console.Write("First name: ");
            firstName = Console.ReadLine();
            Console.Write("Last name: ");
            lastName = Console.ReadLine();
            Console.Write("Grade (9-12): ");
            grade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Student ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Login: ");
            login = Console.ReadLine();
            Console.Write("Average: ");
            average = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your information:");
            Console.WriteLine("\tLogin:\t" + login);
            Console.WriteLine("\tID:\t" + id);
            Console.WriteLine("\tName:\t" + firstName + " " + lastName);
            Console.WriteLine("\tAverage:" + average + "%");
            Console.WriteLine("\tGrade:\t" + grade);






        }

    }
}
