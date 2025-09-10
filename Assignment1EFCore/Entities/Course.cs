using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1EFCore.Entities
{
    #region Convention
    //Convention:

    //internal class Course
    //{
    //    public int Id { get; set; }
    //    public int Duration { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    public int Top_Id { get; set; }
    //} 
    #endregion

    public class Course
    {
        [Key]
        public int ID { get; set; }

        public int Duration { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int Top_ID { get; set; }
    }
}
