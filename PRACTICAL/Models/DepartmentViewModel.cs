using System.ComponentModel.DataAnnotations;

namespace PRACTICAL.Models
{
    public class DepartmentViewModel
    {
        [Required] public string name { get; set; }
        [Required] public string code { get; set; }
    }
}
