using System;

namespace workforce;
public class Program
{
	public static void Main()
	{   
		Developer dev = new Developer();
        dev.Name = "Alice";
        Console.WriteLine(dev.Name); // Output: Alice
        dev.WriteCode(); // Output: Alice is writing code 

        Manager coolmanager = new Manager();
        coolmanager.Name = "Steve";
        Console.WriteLine(dev.Name); 
        coolmanager.ApproveBudget();
	}
}

public abstract class Employee
{
    protected string Name {get; set;}
    protected string Salary {get; set;}
         //use protected to get and set at ^protected level automatically

    public abstract void CalculateSalary();
    public virtual void Greet()
    {
        System.Console.WriteLine("Hi");
    }
   
}   // abstract virtual and override are always used on methods, not variables or fields
    
    //override is always in the child class
    //abstract and virtual are always in the parent class 



public class Manager : Employee
{
    protected string ApproveBudget()
    {
        return $"Budget Approved by {Name}";
    }    
    public override void CalculateSalary()
    {
        
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
    public override void Greet()
    {
        System.Console.WriteLine("ya boi");
    }
}

/* 
Base class: Employee with Name and Salary properties.

Subclasses: Manager and Developer with unique methods ApproveBudget() and WriteCode(). */