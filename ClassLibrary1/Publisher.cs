namespace ClassLibrary1
{

    public delegate void MyDelegateType(int a, int b);

    // publisher
    public class Publisher
    {

        // step1: create event 
        public event MyDelegateType myEvent;

        public void RaiseEvent(int a, int b)
        {
            // step2: raise event
            if (this.myEvent != null)
            {
                this.myEvent(a, b);
            }
        }
    }

}
