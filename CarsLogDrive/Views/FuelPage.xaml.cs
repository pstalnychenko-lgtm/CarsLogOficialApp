using System;
using Microsoft.Maui.Controls;

namespace CarsLogDrive.Views
{
    public partial class FuelPage : ContentPage
    {
        public FuelPage()
        {
            InitializeComponent();
        }

        // Назва функції: OnSaveFuelClicked
        // Майбутній функціонал: Збереження об'єкта FuelEntry у базу SQLite
        private async void OnSaveFuelClicked(object sender, EventArgs e)
        {
            try
            {
                // Валідація: перевірка чи всі поля заповнені
                if (string.IsNullOrWhiteSpace(FuelAmountEntry.Text) ||
                    string.IsNullOrWhiteSpace(FuelPriceEntry.Text) ||
                    string.IsNullOrWhiteSpace(CurrentMileageEntry.Text))
                {
                    await DisplayAlert("Увага", "Будь ласка, заповни всі поля заправки ⛽", "Ок");
                    return;
                }

                // Спроба розрахунку вартості
                if (double.TryParse(FuelAmountEntry.Text, out double liters) &&
                    double.TryParse(FuelPriceEntry.Text, out double price))
                {
                    double totalCost = liters * price;

                    // Оновлення інтерфейсу
                    TotalCostLabel.Text = $"Загальна вартість: {totalCost:F2} грн";
                    ResultFrame.IsVisible = true;

                    // Сповіщення користувача
                    await DisplayAlert("Успіх", $"Заправку на суму {totalCost:F2} грн додано!", "Супер");

                    // Очищення полів для наступного вводу
                    FuelAmountEntry.Text = string.Empty;
                    FuelPriceEntry.Text = string.Empty;
                    CurrentMileageEntry.Text = string.Empty;
                }
                else
                {
                    await DisplayAlert("Помилка", "Введи коректні числа у поля", "Ок");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Помилка", $"Сталася помилка: {ex.Message}", "Ок");
            }
        }
    }
}