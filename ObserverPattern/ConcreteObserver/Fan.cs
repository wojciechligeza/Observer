using System;

namespace ObserverPattern
{
    // KONKRETNY OBSERWATOR
    public class Fan : IFan
    {
        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"Fan powiadomiony. Tweet {celebrity.FullName}: " +
                              $"{celebrity.Tweet}");
        }
    }
}
