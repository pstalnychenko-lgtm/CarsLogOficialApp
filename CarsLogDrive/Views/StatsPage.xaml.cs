using System;
using Microsoft.Maui.Controls;

namespace CarsLogDrive.Views
{
    public partial class StatsPage : ContentPage
    {
        public StatsPage()
        {
            InitializeComponent();
        }

        // Назва функції: OnAppearing
        // Майбутній функціонал: Автоматичне завантаження даних з SQLite при відкритті вкладки
        protected override void OnAppearing()
        {
            base.OnAppearing();
            UpdateDashboard();
        }

        // Назва функції: OnRefreshStatsClicked
        private void OnRefreshStatsClicked(object sender, EventArgs e)
        {
            UpdateDashboard();
        }

        private void UpdateDashboard()
        {
            // Тимчасові дані для демонстрації дизайну
            double fuelSpent = 4500.50;
            double serviceSpent = 1200.00;
            int mileage = 15200;

            // Розрахунок вартості 1 км
            double costPerKm = (fuelSpent + serviceSpent) / (mileage > 0 ? mileage : 1);

            // Оновлення інтерфейсу
            TotalFuelLabel.Text = $"{fuelSpent:N0} грн";
            TotalServiceLabel.Text = $"{serviceSpent:N0} грн";
            TotalMileageLabel.Text = $"{mileage:N0} км";
            CostPerKmLabel.Text = $"{costPerKm:F2} грн";
        }
    }
}