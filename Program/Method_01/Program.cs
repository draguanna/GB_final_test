//------------------------------------------------------------------------------------------------------------------
//                                                Итоговое задание                                   
//   Написать программу, которая из имеющегося массива* строк формирует новый массив** из строк, длина которых меньше, 
//   либо равна 3 символам. 
//   * Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//   ** При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

// 1. Ввод исходного массива с клавиатуры.
string[] inputArray = ReadArray("Введите элементы массива через запятую и пробел: ");

// 2. Узнаем длину результирующего массива.
int maxLength = 3;
int size = FindSizeOfNewArray(inputArray, maxLength);

// 3. Заполняем новый массив подходящими элементами из первого и выводим результат.
if (size > 0)
{
    string[] resultArray = FillResultArray(inputArray, maxLength, size);
    PrintArray("\nРезультат преобразования: ", resultArray);
}
else
{   Console.Write($"\nВсе введённые строки содержат более {maxLength} символов."); }

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

// Ввод значений массива с клавиатуры.
string[] ReadArray(string msg)
{
    Console.WriteLine(msg);
    string input = Console.ReadLine() ?? "";
    return input.Split(", ");
}

// Подсчет количества подходящих строк в исходном массиве.
int FindSizeOfNewArray(string[] array, int maxLength)
{
    return array.Count(s => s.Length <= maxLength);
}

// Заполнение результирующего массива.
string[] FillResultArray(string[] array, int maxLength, int size)
{
    string[] resultArray = new string[size];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            resultArray[index] = array[i];
            index++;
        }
    }

    return resultArray;
}

// Вывод элементов массива в консоль.
void PrintArray(string msg, string[] array)
{
    Console.WriteLine(msg);
    Console.Write($"[{string.Join(", ", array.Select(s => $"\"{s}\""))}]");
}