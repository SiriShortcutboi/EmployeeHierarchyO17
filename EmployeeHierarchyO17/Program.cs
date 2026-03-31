using System;

namespace workforce;
public class Program
{
    public static void Main()
    {
        Developer dev = new Developer();
        dev.SetName("Alice");
        dev.SetSalary(75000);

        Console.WriteLine($"Developer Name = {dev.Name}");
        Console.WriteLine($"Developer Salary = {dev.Salary:C}");//I learned that putting
        Console.WriteLine(dev.WriteCode());                // C on the end is kinda like a callback 
                                              // to the trim and to lower methods to put a Cultural
        Console.WriteLine();//new line);    

        Manager coolManager = new Manager();
        coolManager.SetName("Steve");
        coolManager.SetSalary(95000);

        Console.WriteLine($"Manager Name = {coolManager.Name}");
        Console.WriteLine($"Manager Salary = {coolManager.Salary:C}"); //Money sign on our number
        Console.WriteLine(coolManager.ApproveBudget());
    }
}

public abstract class Employee
{
    private string _name = string.Empty;
    public string Name { get => _name; protected set => _name = value; } //learning about lambda one-liner
    public int Salary { get; protected set; }

    // use a method like SetName thats easy to recognize, and declare a new lowercase 
// string variable to available to the public, then join protected Name to our public name 
    public void SetName(string name)
    {
        Name = name; //setting to value like mentioned
    }

    // another public method that can be called from Main.
    public void SetSalary(int salary)
    {

        Salary = salary;
    }

    public abstract void CalculateSalary();

    public virtual void Greet()
    {
        System.Console.WriteLine("Hi");
        //virtual has a default that can sometimes be changed
    }
   
}   // abstract virtual and override are always used on methods, not variables or fields
    
    //override is always in the child class
    //abstract and virtual are always in the parent class 



public class Manager : Employee
{
    public string ApproveBudget()
    {
        return $"Budget Approved by {Name}";
    }    

    public override void CalculateSalary()
    {
        //must have this because abstract says have it
    }
}
public class Developer : Employee
{    
    public string WriteCode()
    {
        return $"{Name} is writing code.";
    }

    public override void CalculateSalary()
    {
        
    }
    public override void Greet() //this is how you change it, 
                            // change the original greet method on this one
    {
        System.Console.WriteLine("ya boi");
    }
}

/* 
Base class: Employee with Name and Salary properties.

Subclasses: Manager and Developer with unique methods ApproveBudget() and WriteCode(). */