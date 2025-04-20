using System;
using ClassLibrary1;

namespace EventsPublisherAndSubscription
{
    class Program
    {
        public static void Main()
        {

            Program p = new Program();
            p.DoWork();

        }

        public void DoWork()
        {
            Publisher publisher = new Publisher();
            // handle the event or subscribe to the event
            publisher.myEvent += (sender, e) => // lambda expression; replaced delegate keyword wth arrow operator
                {
                    Console.WriteLine(e.a + e.b);
                }
                ;
            // invoke the event
            publisher.RaiseEvent(this, 5, 6);

            publisher.RaiseEvent(this, 15, 15);

            publisher.RaiseEvent(this, 14, 16);
        }

    }
}
