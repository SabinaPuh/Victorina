namespace Victorina.Core.Models
{
    public class Quiz
    {
        public string QuizName { get; set; }
        public List<Question> Questions = new List<Question>();

        public Quiz(string name, List<Question> questions)
        {
            QuizName = name; 
            Questions = questions;
        }
    }
}
