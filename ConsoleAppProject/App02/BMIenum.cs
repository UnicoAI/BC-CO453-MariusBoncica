using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// List of units used to classify BMI group with display names for easy access
    /// </summary>
    public enum BMIenum
    {
        [Display(Name = "Underweight")]
        Underweight = 1,
        [Display(Name = "Normal")]
        Normal = 2,
        [Display(Name = "Overweight")]
        Overweight = 3,
        [Display(Name = "Obese_Class_I")]
        Obese_Class_I = 4,
        [Display(Name = "Obese_Class_II")]
        Obese_Class_II = 5,
        [Display(Name= "Obese_Class_III")]
        Obese_Class_III = 6
    }
}