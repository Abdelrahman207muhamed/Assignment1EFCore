using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1EFCore.Entities
{
    #region Convention
    //internal class Topic
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //} 
    #endregion

    public class Topic
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
