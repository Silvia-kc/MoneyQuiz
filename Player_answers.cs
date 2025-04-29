using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Player_answers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool Is_Correct { get; set; }
        [ForeignKey(nameof(Players))]
        public int Player_session_id { get; set; }
        public Players Player { get; set; }
        [ForeignKey(nameof(Answers))]
        public int Answers_id { get; set; }
        public Answers Answer { get; set; }
    }
}
