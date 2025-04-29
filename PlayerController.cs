using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class PlayerController
    {
        MoneyQuizDBContext context = new MoneyQuizDBContext();
        public async Task AddPlayer(int id, string name, string email)
        {
            Players players = new Players()
            {
                Id = id,
                Name = name,
                Email = email
            };
            await context.Players.AddAsync(players);
            await context.SaveChangesAsync();
        }
    }
}
