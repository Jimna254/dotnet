// See https://aka.ms/new-console-template for more information
using System.Collections;
using CohortList;
using LearningC_;
//Console.WriteLine("Hello, World!");
//Console.ReadLine();

//    ArrayList dotnetcohort = new ArrayList();
////Add items to the dotnetcohort
//    dotnetcohort.Add("James");
//    dotnetcohort.Add("Collo");
//    dotnetcohort.Add("Reagan");

//foreach (string name in dotnetcohort)
//{
//    Console.WriteLine(name);

//arraylist name = new arraylist();
//name.mylist();

//MyClass myClass = new MyClass();
//MySteps mySteps = new MySteps();
//mySteps.Steps(5);
int numberOfSteps;

while (true)
{
    Console.Write("Enter the number of steps: ");
    if (int.TryParse(Console.ReadLine(), out numberOfSteps) && numberOfSteps > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a positive integer.");
    }
}

MySteps mySteps = new MySteps();
mySteps.Steps(numberOfSteps);

