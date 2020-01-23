using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var witcher = new HenryCavill("Hmmm...");
            var ciri = new Ciri("Mam dla ciebie niespodziankę.");

            var firstFan = new Fan();
            var secondFan = new Fan();

            witcher.AddFollower(firstFan);
            ciri.AddFollower(secondFan);

            witcher.Tweet = "Wole nie wybierać wcale...";
            ciri.Tweet = "Lecę, bo chcę.";

            Console.Read();
        }
    }
}
