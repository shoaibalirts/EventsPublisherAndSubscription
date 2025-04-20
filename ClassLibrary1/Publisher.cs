using System;

namespace ClassLibrary1
{

    public class CustomEventArgs : EventArgs
    {
        public int a { get; set; }
        public int b { get; set; }
    }
    // publisher
    public class Publisher
    {

        // step1: create event 
        public event EventHandler<CustomEventArgs> myEvent; // for built-in events e.g. click

        public void RaiseEvent(object sender, int a, int b)
        {
            // step2: raise event
            if (this.myEvent != null)
            {
                CustomEventArgs customEventArgs = new CustomEventArgs() { a = a, b = b }; // object initializer

                this.myEvent(sender, customEventArgs); // sender represents the current object based on the event is raised.
            }


        }
    }

}
