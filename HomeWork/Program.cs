using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace WPU221_lesson1
{
    class Program
    {
        static void startQuiz()
        {
            string[] questions =
            {
                "Самая высокая гора? эверест или эльбрус? - ",
                "Самая длинная река? амазонка или волга? - ",
                "Самая большая страна? россия или китай? - "
            };
            string[] answers =
            {
                "эверест", "амазонка", "россия"
            };
            int countOfRightAnswers = 0;
            string userAnswer;

            for (int i = 0; i < questions.Length; i++)
            {
                Write(questions[i]);
                userAnswer = ReadLine();
                if (userAnswer.ToLower() == answers[i])
                {
                    countOfRightAnswers++;
                    WriteLine("Ответ верный!");
                }
                else
                {
                    WriteLine("Ответ неверный!");
                }
            }

            WriteLine("Правильных ответов: " + countOfRightAnswers);
            if (countOfRightAnswers == 3)
            {
                WriteLine("5баллов");
            }
            if (countOfRightAnswers == 2)
            {
                WriteLine("4баллa");
            }
            if (countOfRightAnswers == 1)
            {
                WriteLine("3баллa");
            }
            else if (countOfRightAnswers == 0)
            {
                WriteLine("2баллa");
            }
            WriteLine("Нажми 1 для перезапуска игры\'Викторина\'");
            WriteLine("Нажми 0 для выхода");
            int userChoice = Int32.Parse(ReadLine());
            switch (userChoice)
            {

                case 1:
                    startQuiz();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
        static void Main(string[] args)
        {
            startQuiz();

        }
    }
}
