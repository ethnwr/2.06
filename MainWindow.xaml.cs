using System;
using System.Windows;
using System.Windows.Input;

namespace AllTasksInOne
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        // Задание 1
        private void Yes_Click(object sender, RoutedEventArgs e)
            => MessageBox.Show("Мы и не сомневались!");

        private void No_MouseEnter(object sender, MouseEventArgs e)
        {
            var rnd = new Random();
            NoBtn.Margin = new Thickness(rnd.Next(0, 300), rnd.Next(0, 100), 0, 0);
        }

        // Задание 2
        private void ShowDate_Click(object sender, RoutedEventArgs e)
            => DateLabel.Text = MyDatePicker.SelectedDate?.ToString("dd.MM.yyyy") ?? "Дата не выбрана";

        // Задание 3
        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            var rnd = new Random();
            int target = rnd.Next(1, 2001);
            int attempts = 0;

            while (MessageBox.Show($"Это {target}?", "Угадай", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
            {
                attempts++;
                target = rnd.Next(1, 2001);
            }

            GameStatus.Text = $"Угадано за {attempts + 1} попыток";
            if (MessageBox.Show("Ещё раз?", "Игра", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                StartGame_Click(sender, e);
        }

        // Задания 4-5
        private void CloseTriangle_Click(object sender, RoutedEventArgs e)
            => MessageBox.Show("Это треугольная форма", "Инфо");

        private void CloseInherited_Click(object sender, RoutedEventArgs e)
            => MessageBox.Show("Это наследуемая форма", "Привет");
    }
}
