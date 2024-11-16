using Microsoft.Maui.Controls;
using System;

namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (int.TryParse(NumberEntry.Text, out int number))
            {
                DisplayAlert("Повідомлення", $"Ви ввели число {number}", "OK");
            }
            else
            {
                DisplayAlert("Помилка", "Введене значення не є цілим числом.", "OK");
            }
        }
    }
}
