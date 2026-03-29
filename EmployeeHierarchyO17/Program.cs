using System;
					
public class Program
{
	public static void Main()
	{
		Developer dev = new Developer();
        dev.Name = "Alice";
        Console.WriteLine(dev.Name); // Output: Alice
        dev.WriteCode(); // Output: Alice is writing code
	}
}

public abstract class Employee
{
    string Name = "Employee" { get; private set; }
    string Salary = "$30,000"; 
}

public class Managerclass : Employee
{
     protected override string Name { get; }

    public string ApproveBudget()
    {
        return $"Budget Approved by {Name}";
    }
}
public class Developer : Employee
{
     protected override string Name { get; }

    public string WriteCode()
    {
        return $"{Name} is writing code.";
    }
}

/* 
Base class: Employee with Name and Salary properties.

Subclasses: Manager and Developer with unique methods ApproveBudget() and WriteCode(). */