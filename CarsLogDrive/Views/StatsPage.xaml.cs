using System;
using Microsoft.Maui.Controls;
using CarsLogApp.Models;

namespace CarsLogDrive.Views
{
    public partial class StatsPage : ContentPage
    {
        public StatsPage()
        {
            InitializeComponent();
        }

        // Метод для оновлення статистики (викликатиметься при відкритті екрана)
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CalculateFinanceAnalytics();
        }

        private void CalculateFinanceAnalytics()
        {
           // Тут ми додамо логіку розрахунку вартості 1 км пробігу
        }
    }
}