using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Plan.Entities
{
    public class Planss
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set;
        }
        [ForeignKey("Timing_ID")]       
        public int Timing_ID { get; set; }

       
        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}
