using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRACTICAL.Entities
{
    [Table("department")]
    public class Department
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
    }
}