using System;
using System.Collections.Generic;

namespace CarsLogApp.Models
{
    // Користувач системи для авторизації 
    public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
    }

    // Дані про водія та його права 
    public class Driver
    {
        public string FullName { get; set; }
        public string LicenseCategory { get; set; }
        public DateTime LicenseExpiryDate { get; set; }
        public bool MedicalCertStatus { get; set; }
    }

    // "Серце" системи - Автомобіль 
    public class Vehicle
    {
        public string PlateNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string FuelType { get; set; }
        public int CurrentMileage { get; set; }
        public string VIN { get; set; }
    }

    // Облік палива 
    public class FuelEntry
    {
        public double Volume { get; set; } // Кількість літрів
        public decimal PricePerLiter { get; set; }
        public string GasStation { get; set; }
        public bool IsFullTank { get; set; }
    }

    // Сервісна подія на СТО 
    public class ServiceRecord
    {
        public DateTime Date { get; set; }
        public int Mileage { get; set; }
        public decimal TotalCost { get; set; }
        public List<string> PartsChanged { get; set; }
        public string WarrantyPeriod { get; set; }
    }

    // Сервісний центр 
    public class ServiceStation
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string WorkSpecialization { get; set; }
    }

    // Конкретна деталь 
    public class VehicleComponent
    {
        public string PartID { get; set; }
        public string PartName { get; set; }
        public string Brand { get; set; }
        public int InstallationMileage { get; set; }
        public int LifespanKm { get; set; } // Прогноз заміни
    }


    public class Reminder
    {
        public string Message { get; set; }
        public DateTime? TargetDate { get; set; }
        public int? TargetMileage { get; set; }
    }

    // Текстова нотатка
    public class Note
    {
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    // Цифрові копії документів 
    public class Document
    {
        public string Title { get; set; }
        public string PolicyNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string ImagePath { get; set; }
    }
}