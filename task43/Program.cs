/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

const int b1 = 0, k1 = 1, b2 = 2, k2 = 3;
string[] coefNames = {"b1", "k1", "b2", "k2"}; 

double [] coefs = new double[coefNames.Length];

Console.Clear();
Console.WriteLine("Введите значения {0}, {1}, {2}, {3} через запятую и нажмите клавишу ввода:",
                    coefNames[b1], coefNames[k1], coefNames[b2], coefNames[k2]);

string[] splits = Console.ReadLine().Split(",");

if (StringOfIntegersToArray(splits, coefs))
{
    for (int i = 0; i < coefs.Length; i++)
    {
        Console.Write($"{coefNames[i]} = {coefs[i]}");
        if (coefs.Length - i > 1) Console.Write(", ");
        else Console.Write(" -> ");
    }
    
    if (coefs[k1] == coefs[k2]){
        Console.Write("Прямые параллельны");
        if (coefs[b1] == coefs[b2]) Console.Write(" и совпадают");
        else Console.Write(" и не имеют точек пересечения");
        Console.WriteLine();

        return;
    }

    double interceptionX = (coefs[b2] - coefs[b1]) / (coefs[k1] - coefs[k2]);
    double interceptionY = coefs[k1] * interceptionX + coefs[b1];

    Console.WriteLine("({0}; {1})", interceptionX, interceptionY);
}
else
{
    Console.WriteLine("Ошибка ввода числа");
}


//принимает на вход строку вида 9, 8, 7,6 и
//и заполняет массив, значениями из этой строки
bool StringOfIntegersToArray(string[] input, double[] array)
{
       
    for (int i=0; i < input.Length; i++)
    {
        if (!double.TryParse(input[i].Trim(), out array[i])
        || input.Length == 0 )
        {
            return false;
        }
    }
    return true;
}

