using System.Windows;
using System.Windows.Controls;

namespace AlinaZaraCalculatorGirtHubProject
{
    public partial class MainWindow : Window
    {
        // Переменные для логики
        double previousNumber = 0;
        string currentOperation = "";
        bool isNewEntry = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Обработчик для цифр (0-9) и точки
        private void Button_Number_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Content.ToString();

            if (isNewEntry)
            {
                DisplayTextBox.Text = number;
                isNewEntry = false;
            }
            else
            {
                // Защита: чтобы нельзя было поставить две точки подряд (например, 5.5.5)
                if (number == "." && DisplayTextBox.Text.Contains("."))
                {
                    return;
                }
                DisplayTextBox.Text += number;
            }

        }

        // Обработчик для операций (+, -, *, /)
        private void Button_Operation_Click(object sender, RoutedEventArgs e)
        {
            
        }

        // Обработчик для кнопки "="
        private void Button_Equals_Click(object sender, RoutedEventArgs e)
        {
            
        }

        // Обработчик для кнопки "Стереть" (C)
        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}