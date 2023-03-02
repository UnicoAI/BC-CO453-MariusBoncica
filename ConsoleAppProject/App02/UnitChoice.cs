using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// List of Measurement Systems used to calculate BMI
    /// </summary>
    public enum UnitChoice
    {
        [Display(Name = "No Unit")]
        NoUnit,
        Metric,
        Imperial,
    }
}
