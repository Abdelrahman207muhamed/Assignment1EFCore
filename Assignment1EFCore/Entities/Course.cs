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

    internal class Course
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_Id { get; set; }
    }
    #endregion

    #region Data Annotation
    //public class course
    //{
    //    [key]
    //    public int id { get; set; }

    //    public int duration { get; set; }

    //    [required]
    //    [stringlength(100)]
    //    public string name { get; set; }

    //    [stringlength(500)]
    //    public string description { get; set; }

    //    public int top_id { get; set; }
    //} 
    #endregion
}
