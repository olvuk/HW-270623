int inputNumber(string message) 
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
        if (i == array.Length - 1)
        {
            Console.Write(array[i] + ".");
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
}


int[] inputSomeNums(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;

    }
    return array;
}

int countNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int size = inputNumber("Сколько чисел вы хотите ввести?");
int[] array = inputSomeNums(size);
printArray(array);
Console.WriteLine();
Console.WriteLine($"Вы ввели {countNums(array)} чисел/ла больше 0");
