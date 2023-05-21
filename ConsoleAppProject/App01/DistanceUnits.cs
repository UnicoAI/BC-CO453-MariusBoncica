using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// List of units used to measure distance with display names for easy access
    /// //Autor: Marius Boncica
    /// </summary>
    /// Version 1.0
    public enum DistanceUnits
    {
        [Display(Name = "metres")]
        metres = 1,
        [Display(Name = "lightyears")]
        lightyears = 2,
        [Display(Name = "kilometres")]
        kilometres = 3,
        [Display(Name = "miles")]
        miles = 4,
        [Display(Name = "yards")]
        yards = 5,
        [Display(Name = "feet")]
        feet = 6,
        [Display(Name = "inches")]
        inches = 7,
        [Display(Name = "centimetres")]
        centimetres = 8,
        [Display(Name = "millimetres")]
        millimetres = 9,
        [Display(Name = "micrometres")]
        micrometres = 10,
        [Display(Name = "nanometres")]
        nanometres = 11
    }
}
