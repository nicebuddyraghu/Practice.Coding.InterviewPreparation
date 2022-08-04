using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Command.MultipleRecievers
{
    public class ReceiverOne : IReceiver
    {
        int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public ReceiverOne()
        {
            Number = 10;
            Console.WriteLine($"ReceiverOne initialized with {Number}");
            Console.WriteLine($"The objects of receiverOne cannot set beyond {number}");
        }

        public void Add2WithNumber()
        {
            int presentNumber = Number;
            Number = Number + 2;
            Console.WriteLine($"{Number}+2={1}");
        }

        public void OptionalTaskPostProcessing()
        {
            Console.WriteLine("ReceiverOne.OptionalTaskPostProcessing");
        }
        //Preprocessing tasks
        public void OptionalTasksPriorProcessing()
        {
            Console.WriteLine("ReceiverOne.OptionalTasksPriorProcessing");
        }

        public void Remove2FromNumber()
        {
            int presentNumber = Number;
            //We started with number 10. We'll not decrease further.
            if(presentNumber>10)
            {
                Number = Number - 2;
                Console.WriteLine($"{presentNumber}-2={Number}");
            }
            else
            {
                Console.WriteLine("Nothing more to Undo...");
            }
        }
    }
}
