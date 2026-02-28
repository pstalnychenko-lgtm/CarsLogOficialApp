using CarsLogWorkig.Models;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using System.Diagnostics;

namespace CarsLogDrive
{
    public partial class MainPage : ContentPage
    {
       
        //Резервні поля для елементів керування XAML(використання FindByName у конструкторі)       
        
            
        private Entry _carNameEntry;
        private Entry _plateNumberEntry;
        private Entry _mileageEntry;
        private Entry _ownerNameEntry;
        private Entry _driverNameEntry;
        private VerticalStackLayout _garageListContainer;

        public MainPage()
        {
            InitializeComponent();


            _carNameEntry = this.FindByName<Entry>("CarNameEntry");
            _plateNumberEntry = this.FindByName<Entry>("PlateNumberEntry");
            _mileageEntry = this.FindByName<Entry>("MileageEntry");
            _ownerNameEntry = this.FindByName<Entry>("OwnerNameEntry");
            _driverNameEntry = this.FindByName<Entry>("DriverNameEntry");
            _garageListContainer = this.FindByName<VerticalStackLayout>("GarageListContainer");
        }

        // Назва функції: OnAddCarClicked
        // Майбутній функціонал: Перехід на використання ObservableCollection та SQLite бази даних
        private async void OnAddCarClicked(object sender, EventArgs e)
        {
            try
            {
                // Валідація: перевірка чи заповнені всі 5 полів
                if (string.IsNullOrWhiteSpace(_carNameEntry?.Text) ||
                    string.IsNullOrWhiteSpace(_plateNumberEntry?.Text) ||
                    string.IsNullOrWhiteSpace(_mileageEntry?.Text) ||
                    string.IsNullOrWhiteSpace(_ownerNameEntry?.Text) ||
                    string.IsNullOrWhiteSpace(_driverNameEntry?.Text))
                {
                    await DisplayAlert("Упс!", "Заповни всі поля, щоб продовжити 📝", "Ок");
                    return;
                }

                // Тимчасова логіка: очищення перед додаванням (як ти просив, щоб стара зникла)
                _garageListContainer?.Children.Clear();

                // Створення об'єкта автомобіля
                var newVehicle = new Vehicle1
                {
                    Brand = _carNameEntry.Text,
                    PlateNumber = _plateNumberEntry.Text,
                    CurrentMileage = int.TryParse(_mileageEntry.Text, out int m) ? m : 0
                };

                // Створення візуальної картки (Молодечий стиль)
                var carFrame = new Border
                {
                    Stroke = Color.FromArgb("#00D2FF"), // Голубий колір
                    StrokeThickness = 2,
                    Padding = 15,
                    Margin = new Thickness(0, 10),
                    StrokeShape = new RoundRectangle { CornerRadius = 20 },
                    BackgroundColor = Colors.White,
                    Content = new VerticalStackLayout
                    {
                        Spacing = 5,
                        Children =
                        {
                            new Label { Text = $"🚘 {_carNameEntry.Text}", FontSize = 20, FontAttributes = FontAttributes.Bold, TextColor = Color.FromArgb("#007BFF") },
                            new Label { Text = $"👤 Власник: {_ownerNameEntry.Text}", FontSize = 15 },
                            new Label { Text = $"🆔 Водій: {_driverNameEntry.Text}", FontSize = 15 },
                            new Label { Text = $"📍 {_plateNumberEntry.Text} • {_mileageEntry.Text} км", FontSize = 13, TextColor = Colors.Gray }
                        }
                    }
                };

                // Додавання картки в гараж
                _garageListContainer?.Children.Add(carFrame);

                // Логування в Debugger
                Debug.WriteLine($"Додано: {newVehicle.Brand} для {_ownerNameEntry.Text}");

                // Очищення полів після успішного додавання
                _carNameEntry.Text = string.Empty;
                _plateNumberEntry.Text = string.Empty;
                _mileageEntry.Text = string.Empty;
                _ownerNameEntry.Text = string.Empty;
                _driverNameEntry.Text = string.Empty;

                await DisplayAlert("Готово", "Автівку додано в цифровий гараж! 🚀", "Клас");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Помилка: {ex.Message}");
                await DisplayAlert("Помилка", "Щось пішло не так при створенні картки", "ОК");
            }
        }
    }
}