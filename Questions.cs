using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Questions
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Question_text { get; set; }
        [Required]
        public int Amount { get; set; }
        public List<Answers> Answers { get; set; }
    }
}
