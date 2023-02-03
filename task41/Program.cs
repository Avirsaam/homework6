/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/


Console.Clear();
Console.WriteLine("Введите через запятую произвольное количество цифр и нажмите клавишу ввода:");

string[] splits = Console.ReadLine().Split(",");
int[] myArray = new int[splits.Length];

if (StringOfIntegersToArray(splits, myArray))
{
    Console.WriteLine($"Вы ввели {NumberOfPositiveElements(myArray)} чисел больше нуля");
}
else
{
    Console.WriteLine("Ошибка ввода числа");
}


//принимает на вход массив и возвращает
//количество положительных элементов
int NumberOfPositiveElements(int[] array)
{
    int positiveElements = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) positiveElements++;
    }
    return positiveElements;
}

//принимает на вход строку вида 9, 8, 7,6 и
//и заполняет массив, значениями из этой строки
bool StringOfIntegersToArray(string[] input, int[] array)
{
       
    for (int i=0; i < input.Length; i++)
    {
        if (!int.TryParse(input[i].Trim(), out array[i])
        || input.Length == 0 )
        {
            return false;
        }
    }
    return true;
}

//возвращает строку, содержащую элементы массива в 
//удобночитаемом виде
string ArrayToPrettyString(int[] arrayToPrint){
    
    string strResult = string.Empty;
    
    Console.Write("[");
    
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        strResult += arrayToPrint[i];
        
        if (arrayToPrint.Length - i > 1) strResult += ", ";
        else strResult += "]";
    }
    
    return strResult;
}