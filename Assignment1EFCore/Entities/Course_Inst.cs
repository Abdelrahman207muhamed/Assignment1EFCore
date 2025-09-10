using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1EFCore.Entities
{
    #region Convention
    //internal class Course_Inst
    //{
    //    public int inst_Id { get; set; }
    //    public int Course_Id { get; set; }
    //    public int Evaluate { get; set; }
    //} 
    #endregion

    public class Course_Inst
    {
        [Key]
        public int inst_ID { get; set; }

        [Key]
        public int Course_ID { get; set; }

        [Range(1, 5)]
        public int evaluate { get; set; }
    }

}
