using System;
using ClassLibrary1;

namespace EventsPublisherAndSubscription
{
    internal class Program
    {
        public static void Main()
        {
            Publisher publisher = new Publisher();
            // handle the event or subscribe to the event
            publisher.myEvent += (a) => // lambda expression; replaced delegate keyword wth arrow operator
                {
                    return a >= 0;
                }
            ;
            // invoke the event
            Console.WriteLine(publisher.RaiseEvent(-1));

            Console.WriteLine(publisher.RaiseEvent(5));

            Console.WriteLine(publisher.RaiseEvent(14));


        }

    }
}
