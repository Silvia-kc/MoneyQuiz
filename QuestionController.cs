using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class QuestionController
    {


        MoneyQuizDBContext context = new MoneyQuizDBContext();
        public async Task AddQuestion(int id, string questionText, int amount)
        {
            Questions qustion = new Questions()
            {
                Id = id,
                Question_text = questionText,
                Amount = amount
            };
            await context.Questions.AddAsync(qustion);
            await context.SaveChangesAsync();
        }
        public async Task Add4AnswerForQuestion(int id, Answers answer1, Answers answer2, Answers answer3, Answers answer4)
        {
            var question = await context.Questions.FindAsync(id);

            if (question != null)
            {
                answer1.Question_id = id;
                answer2.Question_id = id;
                answer3.Question_id = id;
                answer4.Question_id = id;
            }
            else
            {
                Console.WriteLine("There is no question with this id!");
            }
        }
        public async Task UpdateQuestionByid(int id, string questionText, int amount)
        {
            var question = await context.Questions.FirstOrDefaultAsync(q => q.Id == id);
            question.Question_text = questionText;
            question.Amount = amount;
            await context.SaveChangesAsync();
        }
        public async Task<List<Questions>> QuestionWherePriceAbove3000()
        {
            var question = await context.Questions.Where(q => q.Amount > 3000)
                                                  .ToListAsync();
            return question;
        }
        public async Task<List<Questions>> GetAllQuestionAndAnswer()
        {
            var question = await context.Questions.Include(x => x.Answers).ToListAsync();
            return question;
        }
        public async Task<Answers> GetQuestionAndTrueAnswerByAmout(int amount)
        {
            var question = await context.Questions.Include(x => x.Answers).FirstOrDefaultAsync(q => q.Amount == amount);
            var answer = question.Answers.FirstOrDefault(a => a.Is_correct == true);
            return answer;
        }
    }
}

