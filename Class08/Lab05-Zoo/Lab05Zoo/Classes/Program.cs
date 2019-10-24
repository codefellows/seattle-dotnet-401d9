using System;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Dwayne (the Bronto) Johnson's Zoo");
            Console.WriteLine(" ");

            Diplodocus clifford = new Diplodocus();
            clifford.Name = "Clifford";

            Console.WriteLine($"I am {clifford.Name}. ");
            clifford.Run();
            clifford.Ride();
            clifford.Hibernate();
            clifford.Eat();

            Corythosaurous correy = new Corythosaurous();
            correy.Name = "Correy";
            Console.WriteLine(" ");
            Console.WriteLine($"I am {correy.Name}. ");
            correy.Run();
            correy.Terrorizing();
            correy.Eat();
            correy.Destroy();
            Console.WriteLine(" ");

            Trex tiny = new Trex();
            tiny.Name = "Tiny";
            Console.WriteLine($"I am {tiny.Name}. ");
            tiny.Run();
            tiny.Terrorizing();
            tiny.Eat();
            tiny.Destroy();
            OmviRaptor yooney = new OmviRaptor();
            yooney.Name = "Yooney";
            Console.WriteLine(" ");
            Console.WriteLine($"I am {yooney.Name}. ");
            yooney.Run();
            yooney.Eat();
            yooney.Chillin();
            Stegosaurus stella = new Stegosaurus();
            Console.WriteLine(" ");
            stella.Name = "Stella";
            Console.WriteLine($"I am {stella.Name}. ");
            stella.Run();
            stella.Eat();
            stella.Chillin();
        }
    }
}
