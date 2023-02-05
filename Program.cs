namespace SecondMethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("Type in an animal");
            var animal = Console.ReadLine();

            Console.WriteLine("Type in a band name");
            var band = Console.ReadLine();

            Console.WriteLine($"Funny sentence: {name} had a band named {band} " +
                $"and its mascot was a {color} {animal}");
        }
    }
}