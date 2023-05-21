using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// List of Measurement Systems used to calculate BMI
    /// Author: Marius Boncica
    /// Version 2.0 using enumeration for refactoring
    /// </summary>
    /// Enumaration of units choice
    public enum UnitChoice
    {
        [Display(Name = "No Unit")]
        NoUnit,
        Metric,
        Imperial,
    }
}
