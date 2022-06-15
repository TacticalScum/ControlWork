int arrSize = 1;
string[] array = new string[arrSize];
string value;

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите значение или q для выхода");

    value = Console.ReadLine();

    checkNull(value);

    if (value == "q")
    {
        Array.Resize<string>(ref array, arrSize-1);
        break;
    }

    else
    {
        array[i] = value;
        arrSize++;

        if (i == array.Length - 1)
        {
            Array.Resize<string>(ref array, arrSize);
        }
    }
}

Console.WriteLine("[{0}]", string.Join(", ", array));



string checkNull(string check)
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

