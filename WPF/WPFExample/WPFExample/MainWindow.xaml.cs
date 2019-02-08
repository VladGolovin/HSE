

namespace WPFExample
{
    using System;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected QuestionContext Context { get; set; } = new QuestionContext();

        protected Question CurrentQuestion { get; set; }

        protected int Difficulty { get; set; } = 0;

        protected bool IsFirstMistake { get; set; } = true;

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
                Stages.Items.Add(new ListBoxItem() { Content = stage });
            }
        }

        private void SetupWinners()
        {
            Winners.Items.Add(new ListBoxItem() { Content = "Победители:" });
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
            Difficulty++;

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
            var answerBtn = sender as Button;

            var answer = answerBtn.Content;

            if (answer.Equals(CurrentQuestion.TrueAnswer))
            {
                MessageBox.Show("Ответ правильный :)");

                NextQuestion();
            }
            else
            {
                if (IsFirstMistake)
                {
                    DisableButton(MistakeSave);

                    DisableButton(answerBtn);

                    MessageBox.Show("Вы ответили не верно, у вас больше нет права на ошибку :(");
                }
                else
                {
                    MessageBox.Show("Вы проиграли");
                }
            }

            ClearAnswersStates();
        }

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void FiftyFifty_Click(object sender, RoutedEventArgs e)
        {
            FiftyFifty.IsEnabled = false;

            var answers = 2;
            
            if (!Answer1.Content.ToString().Equals(CurrentQuestion.TrueAnswer))
            {
                DisableButton(Answer1);

                answers--;
            }

            if (!Answer2.Content.ToString().Equals(CurrentQuestion.TrueAnswer))
            {
                DisableButton(Answer2);

                answers--;
            }

            if (!Answer3.Content.ToString().Equals(CurrentQuestion.TrueAnswer) && answers > 0)
            {
                DisableButton(Answer3);

                answers--;
            }

            if (!Answer4.Content.ToString().Equals(CurrentQuestion.TrueAnswer) && answers > 0)
            {
                DisableButton(Answer4);

                answers--;
            }
        }

        private void ClearAnswersStates()
        {
            EnableButton(Answer1);
            EnableButton(Answer2);
            EnableButton(Answer3);
            EnableButton(Answer4);
        }

        private void DisableButton(Button btn)
        {
            btn.IsEnabled = false;
        }

        private void EnableButton(Button btn)
        {
            btn.IsEnabled = true;
        }
    }
}
