using System.ComponentModel.DataAnnotations;

namespace PRACTICAL.Models
{
    public class DepartmentEditModel
    {
        [Required] public string name { get; set; }
        [Required] public string code { get; set; }
    }
}
