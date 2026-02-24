using CarsLogApp.Models;
using System.Diagnostics;

namespace CarsLogDrive
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Обробник натискання на кнопку "Додати в гараж"
        private async void OnAddCarClicked(object sender, EventArgs e)
        {
            try
            {
                // Створюємо об'єкт автомобіля згідно з аналізом 
                var newVehicle = new Vehicle
                {
                    Brand = CarNameEntry.Text,
                    PlateNumber = PlateNumberEntry.Text,
                    CurrentMileage = int.TryParse(MileageEntry.Text, out int m) ? m : 0
                };

                // Логування для перевірки в Debugger
                Debug.WriteLine($"Додано авто: {newVehicle.Brand}, Номер: {newVehicle.PlateNumber}");

                // Показуємо повідомлення користувачу
                await DisplayAlert("Успіх", $"Автомобіль {newVehicle.Brand} додано в цифровий гараж!", "OK");

                // Очищуємо поля після введення
                CarNameEntry.Text = string.Empty;
                PlateNumberEntry.Text = string.Empty;
                MileageEntry.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Помилка: {ex.Message}");
                await DisplayAlert("Помилка", "Не вдалося зберегти дані", "OK");
            }
        }
    }
}