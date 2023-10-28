using Victorina.UI.Models.Enums;
using Victorina.UI.UI;
using Victorina.UI.Models.Enums;
using Victorina.BLL.Contracts;
using Victorina.BLL;
using Victorina.Core.Models;

bool isRun = true;

while (isRun)
{
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1 - Создать опросник");
    Console.WriteLine("2 - Пройти опросник");
    Console.WriteLine("3 - Вывести на консоль все вопросы и ответы");
    Console.WriteLine("4 - Очистить консоль");
    Console.WriteLine("5 - Выйти из приложения");

    StartMenuEnum userInput;
    try
    {
        userInput = (StartMenuEnum)Convert.ToInt32(Console.ReadLine());

    }
    catch
    {
        Console.Clear();
        continue;
    }

    switch (userInput)
    {
        case StartMenuEnum.Create:
            CreateQuizUI.CreateQuiz();
            break;
        case StartMenuEnum.Take:
            CreateQuizUI.TakeQuiz();
            break;
        case StartMenuEnum.Print:
            CreateQuizUI.PrintQuiz();
            break;
        case StartMenuEnum.Clear:
            Console.Clear();
            break;
        case StartMenuEnum.Exit:
            isRun = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Неизвестная enum");
            Console.WriteLine();
            break;
    }
}