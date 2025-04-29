using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Answers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Answer_text { get; set; }
        [Required]
        public bool Is_correct { get; set; }
        [ForeignKey(nameof(Questions))]
        public int Question_id { get; set; }
        public Questions Question { get; set; }
    }
}
