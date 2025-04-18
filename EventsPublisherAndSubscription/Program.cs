using ClassLibrary1;

namespace EventsPublisherAndSubscription
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subscriber subscriber = new Subscriber();
            Publisher publisher = new Publisher();
            // handle the event or subscribe to the event
            publisher.myEvent += subscriber.Add;
            // invoke the event
            publisher.RaiseEvent(10, 20);
        }
    }
}
