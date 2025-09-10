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
    //internal class Student
    //{
    //    public int Id { get; set; }
    //    public string FName { get; set; }
    //    public string LName { get; set; }
    //    public string Address { get; set; }
    //    public int Age { get; set; }
    //    public int Dep_Id { get; set; }
    //} 
    #endregion
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FName { get; set; }
        [Required]
        [StringLength(50)]
        public string LName { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        public int Age { get; set; }
        [ForeignKey("Department")]
        public int Dep_Id { get; set; }
    }
}
