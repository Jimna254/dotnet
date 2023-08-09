using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CohortList;

public class arraylist
{
   public void myList()
    {
        Console.WriteLine("Yoh");
    }

}

public class MyClass
{
    public void Mychar()
    {
        Console.WriteLine("Enter A Positive Integer");
        int number;
        bool parsedSuccessfully = int.TryParse(Console.ReadLine(), out number);

        // If the user did not enter a valid number, display an error message
        if (!parsedSuccessfully)
        {
            Console.WriteLine("You must enter a positive number."); 
            
        }

    }
}