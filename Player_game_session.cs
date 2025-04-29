using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Player_game_session
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Players))]
        public int Player_id { get; set; }
        public Players players { get; set; }
        [ForeignKey(nameof(Game_sessions))]
        public int Sessions_id { get; set; }
        public Game_sessions Game_sessions { get; set; }
    }
}
