using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExample
{
    public class Importer
    {
        public List<Question> ReadQuestions()
        {
            var questions = new List<Question>();

            using (var reader = new StreamReader("Questions.txt", Encoding.UTF8))
            {
                reader.ReadLine();

                var line = string.Empty;

                while ((line = reader.ReadLine()) != null)
                {
                    var columns = line.Split('\t');

                    questions.Add(new Question()
                    {
                        Text = columns[0],
                        Answer1 = columns[1],
                        Answer2 = columns[2],
                        Answer3 = columns[3],
                        Answer4 = columns[4],
                        TrueAnswer = columns[int.Parse(columns[5]) - 1],
                        Difficulty = int.Parse(columns[6])
                    });
                }
            }

            return questions;
        }
    }
}
