using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class LifelinesController
    {
        MoneyQuizDBContext context = new MoneyQuizDBContext();
        public async Task RemoveLifelinesById(int id)
        {
            var lifelines = await context.Lifelines.FirstOrDefaultAsync(l => l.Id == id);
            context.Lifelines.Remove(lifelines);
            await context.SaveChangesAsync();
        }
    }
}
