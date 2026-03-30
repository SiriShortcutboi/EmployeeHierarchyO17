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
    protected abstract string Name {get; set;}
         //use protected to get and set at ^protected level automatically
    protected override string NameGive()
    {
        Name = "Employee";
        return Name;
    }
protected abstract string Salary {get; set;}
    public string SalaryAmount()
    {
        
        Salary = "$95,000";
        return Salary; 
    } 


}

public class Manager : Employee
{
    protected override string Name {get; set;}  // protected is still tied to the class like private, 
    protected string NameGive()
    {
        Name = "Steve";
        return Name;
    }   
    protected string ApproveBudget()
    {
        return $"Budget Approved by {Name}";
    }


    
}
public class Developer : Employee
{
    protected override string Name { get; set; }
    string Name = "Steve";
    return Name;
    
    public string WriteCode()
    {
        return $"{Name} is writing code.";
    }
}

/* 
Base class: Employee with Name and Salary properties.

Subclasses: Manager and Developer with unique methods ApproveBudget() and WriteCode(). */