using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Lifelines
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [ForeignKey(nameof(Player_game_session))]
        public int Player_game_sessions_id { get; set; }
        public Player_game_session player_Game_Session { get; set; }
        [ForeignKey(nameof(Questions))]
        public int Used_on_question_id { get; set; }
        public Questions Questions { get; set; }
    }
}
