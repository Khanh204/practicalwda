
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRACTICAL.Entities
{
    [Table("staff")]
    public class Staff
    {
        [Key] public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string name { get; set; }
        [Required]
        public string phone { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string address { get; set; }
        [Required]

        public int staffcode { get; set; }
        [Required]
        public string rank { get; set; }
        
        public int department_id { get; set; }
        [ForeignKey("department_id")]
        public Department department { get; set; }

        
    }
}

