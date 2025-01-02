using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Model
{
    [Table("Employee")]
    internal class Employee
    {
        [Key]
        [Column("Eid", TypeName = "int")]
        public int Eid { get; set; }
        [Column("Name", TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Column("Address", TypeName = "varchar(50)")]
        public string Address { get; set; }
    }
}
