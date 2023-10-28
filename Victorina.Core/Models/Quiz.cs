namespace Victorina.Core.Models
{
    public class Quiz
    {
        public string QuizName { get; set; }
        public List<Question> Questions { get; set; }


        public Quiz(string quizName, List<Question> questions)
        {
            QuizName = quizName; 
            Questions = questions;
        }

    }
}
