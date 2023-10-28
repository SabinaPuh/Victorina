using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Victorina.DAL.Contracts;
using Victorina.Core.Models;

namespace Victorina.DAL
{
    internal class VictorinaDao : IVictorinaDao
    {
        private const string PATH = "C:\\Users\\soubi\\source\\repos\\Victorina2\\Victorina.json";
        public void Create(Quiz quiz)
        {
            var quizzes = new List<Quiz>();

            if (File.Exists(PATH))
            {
                using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
                {
                    quizzes = JsonSerializer.Deserialize<List<Quiz>>(fs);
                }
            }

            quizzes.Add(quiz);
            Write(quizzes);
        }

        public List<Quiz> GetQuiz ()
        {
            var quizzes = new List<Quiz>();

             if (File.Exists(PATH))
            {
                using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
                {
                    quizzes = JsonSerializer.Deserialize<List<Quiz>>(fs);
                }
            }

            return quizzes;
        }

        private void Write(List<Quiz> quizzes)
        {
            using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<List<Quiz>>(fs, quizzes);
            }
        }
    }
}
