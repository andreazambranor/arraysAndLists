using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {

        //CREATED A ONE DIMENSIONAL ARRAY OF STRINGS AND ASKED THE USER TO SELECT ONE INDEX TO DISPLAY THE STRING
        string[] stringArray = new string[] { "banana", "pear", "apple", "coconut", "melon", "pineapple"};
        
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.WriteLine("enter number {0} to select fruit {1}", i, stringArray[i]);
        }

        string choice = Console.ReadLine();
        int j = int.Parse(choice);
        Console.WriteLine("You selected {0} your fruit is {1}", j, stringArray[j]);
        Console.ReadLine();

        if (j>5)
        {
            Console.WriteLine("This index option does not exist");
        }


        //CREATED A ONE DIMENSIONAL ARRAY OF INTEGERS AND ASKED THE USER TO SELECT AN INDEX TO DISPLAY THE INTEGER
        int[] intArray = new int[] { 4, 10, 15, 20, 30};

        for (int a = 0; a < intArray.Length; a++)
        {
            Console.WriteLine("Select index {0} to choose your a day {1}", a, intArray[a]);
        }

        string dayChoice = Console.ReadLine();
        int b = int.Parse(dayChoice);
        Console.WriteLine("you chose {0} soy your date is November {1}", b, intArray[b]);
        Console.ReadLine();

        if (b > 4)
        {
            Console.WriteLine("this index option does not exist");
        }

    }
}

