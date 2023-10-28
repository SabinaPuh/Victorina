using Victorina.BLL.Contracts;
using Victorina.Core.Models;
using Victorina.DAL;
using Victorina.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Victorina.BLL.Contracts
{
    public interface ICreateVictorina
    {
        void Create(string name, List<Question> questions);
        Quiz TakeQuizByName(string name);
    }
}
