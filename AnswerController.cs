using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class AnswerController
    {
        MoneyQuizDBContext context = new MoneyQuizDBContext();
        public async Task UpdateAnswerById(int id, string answerText, bool isCorrect, int questionId)
        {
            var answer = await context.Answers.FirstOrDefaultAsync(a => a.Id == id);
            answer.Answer_text = answerText;
            answer.Is_correct = isCorrect;
            answer.Question_id = questionId;
            await context.SaveChangesAsync();
        }
    }
}
