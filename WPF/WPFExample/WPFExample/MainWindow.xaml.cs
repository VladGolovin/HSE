using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected QuestionContext Context { get; set; } = new QuestionContext();

        protected Question CurrentQuestion { get; set; }

        protected int Difficulty { get; set; } = 1;

        public MainWindow()
        {
            InitializeComponent();

            SetupStages();

            SetupWinners();

            NextQuestion();
        }

        private void SetupStages()
        {
            var stages = new string[] {
                "3 000 000", "1 500 000", " 800 000",
                " 400 000", " 200 000", " 100 000",
                " 50 000", " 25 000", " 15 000",
                " 10 000", " 5 000", " 3 000",
                " 2 000", " 1 000", " 500" };

            foreach (var stage in stages)
            {
                Stages.Items.Add(new ListBoxItem() { Content = stage, Foreground = Brushes.White });
                }
        }

        private void SetupWinners()
        {
            Winners.Items.Add(new ListBoxItem() { Content = "Победители:",  Foreground = Brushes.White });
        }

        private void SetQuestion(Question question)
        {
            QuestionText.Content = question.Text;

            Answer1.Content = question.Answer1;
            Answer2.Content = question.Answer2;
            Answer3.Content = question.Answer3;
            Answer4.Content = question.Answer4;
        }

        private void NextQuestion()
        {
            var questionsCount = Context.Questions.Where(question => question.Difficulty == Difficulty).Count();

            var rnd = new Random();

            CurrentQuestion = Context.Questions
                .Where(question => question.Difficulty == Difficulty)
                .OrderBy(question => question.Id)
                .Skip(rnd.Next(questionsCount - 1))
                .First();

            SetQuestion(CurrentQuestion);
        }

        private void ChooseAnswer(object sender, RoutedEventArgs e)
        {
            var answer = (sender as Button).Content;

            if (answer.Equals(CurrentQuestion.TrueAnswer))
            {
                MessageBox.Show("Ответ правильный :)");

                (Stages.Items[14 - Difficulty - 1] as ListBoxItem).Background = Brushes.Orange;

                Difficulty++;

                NextQuestion();
            }
            else
            {
                MessageBox.Show("Вы ответили не верно :(");
            }
        }

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
