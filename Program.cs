using System;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

   
    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee Age: " + Age);
        Console.WriteLine("Employee Salary: $" + Salary);
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Employee employee1 = new Employee("Harshit Sengar", 22, 50000000.00);

        
        Console.WriteLine("Employee Details:");
        employee1.DisplayDetails();
    }
}


