using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey you");
            Console.ReadLine();

            Console.WriteLine("What are you doing?");
            Console.ReadLine();

            Console.WriteLine("That's what's up. I am bored. It gets lonely being stuck inside a computer ya know?");
            Console.ReadLine();

            Console.WriteLine("But did you have a good weekend?");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine($"So " + name + ". Now that I have your here, what is your favorite color?");
            Console.Write("Color: ");
            var color = Console.ReadLine();

            Console.WriteLine(color + "? Wow that's a nice color. What is your favorite animal?");
            Console.Write("Animal: ");
            var animal = Console.ReadLine();

            Console.WriteLine($"A " + animal + " is a good choice indeed. Who is your favorite band?");
            Console.Write("Band: ");
            var band = Console.ReadLine();

            Console.WriteLine($"Nice! " + band + " has some smooth classics for sure.");
            Console.ReadLine();


            Console.WriteLine($"Can I ask you one more question?");
            Console.ReadLine();

            Console.WriteLine("Who's your favorite basketball player? I am trying to see something");
            Console.Write("Answer: ");
            var answer = Console.ReadLine();

            Console.WriteLine($"Oh ok. " + answer + " is a good pick!");
            Console.ReadLine();

            Console.WriteLine("Do you want to know who my favorite basketball player of all time is?");
            Console.ReadLine();

            Console.WriteLine("Oh ok. Well I am going to tell your regardless. It's Michael Jordan because he could score 63 points on a Larry Bird Celtics team EVEN when being fouled and triple teamed the entire series. That alone makes him the greatest");
            Console.ReadLine();

            Console.WriteLine("Anyways, nice chatting with you!");
            Console.ReadLine();



        }
    }
}
