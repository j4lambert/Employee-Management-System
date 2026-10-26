using System;
using System.Diagnostics.Contracts;
public class Employee
{
    public int EmployeeID{get; set;}
    public string FirstName{get; set;}
    public string LastName{get; set;}
    public string Department{get; set;}
    public DateTime HireDate{get; set;}
    public decimal BaseSalary{get; set;}
    public Employee(int id, string firstName, string lastName, string department, DateTime hireDate, decimal baseSalary)
    {
        EmployeeID = id;
        FirstName = firstName;
        LastName = lastName;
        Department = department;
        HireDate = hireDate;
        BaseSalary = baseSalary;
    }
    public virtual double CalculateAnnualSalary()
    {
        return (double) BaseSalary;
    }
    public virtual string EvaluatePerformance()
    {
        return "Performance evaluation is not available at this time.";
    }
    public virtual string GenerateReport()
    {
        return $"Employee: {FirstName} {LastName}\n" + $"ID: {EmployeeID}\n" + $"Department: {Department}\n" + $"Hire Date: {HireDate:d}\n" + $"Base Salary: {BaseSalary:C}";
    }
}