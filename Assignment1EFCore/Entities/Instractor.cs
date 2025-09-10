using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1EFCore.Entities
{
    #region Convention
    //internal class Instractor
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public Decimal Bouns { get; set; }
    //    public decimal Salary { get; set; }
    //    public string Address { get; set; }
    //    public decimal HourRate { get; set; }
    //    public int Dep_Id { get; set; }
    //} 
    #endregion

    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }
        [ForeignKey("Department")]
        public int Dep_Id { get; set; }

    }
}
