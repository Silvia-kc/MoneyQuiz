using Core;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Display
    {
        AnswerController answerController = new AnswerController();
        QuestionController questionController = new QuestionController();
        PlayerController playerController = new PlayerController();
        LifelinesController lifelinesController = new LifelinesController();
        public async Task ViewMenu()
        {
            while (true)
            {
                Menu();
                int num = int.Parse(Console.ReadLine());
                if (num == 10)
                {
                    break;
                }
                switch (num)
                {
                    case 1:
                        await AddQuestion();
                        break;
                    case 2:
                        await Add4AnswerForQuestion();
                        break;
                    case 3:
                        await UpdateQuestionById();
                        break;
                    case 4:
                        await UpdateAnswerById();
                        break;
                    case 5:
                        await RemoveLifelines();
                        break;
                    case 6:
                        await AddPlayer();
                        break;
                    case 7:
                        await QuestionWherePriceAbove3000();
                        break;
                    case 8:
                        await GetAllQuestionAndAnswer();
                        break;
                    case 9:
                        await GetQuestionAndTrueAnswerByAmout();
                        break;
                }


            }
        }
        public void Menu()
        {
            Console.WriteLine("1.Add question");
            Console.WriteLine("2.Add 4 answers for question");
            Console.WriteLine("3.Update question by id");
            Console.WriteLine("4.Update answer by id");
            Console.WriteLine("5.Reove lifelines");
            Console.WriteLine("6.Add players");
            Console.WriteLine("7.Get questions with amount above 3000");
            Console.WriteLine("8.Get all questions and answers");
            Console.WriteLine("9.Get question and true answer byu amount");
            Console.WriteLine("10.Exit");
        }
        public async Task AddQuestion()
        {
            Console.WriteLine("Enter question id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter question text: ");
            string questionText = Console.ReadLine();
            Console.WriteLine("Enter question amount: ");
            int amount = int.Parse(Console.ReadLine());
            await questionController.AddQuestion(id, questionText, amount);
            Console.WriteLine("Question was added successfully!");
        }
        public async Task Add4AnswerForQuestion()
        {
            Console.WriteLine("Enter question id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter answer 1 id,answer text and it is correct: ");
            int answer1Id = int.Parse(Console.ReadLine());
            string answer1text = Console.ReadLine();
            bool answer1IsCorrect = bool.Parse(Console.ReadLine());
            Answers answer1 = new Answers()
            {
                Id = answer1Id,
                Answer_text = answer1text,
                Is_correct = answer1IsCorrect
            };
            Console.WriteLine("Enter answer 2 id,answer text and it is correct: ");
            int answer2Id = int.Parse(Console.ReadLine());
            string answer2text = Console.ReadLine();
            bool answer2IsCorrect = bool.Parse(Console.ReadLine());
            Answers answer2 = new Answers()
            {
                Id = answer2Id,
                Answer_text = answer2text,
                Is_correct = answer2IsCorrect
            };
            Console.WriteLine("Enter answer 3 id,answer text and it is correct: ");
            int answer3Id = int.Parse(Console.ReadLine());
            string answer3text = Console.ReadLine();
            bool answer3IsCorrect = bool.Parse(Console.ReadLine());
            Answers answer3 = new Answers()
            {
                Id = answer3Id,
                Answer_text = answer3text,
                Is_correct = answer3IsCorrect
            };
            Console.WriteLine("Enter answer 4 id,answer text and it is correct: ");
            int answer4Id = int.Parse(Console.ReadLine());
            string answer4text = Console.ReadLine();
            bool answer4IsCorrect = bool.Parse(Console.ReadLine());
            Answers answer4 = new Answers()
            {
                Id = answer4Id,
                Answer_text = answer4text,
                Is_correct = answer4IsCorrect
            };
            await questionController.Add4AnswerForQuestion(id, answer1, answer2, answer3, answer4);
        }
        public async Task UpdateQuestionById()
        {
            Console.WriteLine("Enter question id for update: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new question text: ");
            string newQusetionText = Console.ReadLine();
            Console.WriteLine("Enter new question amount: ");
            int newAmount = int.Parse(Console.ReadLine());
            await questionController.UpdateQuestionByid(id, newQusetionText, newAmount);
        }
        public async Task UpdateAnswerById()
        {
            Console.WriteLine("Enter answer id for update: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new answer text: ");
            string newAnswerText = Console.ReadLine();
            Console.WriteLine("Enter new is correct: ");
            bool newIsCorrect = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter answer new question id: ");
            int newQusetionId = int.Parse(Console.ReadLine());
            await answerController.UpdateAnswerById(id, newAnswerText, newIsCorrect, newQusetionId);
        }
        public async Task RemoveLifelines()
        {
            Console.WriteLine("Enter lifelines id to remove: ");
            int id = int.Parse(Console.ReadLine());
            await lifelinesController.RemoveLifelinesById(id);
            Console.WriteLine("Lifelines was remove successfully!");
        }
        public async Task AddPlayer()
        {
            Console.WriteLine("Enter plyer id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter player name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter player email: ");
            string email = Console.ReadLine();
            await playerController.AddPlayer(id, name, email);
        }
        public async Task QuestionWherePriceAbove3000()
        {
            List<Questions> questions = await questionController.QuestionWherePriceAbove3000();
            foreach (var question in questions)
            {
                Console.WriteLine(question.Question_text);
            }
        }
        public async Task GetAllQuestionAndAnswer()
        {
            List<Questions> questions = await questionController.GetAllQuestionAndAnswer();
            foreach (var question in questions)
            {
                Console.WriteLine($"{question.Question_text}");
                foreach (var answer in question.Answers)
                {
                    Console.WriteLine(answer.Answer_text);
                }
            }
        }
        public async Task GetQuestionAndTrueAnswerByAmout()
        {
            Console.WriteLine("Enter question amount: ");
            int amount = int.Parse(Console.ReadLine());
            Answers answer = await questionController.GetQuestionAndTrueAnswerByAmout(amount);
            Console.WriteLine($"{answer.Question.Question_text} - {answer.Answer_text}");
        }
    }
}
