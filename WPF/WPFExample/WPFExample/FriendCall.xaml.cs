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
using System.Windows.Shapes;

namespace WPFExample
{
    /// <summary>
    /// Логика взаимодействия для FriendCall.xaml
    /// </summary>
    public partial class FriendCall : Window
    {
        public FriendCall()
        {
            InitializeComponent();
        }

        public FriendCall(string questionText, string questionAnswer)
        {
            InitializeComponent();

            LblQuestionText.Content = $"Вы: {questionText}";
            LblQuestionAnswer.Content = $"Чак: Я уверен, что правильный ответ - {questionAnswer}";
        }
    }
}
