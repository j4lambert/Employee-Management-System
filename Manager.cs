using System.Security.Cryptography.X509Certificates;

public class Manager : Employee
{
    public int TeamSize{get; set;}
    public decimal BonusPercentage{get; set;}
    public Manager(int id, string firstName, string lastName, string department, DateTime hireDate, decimal baseSalary, int teamSize, decimal bonusPercentage):base(id, firstName, lastName, department, hireDate, baseSalary)
    {
        TeamSize = teamSize;
        BonusPercentage = bonusPercentage;
    }
    public override double CalculateAnnualSalary()
    {
        return (double)(BaseSalary * (1 + BonusPercentage / 100m));
    }
    public override string EvaluatePerformance()
    {
        return $"Manages a team of {TeamSize} employees with a bonus rate of {BonusPercentage}%.";
    }
    public override string GenerateReport()
    {
        return base.GenerateReport() + "\n" + $"Team Size: {TeamSize}\n" + $"Bonus Percentage:{BonusPercentage}%";
    }
}