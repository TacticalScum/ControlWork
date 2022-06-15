int arrSize = 1; 
string[] array = new string[arrSize]; 
int newArrSize = 1; 
string[] newArray = new string[newArrSize]; 
string value; 

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите значение или q для выхода");

    value = Console.ReadLine();

    checkNull(value);

    if (value == "q")
    {
        Array.Resize<string>(ref array, arrSize - 1);
        break;
    }

    else
    {
        array[i] = value;

        if (i == array.Length - 1)
        {
            arrSize++;
            Array.Resize<string>(ref array, arrSize);
        }
    }
}

int j = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;

        if (newArrSize == newArray.Length)
        {
            newArrSize++;
            Array.Resize<string>(ref newArray, newArrSize);
        }
    }
}

Console.WriteLine("[{0}]", string.Join(", ", array));
Array.Resize<string>(ref newArray, newArrSize - 1);
Console.WriteLine("[{0}]", string.Join(", ", newArray));

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