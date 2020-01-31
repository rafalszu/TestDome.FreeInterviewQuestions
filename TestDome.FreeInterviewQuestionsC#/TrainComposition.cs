using System;
using System.Collections.Generic;

namespace TestDome.FreeInterviewQuestionsC
{
    /*
    A TrainComposition is built by attaching and detaching wagons from the left and the right sides, efficiently with respect to time used.

    For example, if we start by attaching wagon 7 from the left followed by attaching wagon 13, again from the left, we get a composition 
    of two wagons (13 and 7 from left to right). Now the first wagon that can be detached from the right is 7 and the first that can be detached
     from the left is 13.

    Implement a TrainComposition that models this problem.
    */
    public class TrainComposition
    {
        LinkedList<int> wagons = new LinkedList<int>();

        public void AttachWagonFromLeft(int wagonId)
        {
            wagons.AddFirst(wagonId);
        }

        public void AttachWagonFromRight(int wagonId)
        {
            wagons.AddLast(wagonId);
        }

        public int DetachWagonFromLeft()
        {
            if(wagons.Count == 0)
                return -1;
            
            var first = wagons.First;
            wagons.RemoveFirst();

            return first.Value;
        }

        public int DetachWagonFromRight()
        {
            if(wagons.Count == 0)
                return -1;

            var last = wagons.Last;
            wagons.RemoveLast();

            return last.Value;
        }

        public static void Main(string[] args)
        {
            TrainComposition tree = new TrainComposition();
            tree.AttachWagonFromLeft(7);
            tree.AttachWagonFromLeft(13);
            Console.WriteLine(tree.DetachWagonFromRight()); // 7 
            Console.WriteLine(tree.DetachWagonFromLeft()); // 13
        }
    }
}