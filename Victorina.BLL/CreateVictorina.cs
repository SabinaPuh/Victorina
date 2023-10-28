using Victorina.BLL.Contracts;
using Victorina.Core.Models;
using Victorina.DAL;
using Victorina.DAL.Contracts;

namespace Victorina.BLL
{
    public class CreateVictorina : ICreateVictorina
    {
        private readonly VictorinaDao _quiz = new VictorinaDao();

        public void Create(string name, List<Question> questions)
        {
            var quiz = new Quiz(name, questions);
            _quiz.Create(quiz);

        }

        public Quiz TakeQuizByName(string name)
        {
            var quizzes = _quiz.GetQuiz();
            var quiz = quizzes.FirstOrDefault(q => q.QuizName == name);
            return quiz;
        }

    }
}
