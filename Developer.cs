public class Developer : Employee
{
    public string PrimaryLanguage{get; set;}=string.Empty;
    public int ProjectsCompleted{get; set;}
    public string SeniorityLevel{get; set;}=string.Empty;
    public Developer(int id, string firstName, string lastName, string department, DateTime hireDate, decimal baseSalary, string primaryLanguage, int projectsCompleted, string seniorityLevel):base(id, firstName, lastName, department, hireDate, baseSalary)
    {
       PrimaryLanguage=primaryLanguage;
       ProjectsCompleted=projectsCompleted;
       SeniorityLevel=seniorityLevel;
    }
    public override double CalculateAnnualSalary()
    {
        decimal adjustmentPercentage=SeniorityLevel.ToLowerInvariant() switch
        {
            "junior"=>10m,
            "mid"=>15m,
            "senior"=>20m,
            _=>0m
        };
        return(double)(BaseSalary*(1m+adjustmentPercentage/100m));
    }
    public override string EvaluatePerformance()
    {
        if (ProjectsCompleted >= 10)
        {
            return $"Strong performance: completed{ProjectsCompleted} projects.";
        } else if (ProjectsCompleted >=5 && ProjectsCompleted < 10)
        {
            return $"Good performance: completed {ProjectsCompleted} projects";
        } else if (ProjectsCompleted >= 1 && ProjectsCompleted < 5)
        {
            return $"Developing performance: completed {ProjectsCompleted} projects";  
        }
        else
        {
            return $"No projects completed.";
        }
    }
    public override string GenerateReport()
    {
        return base.GenerateReport() + "\n" + $"Primary Language: {PrimaryLanguage}\n" + $"Projects Completed: {ProjectsCompleted}\n" + $"Seniority Level: {SeniorityLevel}";
    }
}