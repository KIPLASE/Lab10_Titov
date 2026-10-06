// int[] numbers = { 10, 20, 30 };

// System.Console.WriteLine(numbers[0]);
// System.Console.WriteLine(numbers[2]);
// System.Console.WriteLine(numbers.Length);

// int[] numbers = { 10, 20, 30 };
// foreach (int n in numbers)
// {
//     System.Console.WriteLine(n);
// }

// string word = "код";

// foreach (char letter in word)
// {
//     System.Console.WriteLine(letter);
// }

// int[] numbers = { 10, 20, 30 };

// foreach (int n in numbers)
// {
//     n = n * 2;
// }

// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = numbers[i] * 2;
// }

// string subject = "Программирование";

// foreach (char letter in subject)
// {
//     System.Console.WriteLine(letter);
// }
// System.Console.WriteLine($"Общее количество букв: {subject.Length}");

// int[] grades = { 4, 5, 3, 5, 4 };
// int sum = 0;

// foreach (int grade in grades)
// {
//     System.Console.WriteLine(grade);
//     sum += grade;
// }

// double average = (double)sum / grades.Length;
// System.Console.WriteLine($"Средний балл: {average}");

// string[] students = { "Аня", "Ярослав", "Вика" };
// int count = 0;

// foreach (string student in students)
// {
//     System.Console.WriteLine(student);
//     count++;
// }

// System.Console.WriteLine($"Всего учеников: {count}");

// int[] points = { 10, 20, 15 };

// for (int i = 0; i < points.Length; i++)
// {
//     points[i] = points[i] + 5;
// }

// foreach (int point in points)
// {
//     System.Console.WriteLine(point);
// }

// задача A

// int[] numbers = { 12, 7, 25, 3, 18 };
// int sum = 0;

// foreach (int num in numbers)
// {
//     System.Console.WriteLine(num);
//     sum += num;
// }

// System.Console.WriteLine($"Сумма всех чисел: {sum}");

// // Задача B

// string[] daysofweek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

// foreach (string day in daysofweek)
// {
//     System.Console.WriteLine($"{day}!");
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// var 7

int[] grades = { 5, 4, 3, 5, 4, 1, 5, 3, 2, 5, 5 };
int countfives = 0;

foreach (int grade in grades)
{
    if (grade == 5)
    {
        countfives++;
    }
}
System.Console.WriteLine($"Количество пятёрок {countfives}");

// var 8
string word = "Программирование";

for (int i = word.Length - 1; i >= 0; i--)
{
    System.Console.WriteLine(word[i]);
}
System.Console.WriteLine();