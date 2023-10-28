using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Victorina.BLL.Contracts;
using Victorina.BLL;
using Victorina.Core.Models;
using System.Runtime.CompilerServices;

namespace Victorina.UI.UI
{
    public static class CreateQuizUI
    {
        private static ICreateVictorina _createVictorina = new CreateVictorina();
        public static void CreateQuiz()
        {
            bool isError = true;
            Console.WriteLine("Введите название опросника:");
            string quizName = Console.ReadLine();
            Console.WriteLine();

            List<Question> questions = new List<Question>();
  
            bool doQuestion = true;

            do
            {

                Console.WriteLine("Введите вопрос: ");
                Console.WriteLine();

                string name = Console.ReadLine();
                var newQuestionName = new Question(name, string.Empty);

                questions.Add(newQuestionName);

                Console.WriteLine();
                Console.WriteLine("Добавить вопрос?");
                Console.WriteLine($"1 - да / 0 - нет");
                Console.WriteLine();

                int choice =  Convert.ToInt32(Console.ReadLine());
                
                if(choice == 1)
                {
                    doQuestion = true;
                }
                else if(choice == 0)
                {
                    doQuestion = false;
                }
                else
                {
                    Console.WriteLine("Введите коректное число. \nВопрос не был сохранён.");
                }

            }
            while (doQuestion);

            _createVictorina.Create(quizName, questions);
        }

        public static void TakeQuiz()
        {
            Console.WriteLine("Введите название опросника для прохождения: ");
            string startName = Console.ReadLine();
            Console.WriteLine();

            Quiz quizToStart = _createVictorina.TakeQuizByName(startName);

            for (int i = 0; i < quizToStart?.Questions?.Count; i++)
            {
                Console.WriteLine($"Вопрос №{i + 1}: {quizToStart.Questions[i].Name}");
                Console.WriteLine("Ответ: ");
                quizToStart.Questions[i].Answer = Console.ReadLine();
                Console.WriteLine();

            }
        }

        public static void PrintQuiz()
        {
            Console.WriteLine();
            Console.WriteLine("Введите название опросника для выведения на консоль: ");
            string nameToPrint = Console.ReadLine();
            Console.WriteLine();

            Quiz quizToPrint = _createVictorina.TakeQuizByName(nameToPrint);

            for (int i = 0; i < quizToPrint.Questions.Count; i++)
            {
                Console.WriteLine($"Вопрос №{i + 1}: {quizToPrint.Questions[i].Name}");
                Console.WriteLine($"Ответ: {quizToPrint.Questions[i].Answer}");
                Console.WriteLine();
            }
        }
    }
}
