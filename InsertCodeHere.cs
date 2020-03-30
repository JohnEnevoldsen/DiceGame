using System;

namespace DiceGame
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            DiceCup myDiceCup = new DiceCup();
            Console.WriteLine($"In the DiceCup we rolled for a total of {myDiceCup.TotalValue}");
            Console.WriteLine("Let us shake things up.");
            myDiceCup.Shake();
            Console.WriteLine($"Now we rolled for a total of {myDiceCup.TotalValue}");
            Console.WriteLine("One more time");
            myDiceCup.Shake();
            Console.WriteLine($"Now we rolled for a total of {myDiceCup.TotalValue}");
            // The LAST line of code should be ABOVE this line
        }
    }
}