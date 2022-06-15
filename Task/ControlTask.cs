int arrSize = 1; // размерность первичного массива
string[] array = new string[arrSize]; // первичный массива
int newArrSize = 1; // размерность вторичного массива 
string[] newArray = new string[newArrSize]; // вторичный массива
string value; // переменная значения

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите значение или q для выхода");

    value = Console.ReadLine();

    checkNull(value); // проверка значения на null

    if (value == "q") // проверка на выход из ввода данных
    {
        Array.Resize<string>(ref array, arrSize - 1);
        break;
    }

    else
    {
        array[i] = value;

        if (i == array.Length - 1) // избавление от лишнего пустого элемента массива
        {
            arrSize++;
            Array.Resize<string>(ref array, arrSize); // увеличение размерности массива в зависимости от кол-ва значений
        }
    }
}

int j = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) // проверка значения на условие "кол-во символов меньше 3-х"
    {
        newArray[j] = array[i];
        j++;

        if (newArrSize == newArray.Length)
        {
            newArrSize++;
            Array.Resize<string>(ref newArray, newArrSize); // увеличение размерности массива в зависимости от кол-ва значений
        }
    }
}

Console.WriteLine("[{0}]", string.Join(", ", array)); // печать массива в консоль
Array.Resize<string>(ref newArray, newArrSize - 1); // избавление от лишнего пустого элемента массива
Console.WriteLine("[{0}]", string.Join(", ", newArray)); // печать массива в консоль

string checkNull(string check) // метод проверки на null
{

    if (String.IsNullOrEmpty(check))
    {
        do
        {
            Console.WriteLine("Попробуйте еще раз или q для выхода");
            value = Console.ReadLine();
            if (value == ("q"))
            {
                break;
            }

        } while (String.IsNullOrEmpty(value));

    }
    return value;
}