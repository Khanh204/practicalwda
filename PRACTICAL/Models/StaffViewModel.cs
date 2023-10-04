using System;
using System.ComponentModel.DataAnnotations;
namespace PRACTICAL.Models
{
    public class StaffViewModel
    {
        [Required] public string name { get; set; }
        [Required] public string phone { get; set; }
        [Required] public string email { get; set; }
        [Required] public string address { get; set; }
        [Required] public int staffcode { get; set; }
        [Required] public string rank { get; set; }

    }
}
