using System;
using System.Collections.Generic;
using System.Linq;

// Задание 1.3 - Имя

/**
  Создайте сущность Имя, которая описывается тремя параметрами: Фамилия, Личное имя,
Отчество. Имя может быть приведено к строковому виду, включающему традиционное
представление всех трех параметров: Фамилия Имя Отчество (например “Иванов Иван
Иванович”). Необходимо предусмотреть возможность того, что какой-либо из параметров может
быть не задан, и в этом случае он не учитывается при приведении к текстовому виду.
Необходимо создать следующие имена:
• Клеопатра
• Пушкин Александр Сергеевич
• Маяковский Владимир
Обратите внимание, что при выводе на экран, не заданные параметры никак не участвуют в
образовании строки.
*/
public class Name
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }

    // Конструкторы
    public Name() { }

    public Name(string lastName, string firstName, string middleName)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
    }

    public Name(string firstName)
    {
        FirstName = firstName;
    }

    public Name(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }

    // Метод ToString
    public override string ToString()
    {
        List<string> parts = new List<string>();

        if (!string.IsNullOrEmpty(LastName))
            parts.Add(LastName);
        if (!string.IsNullOrEmpty(FirstName))
            parts.Add(FirstName);
        if (!string.IsNullOrEmpty(MiddleName))
            parts.Add(MiddleName);

        return string.Join(" ", parts);
    }
}

// Задание 1.2 - Человек (базовый)

/*
  Создайте сущность Человек, которая описывается:
• Имя: строка
• Рост: целое число
Может возвращать текстовое представление вида “Name, рост: height”, где Name и height это
переменная с именем и ростом.
Необходимо создать и вывести на экран следующих людей:
• Человек с именем “Клеопатра” и ростом 152
• Человек с именем “Пушкин ” и ростом 167
• Человек с именем “Владимир ” и ростом 189
*/
public class Person
{
    public string Name { get; set; }
    public int Height { get; set; }

    // Конструкторы
    public Person() { }

    public Person(string name, int height)
    {
        Name = name;
        Height = height;
    }

    // Метод ToString
    public override string ToString()
    {
        return $"{Name}, рост: {Height}";
    }
}

// Задание 2 - Человек с именем

/**
  Объедините сущности Человек из задачи 1.2 и Имя из задачи 1.3 таким образом, чтобы имя
человека задавалось с использованием сущности 1.3, а не строки.
Необходимо объединить ранее созданные объекты имен и людей, с получением:
• Человека с Именем Клеопатра и ростом 152
• Человека с Именем Пушкин Александр Сергеевичи ростом 167
• Человека с Именем Маяковский Владимир и ростом 189
*/
public class PersonWithName
{
    public Name FullName { get; set; }
    public int Height { get; set; }

    // Конструкторы
    public PersonWithName() { }

    public PersonWithName(Name fullName, int height)
    {
        FullName = fullName;
        Height = height;
    }

    public PersonWithName(string firstName, int height)
    {
        FullName = new Name(firstName);
        Height = height;
    }

    public PersonWithName(string lastName, string firstName, int height)
    {
        FullName = new Name(lastName, firstName);
        Height = height;
    }

    public PersonWithName(string lastName, string firstName, string middleName, int height)
    {
        FullName = new Name(lastName, firstName, middleName);
        Height = height;
    }

    // Метод ToString
    public override string ToString()
    {
        return $"{FullName}, рост: {Height}";
    }
}

// Задание 3 и 4 - Город

/** 3. Создайте сущность Город, которая будет представлять собой точку на карте со следующими
характеристиками:
• Название города
• Набор путей к следующим городам, где путь представляет собой сочетание Города и
стоимости поездки в него.
Кроме того, Город может возвращать текстовое представление, в виде названия города и списка
связанных с ним городов (в виде пары: “название:стоимость”).
Используя разработанную сущность реализуйте схему, представленную на рисунке 2.

4. Измените сущность Город из задачи 3.3. Новые требования включают:
• Город можно создать указав только название
• Город можно создать указав название и набор связанных с ним городов и стоимостей
путей к ним
*/
public class City
{
    public string Name { get; set; }
    public Dictionary<City, int> ConnectedCities { get; set; }

    // Конструкторы (Задание 4)
    public City(string name)
    {
        Name = name;
        ConnectedCities = new Dictionary<City, int>();
    }

    public City(string name, Dictionary<City, int> connectedCities)
    {
        Name = name;
        ConnectedCities = connectedCities ?? new Dictionary<City, int>();
    }

    // Метод для добавления связи с городом
    public void AddConnection(City city, int cost)
    {
        if (city != null && !ConnectedCities.ContainsKey(city))
        {
            ConnectedCities.Add(city, cost);
        }
    }

    // Метод ToString
    public override string ToString()
    {
        if (ConnectedCities.Count == 0)
            return $"{Name} (нет связей)";

        var connections = string.Join(", ", ConnectedCities.Select(c => $"{c.Key.Name}:{c.Value}"));
        return $"{Name} -> {connections}";
    }

    public override bool Equals(object obj)
    {
        return obj is City city && Name == city.Name;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}

// Задание 5 - Дробь

/**
 * Создайте сущность Дробь со следующими особенностями:
• Имеет числитель: целое число
• Имеет знаменатель: целое число
• Дробь может быть создана с указанием числителя и знаменателя
• Может вернуть строковое представление вида “числитель/знаменатель”
• Может выполнять операции сложения, вычитания, умножения и деления с другой Дробью
или целым числом. Результатом операции должна быть новая Дробь (таким образом,обе
исходные дроби не изменяются)
Затем необходимо выполнить следующие задачи:
1. Создать несколько экземпляров дробей.
2. Написать по одному примеру использования каждого метода.
3. Вывести на экран примеры и результаты их выполнения в формате «1/3 * 2/3 = 2/9»
4. Посчитать f1.sum(f2).div(f3).minus(5)
*/
public class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    // Конструктор
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Знаменатель не может быть равен нулю");

        Numerator = numerator;
        Denominator = denominator;
        Simplify();
    }

    // Метод для сокращения дроби
    private void Simplify()
    {
        int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
        Numerator /= gcd;
        Denominator /= gcd;

        // Убедимся, что знаменатель всегда положительный
        if (Denominator < 0)
        {
            Numerator = -Numerator;
            Denominator = -Denominator;
        }
    }

    // Наибольший общий делитель
    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Метод ToString
    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }

    // Операции с дробями
    public Fraction Add(Fraction other)
    {
        int newNumerator = Numerator * other.Denominator + other.Numerator * Denominator;
        int newDenominator = Denominator * other.Denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction Subtract(Fraction other)
    {
        int newNumerator = Numerator * other.Denominator - other.Numerator * Denominator;
        int newDenominator = Denominator * other.Denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction Multiply(Fraction other)
    {
        int newNumerator = Numerator * other.Numerator;
        int newDenominator = Denominator * other.Denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction Divide(Fraction other)
    {
        if (other.Numerator == 0)
            throw new DivideByZeroException("Деление на нулевую дробь");

        int newNumerator = Numerator * other.Denominator;
        int newDenominator = Denominator * other.Numerator;
        return new Fraction(newNumerator, newDenominator);
    }

    // Операции с целыми числами
    public Fraction Add(int number)
    {
        return Add(new Fraction(number, 1));
    }

    public Fraction Subtract(int number)
    {
        return Subtract(new Fraction(number, 1));
    }

    public Fraction Multiply(int number)
    {
        return Multiply(new Fraction(number, 1));
    }

    public Fraction Divide(int number)
    {
        return Divide(new Fraction(number, 1));
    }

    // Синонимы методов для удобства 
    public Fraction Sum(Fraction other) => Add(other);
    public Fraction Sum(int number) => Add(number);
    public Fraction Minus(Fraction other) => Subtract(other);
    public Fraction Minus(int number) => Subtract(number);
    public Fraction Div(Fraction other) => Divide(other);
    public Fraction Div(int number) => Divide(number);
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== ЛАБОРАТОРНАЯ РАБОТА №2 ===");

        // Задание 1.2 - Человек
        Console.WriteLine("ЗАДАНИЕ 1.2 - ЧЕЛОВЕК");
        Person person1 = new Person("Клеопатра", 152);
        Person person2 = new Person("Пушкин", 167);
        Person person3 = new Person("Владимир", 189);

        Console.WriteLine(person1);
        Console.WriteLine(person2);
        Console.WriteLine(person3);
        Console.WriteLine();

        // Задание 1.3 - Имя
        Console.WriteLine("ЗАДАНИЕ 1.3 - ИМЯ");
        Name name1 = new Name("Клеопатра");
        Name name2 = new Name("Пушкин", "Александр", "Сергеевич");
        Name name3 = new Name("Маяковский", "Владимир");

        Console.WriteLine(name1);
        Console.WriteLine(name2);
        Console.WriteLine(name3);
        Console.WriteLine();

        // Задание 2 - Человек с именем
        Console.WriteLine("ЗАДАНИЕ 2 - ЧЕЛОВЕК С ИМЕНЕМ");
        PersonWithName personWithName1 = new PersonWithName(name1, 152);
        PersonWithName personWithName2 = new PersonWithName(name2, 167);
        PersonWithName personWithName3 = new PersonWithName(name3, 189);

        Console.WriteLine(personWithName1);
        Console.WriteLine(personWithName2);
        Console.WriteLine(personWithName3);
        Console.WriteLine();

        // Задание 3 и 4 - Города
        Console.WriteLine("ЗАДАНИЕ 3 и 4 - ГОРОДА");

        // Создаем города
        City moscow = new City("Москва");
        City spb = new City("Санкт-Петербург");
        City kazan = new City("Казань");
        City sochi = new City("Сочи");
        City vladivostok = new City("Владивосток");

        // Создаем связи между городами 
        moscow.AddConnection(spb, 500);
        moscow.AddConnection(kazan, 700);

        spb.AddConnection(moscow, 500);
        spb.AddConnection(sochi, 1000);

        kazan.AddConnection(moscow, 700);
        kazan.AddConnection(vladivostok, 3000);

        sochi.AddConnection(spb, 1000);
        sochi.AddConnection(vladivostok, 2500);

        vladivostok.AddConnection(kazan, 3000);
        vladivostok.AddConnection(sochi, 2500);

        // Выводим информацию о городах
        City[] cities = { moscow, spb, kazan, sochi, vladivostok };
        foreach (var city in cities)
        {
            Console.WriteLine(city);
        }
        Console.WriteLine();

        // Задание 5 - Дроби
        Console.WriteLine("ЗАДАНИЕ 5 - ДРОБИ");

        // Создаем дроби
        Fraction f1 = new Fraction(1, 3);
        Fraction f2 = new Fraction(2, 3);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(5, 6);

        Console.WriteLine("Созданные дроби:");
        Console.WriteLine($"f1 = {f1}");
        Console.WriteLine($"f2 = {f2}");
        Console.WriteLine($"f3 = {f3}");
        Console.WriteLine($"f4 = {f4}");
        Console.WriteLine();

        // Примеры операций
        Console.WriteLine("Примеры операций:");

        // Сложение
        Fraction resultAdd = f1.Add(f2);
        Console.WriteLine($"{f1} + {f2} = {resultAdd}");

        // Вычитание
        Fraction resultSubtract = f3.Subtract(f4);
        Console.WriteLine($"{f3} - {f4} = {resultSubtract}");

        // Умножение
        Fraction resultMultiply = f1.Multiply(f2);
        Console.WriteLine($"{f1} * {f2} = {resultMultiply}");

        // Деление
        Fraction resultDivide = f3.Divide(f4);
        Console.WriteLine($"{f3} / {f4} = {resultDivide}");

        // Операции с целыми числами
        Console.WriteLine($"\nОперации с целыми числами:");
        Console.WriteLine($"{f1} + 2 = {f1.Add(2)}");
        Console.WriteLine($"{f2} * 3 = {f2.Multiply(3)}");
        Console.WriteLine($"{f3} - 1 = {f3.Subtract(1)}");
        Console.WriteLine($"{f4} / 2 = {f4.Divide(2)}");

        // Цепочка операций как в задании
        Console.WriteLine($"\nЦепочка операций: f1.Sum(f2).Div(f3).Minus(5)");
        Fraction chainResult = f1.Sum(f2).Div(f3).Minus(5);
        Console.WriteLine($"{f1}.Sum({f2}).Div({f3}).Minus(5) = {chainResult}");

        Console.ReadLine();
    }
}
