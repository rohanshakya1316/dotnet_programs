

namespace BasicOperations
{
    class EventHandlingDemo
    {
        //static void Main(string[] args)
        //{
        //    AddTwoNumbers a = new AddTwoNumbers();
        //    // a.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(EventMessage); 
        //    a.ev_OddNumber += EventMessage;
        //    a.Add(); // Triggers the event if condition are met 
        //    Console.Read(); 

        //}

        static void EventMessage()
        {
            Console.WriteLine("Event Executed: This is odd Number. ");
        }
    }


    // this is publisher class 
    class AddTwoNumbers
    {
        public delegate void dg_OddNumber(); // Declare Delegate 
        public event dg_OddNumber ev_OddNumber; // Declare Events 

        public void Add()
        {
            int result;
            result = 4 + 4;
            Console.WriteLine(result);

            // check if the result is odd number then raise event 
            if ((result % 2 != 0) && (ev_OddNumber != null))
            {
                ev_OddNumber(); // Raise Event   
            }
        }
    }
}
