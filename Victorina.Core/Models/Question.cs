namespace Victorina.Core.Models
{
    public class Question
    {
        public string Name { get; set; }
        public string Answer { get; set; }

        public Question(string name, string answer)
        {
            Name = name;
            Answer = answer;
        }
    }
}