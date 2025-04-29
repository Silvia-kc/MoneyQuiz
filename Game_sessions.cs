using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Game_sessions
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public TimeOnly Time { get; set; }
        [Required]
        public int Final_amount { get; set; }
        public ICollection<Player_game_session> PlayerGameSessions { get; set; }
    }
}
