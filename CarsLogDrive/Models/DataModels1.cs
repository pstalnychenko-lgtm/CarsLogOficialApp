using System;
using System.Collections.Generic;

namespace CarsLogApp.Models
{
    // Користувач системи для авторизації 
    public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; } // ЛОгін користувача
        public string PasswordHash { get; set; } //Данні паролю користувача
    }

    // Дані про водія та його права 
    public class Driver
    {
        public string FullName { get; set; } // Повне імєя
        public string LicenseCategory { get; set; } //Категорія водія (A , B , С , D ...)
        public DateTime LicenseExpiryDate { get; set; } //Дата закінчення терміну дії ліцензії
        public bool MedicalCertStatus { get; set; } // Медичний стан
    }

    // "Серце" системи - Автомобіль 
    public class Vehicle
    {
        public string PlateNumber { get; set; } // Номер автівіки
        public string Brand { get; set; } //Бренд
        public string Model { get; set; } //Модель
        public int Year { get; set; } // Рік Випуску

        public int? YearOfPurchaseTheCar { get; set; } // Рік придбання авто (null - if don't know)
        public string FuelType { get; set; } // Тип двигнуна
        public int CurrentMileage { get; set; } //Поточний пробіг
        public string VIN { get; set; } //VIN-код
    }

    // Облік палива 
    public class FuelEntry
    {
        public double Volume { get; set; } // Кількість літрів
        public string GasStation { get; set; } //Автозаправна станція
        public bool IsFullTank { get; set; } //Повний резервуар
    }

    // Сервісна подія на СТО 
    public class ServiceRecord
    {
        public DateTime DateOfcCarRepairCenter { get; set; } //дата останного сто
        public decimal TotalCost { get; set; } //Загальна вартість
        public List<string> PartsChanged { get; set; } //Замінені деталі
        public string WarrantyPeriod { get; set; } //Гарантійний термін
    }

    // Сервісний центр 
    public class ServiceStation // Клас: Станція технічного обслуговування (СТО)
    {
        public string Name { get; set; } // Назва СТО
        public string Address { get; set; } // Адреса
        public string WorkSpecialization { get; set; } // Спеціалізація робіт
    } 

    // Конкретна деталь 
    public class VehicleComponent // Клас: Компонент (деталь) транспортного засобу
    {
        public string PartID { get; set; } // Ідентифікатор деталі
        public string PartName { get; set; } // Назва деталі
        public string Brand { get; set; } // Бренд/Виробник
        public int InstallationMileage { get; set; } // Пробіг під час встановлення
        public int LifespanKm { get; set; } // Прогноз заміни (ресурс у км)
    } 

    public class Reminder // Клас: Нагадування
    {
        public string Message { get; set; } // Текст повідомлення
        public DateTime? TargetDate { get; set; } // Цільова дата
        public int? TargetMileage { get; set; } // Цільовий пробіг
    } 

    // Текстова нотатка
    public class Note // Клас: Нотатка
    {
        public string Content { get; set; } // Зміст нотатки
        public DateTime CreatedAt { get; set; } // Дата створення
    } 

    // Цифрові копії документів 
    public class Document // Клас: Документ
    {
        public string Title { get; set; } // Назва документа
        public string PolicyNumber { get; set; } // Номер поліса/серія
        public DateTime ExpiryDate { get; set; } // Дата закінчення терміну дії
        public string ImagePath { get; set; } // Шлях до зображення (копії)
    } 
}