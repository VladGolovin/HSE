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
    /// Логика взаимодействия для HallAssistance.xaml
    /// </summary>
    public partial class HallAssistance : Window
    {
        public HallAssistance()
        {
            InitializeComponent();
        }

        public HallAssistance(string answer1text, string answer2text, string answer3text, string answer4text)
        {
            InitializeComponent();

            var random = new Random();

            var answer1percent = random.Next(70);
            var answer2percent = random.Next(100 - answer1percent);
            var answer3percent = random.Next(100 - (answer1percent + answer2percent));
            var answer4percent = 100 - (answer1percent + answer2percent + answer3percent);

            LblAnswer1.Content = $"{answer1text} : {answer1percent}%";
            LblAnswer2.Content = $"{answer2text} : {answer2percent}%";
            LblAnswer3.Content = $"{answer3text} : {answer3percent}%";
            LblAnswer4.Content = $"{answer4text} : {answer4percent}%";
        }
    }
}
