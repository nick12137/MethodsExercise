namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?"); //output

            var userName = Console.ReadLine(); // input

            Console.WriteLine($"Nice to meet you {userName}. What is your favorite color?"); //output

            var color = Console.ReadLine(); // input

            Console.WriteLine($"{color} is an awesome color. Do you have a favorite car, and what is it?"); //output

            var car = Console.ReadLine(); // input

            Console.WriteLine("Awesome, what about your favorite animal?"); //output

            var animal = Console.ReadLine(); // input

            Console.WriteLine("What kind of music do you like?"); //output

            var music = Console.ReadLine(); // input

            Console.WriteLine($"Thanks, {userName}! Here is your profile."); //output
            Console.WriteLine("------------------------------------------");
         
          

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

