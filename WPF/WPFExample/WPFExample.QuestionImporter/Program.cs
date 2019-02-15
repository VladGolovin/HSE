using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExample.QuestionImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Импорт вопросов для игры \"Кто хочет стать милионером\"");

            Console.WriteLine("Загрузка вопросов из файла");

            var importer = new Importer();

            var questions = importer.ReadQuestions();

            Console.WriteLine($"Загружено {questions.Count} вопросов");

            Console.WriteLine("Запись вопросов в базу данных");

            var context = new QuestionContext();

            context.Database.ExecuteSqlCommand("DELETE FROM Questions");

            context.Questions.AddRange(questions);

            context.SaveChanges();

            Console.WriteLine("Все вопросы успешно сохранены в базу данных!");

            Console.ReadKey();
        }
    }
}
