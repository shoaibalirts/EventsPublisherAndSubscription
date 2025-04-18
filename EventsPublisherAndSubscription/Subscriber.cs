using System;

namespace EventsPublisherAndSubscription
{
    public class Subscriber
    {
        // Event handler
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
