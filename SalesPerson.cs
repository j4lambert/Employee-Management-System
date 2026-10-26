public class SalesPerson: Employee
{
    public decimal SalesTarget{get;set;}
    public decimal ActualSales{get;set;}
    public decimal CommissionRate{get;set;}
    public SalesPerson(int id, string firstName, string lastName, string department, DateTime hireDate, decimal baseSalary, decimal salesTarget, decimal actualSales, decimal commissionRate):base(id, firstName, lastName, department, hireDate, baseSalary)
    {
       SalesTarget=salesTarget;
       ActualSales=actualSales;
       CommissionRate=commissionRate;
    }
    public override double CalculateAnnualSalary()
    {
        decimal commission = 12 * ActualSales * CommissionRate / 100m;
        return (double)(BaseSalary + commission);
    }
    public override string EvaluatePerformance()
    {
        decimal targetAttainment = ActualSales/SalesTarget;
        if (SalesTarget <= 0)
        {
            return "Sales performance cannot be evaluated due to the target beign a non-positive number.";
        }
        if(targetAttainment >= 1m)
        {
            return $"Target met or exceeded: {ActualSales:C} in sales against a target of {SalesTarget:C}";
        } else if (targetAttainment >= 0.75m && targetAttainment < 1m)
        {
             return $"Near target: {ActualSales:C} in sales against a target of {SalesTarget:C}";
        } else
        {
            return $"Below target: {ActualSales:C} in sales against a target of {SalesTarget:C}";
        }
    }
    public override string GenerateReport()
    {
        return base.GenerateReport() + "\n" + $"Sales Target: {SalesTarget:C}\n" + $"Actual Sales: {ActualSales:C}\n" + $"Commission Rate: {CommissionRate}%\n" + $"Commission Earned: {(ActualSales * CommissionRate / 100m):C}";
    }
}