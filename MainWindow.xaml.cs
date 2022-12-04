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

namespace GPA_calc__special_for_Dnevnik.ru_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            string inputStr = MarkInputBox.Text.Replace(" ", string.Empty);
            char[] markInput_arr = inputStr.ToCharArray();

            markInput_arr = inputStr.ToCharArray();

            float sum = 0;
            float i = 0;
            List<float> intsums = new List<float>();

            foreach (char sym in markInput_arr)
            {
                if (((float)Char.GetNumericValue(sym) > 0) || ((float)Char.GetNumericValue(sym) < 6))
                {
                    if ((float)Char.GetNumericValue(sym) == -1)
                        continue;
                    sum += (float)Char.GetNumericValue(sym);
                    intsums.Add(sum);
                    i++;
                }
            }
            float avg = sum / i;
            LabelAverageOutput.Text = avg.ToString("#.##");
            double avgRounded = Math.Round(avg);
            LabelAverageRoundedOutput.Text = avgRounded.ToString();

        }


    }
}
