// === Задание 1: Калькулятор оценок ===
Console.WriteLine("=== Задание 1: Калькулятор оценок ===");
int[] grades = { 5, 4, 5, 3, 2, 5, 4 };

int sum = 0;
int count5 = 0;
int count2 = 0;

for (int i = 0; i < grades.Length; i++)
{
    sum += grades[i];

    if (grades[i] == 5)
    {
        count5++;
    }
    else if (grades[i] == 2)
    {
        count2++;
    }
}

double average = (double)sum / grades.Length;

Console.WriteLine($"Средний балл: {average:F2}");
Console.WriteLine($"Количество пятёрок: {count5}");
Console.WriteLine($"Количество двоек: {count2}");

Console.WriteLine("\nНажмите Enter, чтобы перейти к Заданию 2.");
Console.ReadLine();
Console.Clear();

// === Задание 2: Переворот массива ===
Console.WriteLine("Задание 2: Переворот массива ");
int[] numbers = { 10, 20, 30, 40, 50 };

Console.Write("Прямой порядок: ");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();

Console.Write("Обратный порядок: ");
for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}

Console.WriteLine("\n\nНажмите Enter, чтобы очистить консоль и перейти к Заданию 3...");
Console.ReadLine();
Console.Clear();

// === Задание 3: Чётные числа от 1 до 20 ===
Console.WriteLine("Задание 3: Чётные числа от 1 до 20 ");
for (int i = 1; i <= 20; i++)
{
    if (i % 2 != 0)
    {
        continue;
    }

    Console.Write(i + " ");
}

Console.WriteLine("\n\nНажмите Enter, чтобы очистить консоль и перейти к Заданию 4...");
Console.ReadLine();
Console.Clear();

// === Задание 4: Ввод пароля ===
Console.WriteLine("Задание 4: Ввод пароля");
string correctPassword = "1234";
int attempts = 0;
int maxAttempts = 3;
bool isAccessGranted = false;

while (attempts < maxAttempts)
{
    Console.Write("Введите пароль: ");
    string input = Console.ReadLine() ?? "";
    attempts++;

    if (input == correctPassword)
    {
        Console.WriteLine("Доступ разрешен");
        isAccessGranted = true;
        break;
    }
    else
    {
        Console.WriteLine($"Неверный пароль. Осталось попыток: {maxAttempts - attempts}");
    }
}

if (!isAccessGranted)
{
    Console.WriteLine("Доступ запрещён");
}
