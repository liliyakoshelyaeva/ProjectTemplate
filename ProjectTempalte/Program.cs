using System.Collections;
using System.Text.RegularExpressions;

namespace ProjectTempalte
{
    internal class Program
    {
        static void StackTask()
        {
            Console.WriteLine("Stack Task");
            Stack<int> stack = new Stack<int>(5);
            //добавление элементов в стек
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            //выведение элементов стека
            Console.WriteLine($"Размер стека: {stack.Size}");
            Console.WriteLine($"Верхний элемент: {stack.Peek()}");
            //извлечение элементов из стека
            Console.WriteLine($"Извлечённый элемент: {stack.Pop()}");
            Console.WriteLine($"Извлечённый элемент: {stack.Pop()}");
            //проверка на пустоту стека
            Console.WriteLine($"Стек пуст: {stack.IsEmpty()}");
        }
        static void DeepLookStackTask()
        {
            Console.WriteLine("DeepLookStack Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после реализации класса DeepLookStack
                                                        // и как-то протестируйте ваш код
            Console.WriteLine("-------");
        }
        static void QueueTask()
        {
            Console.WriteLine("Queue Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после реализации класса Queue
                                                        // и как-то протестируйте ваш код
            Console.WriteLine("-------");
        }
        // При работе с файлами, создавайте и наполняйте их сами. Но не забывайти использовать относительные пути
        static void StringTask()
        {
            Console.WriteLine("String Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: прочитать данные из файла (реализуйте и используйте функцию ReadFromFile из файла Functions.cs) и
            // Вывести:
            // * количество слов в тексте
            // * самое длинное слово
            // Можно считать, что слова разделены пробелами. Вместо явных циклов используйте LINQ.
            Console.WriteLine("-------");
        }
        static void RegexTask()
        {
            Console.WriteLine("Regex Task");
            string emailRegex = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
            string fileName = "test.txt";
            int emailCount = 0;
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        if (Regex.IsMatch(word, emailRegex))
                        {
                            emailCount++;
                        }
                    }
                }
            }
            Console.WriteLine($"Количество email адресов в файле: {emailCount}");
            // TODO: написать Regex, который сумеет распознать email адрес.
            // Прочитать данные из файла и вывести количество email адресов.
            // Слов (а потенциально и адресов) в строке может быть несколько
            // Можно считать, что слова разделены пробелами
            Console.WriteLine("-------");
        }
        static void BinaryTask()
        {
            Console.WriteLine("Binary Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: реализовать функции чтения из бинароного файла и записи в него в Functions.cs.
            // Записать некоторое количество целых чисел в бинарный файл.
            // После прочитать этот же бинарный файл и вывести считанные значения на экран
            Console.WriteLine("-------");
        }
        static void DictionaryTask()
        {
            Console.WriteLine("Dictionary Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: создать Dictionary, где ключ - имя студента, а значение - лист его оценок по предметам за семестр.
            // Заполните словарь для 3-4 студентов.
            // Запросите у пользователя строку - имя студента, по которому он хочет узнать среднюю оценку.
            // Выведите результат. Вместо явных циклов используйте LINQ.
            Console.WriteLine("-------");
        }
        static void RecursionTask()
        {
            Console.WriteLine("Recursion Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: рекурсивно описать функцию MinDigit(int n) (находится в Functions.cs),
            // которая находит наименьшую цифру в десятичной записи неотрицательного целого числа N.
            // Например, MinDigit(27316) = 1.
            Console.WriteLine("-------");
        }
        static void Main(string[] args)
        {
            StackTask();
            DeepLookStackTask();
            QueueTask();
            StringTask();
            StringTask();
            RegexTask();
            BinaryTask();
            DictionaryTask();
            RecursionTask();
        }

        // TODO:
        // Функция должна прочитать содержимое файла и привести полученные строки к нижнему регистру.
        // Также должны быть удалены знаки препинания
        static List<string> ReadFromFile(string filePath)
        {
            return new(); // Заглушка
        }

        // TODO:
        // Функция должная считывать и возвращать прочитанные целые числа из бинарного файла
        static List<int> ReadIntsFromBinaryFile(string path)
        {
            return new(); // Заглушка
        }

        // TODO:
        // Функция должная записывать целые числа в бинарный файл
        static void WriteIntsToBinaryFile(string path, List<int> data)
        {
        }

        int MinDigit(int n)
        {
            return 0; // Заглушка
        }
    }




}
