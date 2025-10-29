using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    // Задание 1. Методы

    /**
     * 1. Сумма знаков.
     * Дана сигнатура метода: public int sumLastNums (int x);
     * Необходимо реализовать метод таким образом, чтобы он возвращал результат
     * сложения двух последних знаков числах, предполагая, что знаков в числе не
     * менее двух. Подсказки:
     * int x=123%10; // х будет иметь значение 3
     * int у=123/10; // у будет иметь значение 12
     * Пример:
     * x=4568
     * результат: 14
     */
    public int SumLastNums(int x)
    {
        return (x % 10) + ((x / 10) % 10);
    }

    /**
     * 2. Есть ли позитив.
     * Дана сигнатура метода: public bool isPositive (int x);
     * Необходимо реализовать метод таким образом, чтобы он принимал число x и
     * возвращал true, если оно положительное.
     * Пример 1:
     * x=3
     * результат: true
     * Пример 2:
     * x=-5
     * результат: false
     */
    public bool IsPositive(int x)
    {
        return x > 0;
    }

    /**
     * 3. Большая буква.
     * Дана сигнатура метода: public bool isUpperCase (char x);
     * Необходимо реализовать метод таким образом, чтобы он принимал символ x и
     * возвращал true, если это большая буква в диапазоне от ‘A’ до ‘Z’.
     * Пример 1:
     * x=’D’
     * результат: true
     * Пример 2:
     * x=’q’
     * результат: false
     */
    public bool IsUpperCase(char x)
    {
        return x >= 'A' && x <= 'Z';
    }

    /**
     * 4. Делитель.
     * Дана сигнатура метода: public bool isDivisor (int a, int b);
     * Необходимо реализовать метод таким образом, чтобы он возвращал true, если
     * любое из принятых чисел делит другое нацело.
     * Пример 1:
     * a=3 b=6
     * результат: true
     * Пример 2:
     * a=2 b=15
     */
    public bool IsDivisor(int a, int b)
    {
        return (a != 0 && b % a == 0) || (b != 0 && a % b == 0);
    }

    /**
     * 5. Многократный вызов.
     * Дана сигнатура метода: public int lastNumSum(int a, int b)
     * Необходимо реализовать метод таким образом, чтобы он считал сумму цифр
     * двух чисел из разряда единиц. Выполните с его помощью последовательное
     * сложение пяти чисел и результат выведите на экран. Постарайтесь выполнить
     * задачу, используя минимально возможное количество вспомогательных
     * переменных.
     * Пример:
     * 5+11 это 6
     * 6+123 это 9
     * 9+14 это 13
     * 13+1 это 4
     * Итого 4
     */
    public int LastNumSum(int a, int b)
    {
        return (a % 10) + (b % 10);
    }

    // Задание 2. Условия

    /**
     * 1. Безопасное деление.
     * Дана сигнатура метода: public double safeDiv (int x, int y);
     * Необходимо реализовать метод таким образом, чтобы он возвращал деление x
     * на y, и при этом гарантировал, что не будет выкинута ошибка деления на 0. При
     * делении на 0 следует вернуть из метода число 0. Подсказка: смотри
     * ограничения на операции типов данных.
     * Пример 1:
     * x=5 y=0
     * результат: 0
     * Пример 2:
     * x=8 y=2
     * результат: 4
     */
    public double SafeDiv(int x, int y)
    {
        if (y == 0)
        {
            return 0;
        }
        return (double)x / y;
    }

    /**
     * 2. Строка сравнения.
     * Дана сигнатура метода: public String makeDecision (int x, int y);
     * Необходимо реализовать метод таким образом, чтобы он возвращал строку,
     * которая включает два принятых методом числа и корректно выставленный
     * знак операции сравнения (больше, меньше, или равно).
     * Пример 1:
     * x=5 y=7
     * результат: “5< 7”
     * Пример 2:
     * x=8 y=-1
     * результат: “8 >-1”
     * Пример 3:
     * x=4 y=4
     * результат: “4==4”
     */
    public string MakeDecision(int x, int y)
    {
        if (x < y)
        {
            return x + "<" + y;
        }
        else if (x > y)
        {
            return x + ">" + y;
        }
        else
        {
            return x + "==" + y;
        }
    }

    /**
     * 3. Тройная сумма.
     * Дана сигнатура метода: public bool sum3 (int x, int y, int z);
     * Необходимо реализовать метод таким образом, чтобы он возвращал true, если
     * два любых числа (из трех принятых) можно сложить так, чтобы получить
     * третье.
     * Пример 1:
     * x=5 y=7 z=2
     * результат: true
     * Пример 2:
     * x=8 y=-1 z=4
     */
    public bool Sum3(int x, int y, int z)
    {
        return (x + y == z) || (x + z == y) || (y + z == x);
    }

    /**
     * 4. Возраст.
     * Дана сигнатура метода: public String age (int x);
     * Необходимо реализовать метод таким образом, чтобы он возвращал строку, в
     * которой сначала будет число х, а затем одно из слов:
     * год
     * года
     * лет
     * Слово “год” добавляется, если число х заканчивается на 1, кроме числа 11.
     * Слово “года” добавляется, если число х заканчивается на 2, 3 или 4, кроме чисел
     * 12, 13, 14.
     * Слово “лет”добавляется во всех остальных случаях.
     * Подсказка: оператор % позволяет получить остаток от деления.
     * Пример 1:
     * x=5
     * результат: “5 лет”
     * Пример 2:
     * x=31
     * результат: “31 год”
     * Пример 3:
     * x=44
     * результат: “44 года”
     */
    public string Age(int x)
    {
        int lastDigit = x % 10;
        if (lastDigit == 1 && x != 11)
        {
            return x + " год";
        }
        else if ((lastDigit == 2 || lastDigit == 3 || lastDigit == 4) && (x < 12 || x > 14))
        {
            return x + " года";
        }
        else
        {
            return x + " лет";
        }
    }

    /**
     * 5. Вывод дней недели.
     * Дана сигнатура метода: public void printDays (String x);
     * В качестве параметра метод принимает строку, в которой записано название
     * дня недели. Необходимо реализовать метод таким образом, чтобы он выводил
     * на экран название переданного в него дня и всех последующих до конца недели
     * дней. Если в качестве строки передан не день, то выводится текст “это не день
     * недели”. Первый день понедельник, последний – воскресенье. Вместо if в данной
     * задаче используйте switch.
     * Пример 1:
     * x=”четверг”
     * результат:
     * четверг
     * пятница
     * суббота
     * воскресенье
     * Пример 2:
     * x=”чг”
     * результат:
     * это не день недели
     */
    public void PrintDays(string x)
    {
        switch (x)
        {
            case "понедельник":
                Console.WriteLine("понедельник");
                goto case "вторник";
            case "вторник":
                Console.WriteLine("вторник");
                goto case "среда";
            case "среда":
                Console.WriteLine("среда");
                goto case "четверг";
            case "четверг":
                Console.WriteLine("четверг");
                goto case "пятница";
            case "пятница":
                Console.WriteLine("пятница");
                goto case "суббота";
            case "суббота":
                Console.WriteLine("суббота");
                goto case "воскресенье";
            case "воскресенье":
                Console.WriteLine("воскресенье");
                break;
            default:
                Console.WriteLine("это не день недели");
                break;
        }
    }

    // Задание 3. Циклы

    /**
     * 1. Числа наоборот.
     * Дана сигнатура метода: public String reverseListNums (int x);
     * Необходимо реализовать метод таким образом, чтобы он возвращал строку, в
     * которой будут записаны все числа от x до 0 (включительно).
     * Пример:
     * x=5
     * результат: “5 4 3 2 1 0”
     */
    public string ReverseListNums(int x)
    {
        string result = "";
        for (int i = x; i >= 0; i--)
        {
            result += i + " ";
        }
        return result.Trim();
    }

    /**
     * 2. Степень числа.
     * Дана сигнатура метода: public int pow (int x, int y);
     * Необходимо реализовать метод таким образом, чтобы он возвращал результат
     * возведения x в степень y.
     * Подсказка: для получения степени необходимо умножить единицу на число x, и
     * сделать это y раз, т.е. два в третьей степени это 1*2*2*2
     * Пример:
     * x=2
     * y=5
     * результат: 32
     */
    public int Pow(int x, int y)
    {
        int result = 1;
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }
        return result;
    }

    /**
     * 3. Одинаковость.
     * Дана сигнатура метода: public bool equalNum (int x);
     * Необходимо реализовать метод таким образом, чтобы он возвращал true, если
     * все знаки числа одинаковы, и false в ином случае.
     * Подсказки:
     * intx=123%10; // х будет иметь значение 3
     * intу=123/10; // у будет иметь значение 12
     * Пример 1:
     * x=1111
     * результат: true
     * Пример 2:
     * x=1211
     */
    public bool EqualNum(int x)
    {
        string s = x.ToString();
        if (s.Length <= 1) return true;
        char first = s[0];
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] != first)
            {
                return false;
            }
        }
        return true;
    }

    /**
     * 4. Левый треугольник.
     * Дана сигнатура метода: public void leftTriangle (int x);
     * Необходимо реализовать метод таким образом, чтобы он выводил на экран
     * треугольник из символов ‘*’ у которого х символов в высоту, а количество
     * символов в ряду совпадает с номером строки.
     * Пример 1:
     * x=2
     * результат:
     * *
     * **
     * Пример 2:
     * x=4
     * результат:
     * *
     * **
     * ***
     * ****
     */
    public void LeftTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    /**
     * 5. Угадайка.
     * Дана сигнатура метода: public void guessGame()
     * Необходимо реализовать метод таким образом, чтобы он генерировал
     * случайное число от 0 до 9, далее считывал с консоли введенное пользователем
     * число и выводил, угадал ли пользователь то, что было загадано, или нет. Метод
     * запускается до тех пор, пока пользователь не угадает число. После этого
     * выведите на экран количество попыток, которое потребовалось пользователю,
     * чтобы угадать число.
     * Пример:
     * Введите число от 0 до 9:
     * 5
     * Вы не угадали, введите число от 0 до 9:
     * 9
     * Вы угадали!
     * Вы отгадали число за 2 попытки
     */
    public void GuessGame()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 10);
        int guess;
        int attempts = 0;

        do
        {
            Console.WriteLine("Введите число от 0 до 9:");
            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Некорректный ввод. Введите число от 0 до 9:");
            }

            if (guess < 0 || guess > 9)
            {
                Console.WriteLine("Число должно быть в диапазоне от 0 до 9.");
                continue;
            }

            attempts++;

            if (guess != randomNumber)
            {
                Console.WriteLine("Вы не угадали, введите число от 0 до 9:");
            }

        } while (guess != randomNumber);

        Console.WriteLine("Вы угадали!");
        Console.WriteLine("Вы отгадали число за " + attempts + " попытки");
    }

    // Задание 4. Массивы

    /**
     * 1. Поиск последнего значения.
     * Дана сигнатура метода: public int findLast (int[] arr, int x);
     * Необходимо реализовать метод таким образом, чтобы он возвращал индекс
     * последнего вхождения числа x в массив arr. Если число не входит в массив –
     * возвращается -1.
     * Пример:
     * arr=[1,2,3,4,2,2,5]
     * x=2
     * результат: 5
     */
    public int FindLast(int[] arr, int x)
    {
        int lastIndex = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                lastIndex = i;
            }
        }
        return lastIndex;
    }

    /**
     * 2. Добавление в массив.
     * Дана сигнатура метода: public int[]add (int[] arr, int x, int pos);
     * Необходимо реализовать метод таким образом, чтобы он возвращал новый
     * массив, который будет содержать все элементы массива arr, однако в позицию
     * pos будет вставлено значение x.
     * Пример:
     * arr=[1,2,3,4,5]
     * x=9
     * pos=3
     * результат: [1,2,3,9,4,5]
     */
    public int[] Add(int[] arr, int x, int pos)
    {
        int[] newArr = new int[arr.Length + 1];
        for (int i = 0, j = 0; i < newArr.Length; i++)
        {
            if (i == pos)
            {
                newArr[i] = x;
            }
            else
            {
                newArr[i] = arr[j];
                j++;
            }
        }
        return newArr;
    }

    /**
     * 3. Реверс.
     * Дана сигнатура метода: public void reverse (int[] arr);
     * Необходимо реализовать метод таким образом, чтобы он изменял массив arr.
     * После проведенных изменений массив должен быть записан задом-наперед.
     * Пример:
     * arr=[1,2,3,4,5]
     * результат: arr=[5,4,3,2,1]
     */
    public void Reverse(int[] arr)
    {
        Array.Reverse(arr);
    }

    /**
     * 4. Объединение.
     * Дана сигнатура метода: public int[] concat (int[] arr1,int[] arr2);
     * Необходимо реализовать метод таким образом, чтобы он возвращал новый
     * массив, в котором сначала идут элементы первого массива (arr1), а затем
     * второго (arr2).
     * Пример:
     * arr1=[1,2,3]
     * arr2=[7,8,9]
     * результат: [1,2,3,7,8,9]
     */
    public int[] Concat(int[] arr1, int[] arr2)
    {
        return arr1.Concat(arr2).ToArray();
    }

    /**
     * 5. Удалить негатив.
     * Дана сигнатура метода: public int[] deleteNegative (int[] arr);
     * Необходимо реализовать метод таким образом, чтобы он возвращал новый
     * массив, в котором записаны все элементы массива arr кроме отрицательных.
     * Пример:
     * arr=[1,2,-3,4,-2,2,-5]
     * результат: [1,2,4,2]
     */
    public int[] DeleteNegative(int[] arr)
    {
        return arr.Where(x => x >= 0).ToArray();
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine("Привет! Это консольное приложение для решения задач.");

        while (true)
        {
            Console.WriteLine("\nВыберите задание:");
            Console.WriteLine("1. Задание 1: Методы");
            Console.WriteLine("2. Задание 2: Условия");
            Console.WriteLine("3. Задание 3: Циклы");
            Console.WriteLine("4. Задание 4: Массивы");
            Console.WriteLine("0. Выход");

            Console.Write("Ваш выбор: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Некорректный ввод. Введите число от 0 до 4.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    RunTask1(solution);
                    break;
                case 2:
                    RunTask2(solution);
                    break;
                case 3:
                    RunTask3(solution);
                    break;
                case 4:
                    RunTask4(solution);
                    break;
                case 0:
                    Console.WriteLine("Выход из программы.");
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, выберите от 0 до 4.");
                    break;
            }
        }
    }

    private static void RunTask1(Solution solution)
    {
        Console.WriteLine("\nВыбрано задание 1: Методы");

        Console.Write("Введите число для суммы последних элементов: ");
        if (int.TryParse(Console.ReadLine(), out int x1))
        {
            Console.WriteLine($"SumLastNums({x1}) = {solution.SumLastNums(x1)}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }

        Console.Write("Введите число для проверки на положительность: ");
        if (int.TryParse(Console.ReadLine(), out int x2))
        {
            Console.WriteLine($"IsPositive({x2}) = {solution.IsPositive(x2)}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }

        Console.Write("Введите символ для проверки на загланый: ");
        string input3 = Console.ReadLine();
        if (input3.Length > 0)
        {
            char x3 = input3[0];
            Console.WriteLine($"IsUpperCase('{x3}') = {solution.IsUpperCase(x3)}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }

        Console.Write("Введите первое число для проверки делителя: ");
        if (int.TryParse(Console.ReadLine(), out int a))
        {
            Console.Write("Введите второе число для проверки делителя: ");
            if (int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine($"IsDivisor({a}, {b}) = {solution.IsDivisor(a, b)}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }


        Console.WriteLine("Выполнение многократного вызова суммы последних символов:");
        int sum = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Введите число {i} (для LastNumSum): ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                sum = solution.LastNumSum(sum, num);
                Console.WriteLine($"Сумма последних цифр: {sum}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
        Console.WriteLine($"Итого: {sum}");
    }

    private static void RunTask2(Solution solution)
    {
        Console.WriteLine("\nВыбрано задание 2: Условия");

        Console.Write("Введите делимое для SafeDiv: ");
        if (int.TryParse(Console.ReadLine(), out int x1))
        {
            Console.Write("Введите делитель для безопасного деления: ");
            if (int.TryParse(Console.ReadLine(), out int y1))
            {
                Console.WriteLine($"SafeDiv({x1}, {y1}) = {solution.SafeDiv(x1, y1)}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }


        Console.Write("Введите первое число для сравнения: ");
        if (int.TryParse(Console.ReadLine(), out int x2))
        {
            Console.Write("Введите второе число для сравнения: ");
            if (int.TryParse(Console.ReadLine(), out int y2))
            {
                Console.WriteLine($"MakeDecision({x2}, {y2}) = {solution.MakeDecision(x2, y2)}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }


        Console.Write("Введите первое число для тройной суммы: ");
        if (int.TryParse(Console.ReadLine(), out int x3))
        {
            Console.Write("Введите второе число для тройной суммы: ");
            if (int.TryParse(Console.ReadLine(), out int y3))
            {
                Console.Write("Введите третье число для тройной суммы: ");
                if (int.TryParse(Console.ReadLine(), out int z3))
                {
                    Console.WriteLine($"Sum3({x3}, {y3}, {z3}) = {solution.Sum3(x3, y3, z3)}");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }


        Console.Write("Введите возраст для возраста: ");
        if (int.TryParse(Console.ReadLine(), out int x4))
        {
            Console.WriteLine($"Age({x4}) = {solution.Age(x4)}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }


        Console.Write("Введите день недели для вывода дней недели: ");
        string day = Console.ReadLine();
        Console.WriteLine($"PrintDays({day}):");
        solution.PrintDays(day);
    }

    private static void RunTask3(Solution solution)
    {
        Console.WriteLine("\nВыбрано задание 3: Циклы");

        Console.Write("Введите число для чисел наоборот: ");
        if (int.TryParse(Console.ReadLine(), out int x1))
        {
            Console.WriteLine($"ReverseListNums({x1}) = {solution.ReverseListNums(x1)}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }


        Console.Write("Введите число для степени числа: ");
        if (int.TryParse(Console.ReadLine(), out int x2))
        {
            Console.Write("Введите степень для степения числа: ");
            if (int.TryParse(Console.ReadLine(), out int y2))
            {
                Console.WriteLine($"Pow({x2}, {y2}) = {solution.Pow(x2, y2)}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }


        Console.Write("Введите число для проверки на одинаковость символов: ");
        if (int.TryParse(Console.ReadLine(), out int x3))
        {
            Console.WriteLine($"EqualNum({x3}) = {solution.EqualNum(x3)}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }


        Console.Write("Введите высоту треугольника для левого треугольника: ");
        if (int.TryParse(Console.ReadLine(), out int x4))
        {
            Console.WriteLine($"LeftTriangle({x4}):");
            solution.LeftTriangle(x4);
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }

        Console.WriteLine("Запуск игры угадайка:");
        solution.GuessGame();
    }

    private static void RunTask4(Solution solution)
    {
        Console.WriteLine("\nВыбрано задание 4: Массивы");

        Console.Write("Введите размер массива для поиска последнего значения: ");
        if (int.TryParse(Console.ReadLine(), out int size1))
        {
            int[] arr1 = new int[size1];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < size1; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    arr1[i] = element;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Прерывание ввода массива.");
                    return;
                }
            }

            Console.Write("Введите число для поиска в массиве: ");
            if (int.TryParse(Console.ReadLine(), out int x1))
            {
                Console.WriteLine($"FindLast([{string.Join(", ", arr1)}], {x1}) = {solution.FindLast(arr1, x1)}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }



        Console.Write("Введите размер массива для добавления: ");
        if (int.TryParse(Console.ReadLine(), out int size2))
        {
            int[] arr2 = new int[size2];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < size2; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    arr2[i] = element;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Прерывание ввода массива.");
                    return;
                }
            }

            Console.Write("Введите число для добавления в массив: ");
            if (int.TryParse(Console.ReadLine(), out int x2))
            {
                Console.Write("Введите позицию для добавления в массив: ");
                if (int.TryParse(Console.ReadLine(), out int pos2))
                {
                    int[] result = solution.Add(arr2, x2, pos2);
                    Console.WriteLine($"Add([{string.Join(", ", arr2)}], {x2}, {pos2}) = [{string.Join(", ", result)}]");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }


        Console.Write("Введите размер массива для Reverse: ");
        if (int.TryParse(Console.ReadLine(), out int size3))
        {
            int[] arr3 = new int[size3];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < size3; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    arr3[i] = element;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Прерывание ввода массива.");
                    return;
                }
            }

            solution.Reverse(arr3);
            Console.WriteLine($"Reverse([{string.Join(", ", arr3)}]) = [{string.Join(", ", arr3)}]");
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }


        Console.Write("Введите размер первого массива для объединения: ");
        if (int.TryParse(Console.ReadLine(), out int size41))
        {
            int[] arr41 = new int[size41];
            Console.WriteLine("Введите элементы первого массива:");
            for (int i = 0; i < size41; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    arr41[i] = element;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Прерывание ввода массива.");
                    return;
                }
            }

            Console.Write("Введите размер второго массива для объединения: ");
            if (int.TryParse(Console.ReadLine(), out int size42))
            {
                int[] arr42 = new int[size42];
                Console.WriteLine("Введите элементы второго массива:");
                for (int i = 0; i < size42; i++)
                {
                    if (int.TryParse(Console.ReadLine(), out int element))
                    {
                        arr42[i] = element;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Прерывание ввода массива.");
                        return;
                    }
                }

                int[] result = solution.Concat(arr41, arr42);
                Console.WriteLine($"Concat([{string.Join(", ", arr41)}], [{string.Join(", ", arr42)}]) = [{string.Join(", ", result)}]");
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }



        Console.Write("Введите размер массива для удаления отрицательных: ");
        if (int.TryParse(Console.ReadLine(), out int size5))
        {
            int[] arr5 = new int[size5];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < size5; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    arr5[i] = element;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Прерывание ввода массива.");
                    return;
                }
            }

            int[] result = solution.DeleteNegative(arr5);
            Console.WriteLine($"DeleteNegative([{string.Join(", ", arr5)}]) = [{string.Join(", ", result)}]");
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }
    }
}
