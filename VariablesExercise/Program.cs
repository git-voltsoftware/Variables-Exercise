namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Logan";
            int age = 34;
            char firstInitial = 'L';
            bool areYouMarried = true;
            double moneyInYourPocket = 10.50;
            decimal monetaryCalculations = 1234567.1098m;

            Console.WriteLine($"Hello my name is {name} (first inital is {firstInitial}) and I am {age} years old. It is {areYouMarried} that I am married. I currently have {moneyInYourPocket} in my pocket and hope to have {monetaryCalculations} in the bank one day.");

        }
    }
}
