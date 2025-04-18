namespace ClassLibrary1
{
    public class Class1
    {
        public delegate void MyDelegateType(int a, int b);

        // publisher
        public class Publisher
        {
            // private delegate
            private MyDelegateType myDelegate;

            // step1: create event (just like we create a property inside a class)
            public event MyDelegateType myEvent
            {
                add
                {
                    myDelegate += value;
                }
                remove
                {
                    myDelegate -= value;
                }
            }
        }
    }
}
