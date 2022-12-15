namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?"); //output

            var userName = Console.ReadLine(); // input

            Console.WriteLine("What is your favorite color?"); //output

            var color = Console.ReadLine(); // input

            Console.WriteLine("What is your favorite car?"); //output

            var car = Console.ReadLine(); // input

            Console.WriteLine("What is your favorite animal?"); //output

            var animal = Console.ReadLine(); // input

            Console.WriteLine("What kind of music do you like?"); //output

            var music = Console.ReadLine(); // input

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorte color: {color}");
            Console.WriteLine($"Favorite car: {car}");
            Console.WriteLine($"Favorite animal: {animal}");
            Console.WriteLine($"Favorite music: {music}");
        }
    }




}
//Name: Michael

//Favorite Color: Blue

//Favorite Animal: Walrus

//Favorite Band: The Beatles

