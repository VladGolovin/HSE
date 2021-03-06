﻿

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

        protected int Difficulty { get; set; } = 15;

        protected bool IsFirstMistake { get; set; } = true;

        protected bool HallAssistanceAvailable { get; set; } = true;

        protected bool FriendCallAvailable { get; set; } = true;

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
            if (Difficulty == 16)
            {
                MessageBox.Show("Вы выйграли!!!");

                SaveWinner();

                ResetAppState();
            }
            else
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
        }

        private void ChooseAnswer(object sender, RoutedEventArgs e)
        {
            var answerBtn = sender as Button;

            var answer = answerBtn.Content;

            if (answer.Equals(CurrentQuestion.TrueAnswer))
            {
                MessageBox.Show("Ответ правильный :)");

                (Stages.Items[14 - Difficulty + 1] as ListBoxItem).Background = Brushes.Orange;

                Difficulty++;

                NextQuestion();
            }
            else
            {
                if (IsFirstMistake)
                {
                    DisableButton(MistakeSave);

                    DisableButton(answerBtn);

                    IsFirstMistake = false;

                    MessageBox.Show("Вы ответили не верно, у вас больше нет права на ошибку :(");
                }
                else
                {
                    MessageBox.Show("Вы проиграли");

                    ResetAppState();
                }
            }

            ClearAnswersStates();
        }

        private void ResetAppState()
        {
            Difficulty = 1;

            ResetStages();

            NextQuestion();

            ClearAnswersStates();

            EnableButton(FiftyFifty);

            EnableButton(FriendCall);

            EnableButton(MistakeSave);

            EnableButton(HallAssistance);
        }

        private void ResetStages()
        {
            foreach (var stage in Stages.Items)
            {
                (stage as ListBoxItem).Background = Stages.Background;
            }
        }

        private void SaveWinner()
        {
            var winnerNameInput = new WinnerNameInput();

            if (winnerNameInput.ShowDialog() == true)
            {
                Winners.Items.Add(new ListBoxItem() { Content = winnerNameInput.UserName, Foreground = Brushes.White });
            }
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

        private void FriendCall_Click(object sender, RoutedEventArgs e)
        {
            if (FriendCallAvailable)
            {
                FriendCallAvailable = false;

                DisableButton(FriendCall);

                var friendCallForm = new FriendCall(CurrentQuestion.Text, CurrentQuestion.TrueAnswer);

                friendCallForm.Show();
            }
        }

        private void HallAssistance_Click(object sender, RoutedEventArgs e)
        {
            if (HallAssistanceAvailable)
            {
                HallAssistanceAvailable = false;

                DisableButton(HallAssistance);

                var hallAssistForm = new HallAssistance(
                    Answer1.Content.ToString(),
                    Answer2.Content.ToString(),
                    Answer3.Content.ToString(),
                    Answer4.Content.ToString());

                hallAssistForm.Show();
            }
        }
    }
}
