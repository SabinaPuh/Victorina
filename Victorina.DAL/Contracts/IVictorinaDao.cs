using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Victorina.Core.Models;

namespace Victorina.DAL.Contracts
{
    public interface IVictorinaDao
    {
        void Create(Quiz quiz);
        List<Quiz> GetQuiz();

    }
}
