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