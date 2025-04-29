using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MoneyQuizDBContext:DbContext
    {
        public MoneyQuizDBContext() : base()
        {

        }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<Game_sessions> GameSessions { get; set; }
        public DbSet<Lifelines> Lifelines { get; set; }
        public DbSet<Player_answers> PlayerAnswers { get; set; }
        public DbSet<Player_game_session> Player_Game_Sessions { get; set; }
        public DbSet<Players> Players { get; set; }
        public DbSet<Questions> Questions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=STUDENT15;Initial Catalog=BeMillionaire;DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
