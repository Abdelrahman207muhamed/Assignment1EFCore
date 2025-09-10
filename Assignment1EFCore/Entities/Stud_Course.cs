using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1EFCore.Entities
{
    #region Convention
    //internal class Stud_Course
    //{
    //    public int stud_Id { get; set; }
    //    public int Course_Id { get; set; }
    //    public decimal Grade { get; set; }
    //} 
    #endregion

    public class Stud_Course
    {
        [Key]
        public int stud_ID { get; set; }

        [Key]
        public int Course_ID { get; set; }

        [Range(0, 100)]
        public decimal Grade { get; set; }
    }
}
