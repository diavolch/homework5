/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] getRandomArray(int length, int startPoint, int endPoint)
{
    double[] resultArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = Math.Round(new Random().NextDouble()*((endPoint+1) - startPoint), 3);
    }
    return resultArray;
}
void printArray(double[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
double getMaxInArray(double[] incomingArray)
{
    double maxNumber = incomingArray[0];
    for (int i = 1; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] > maxNumber)
        {
            maxNumber = incomingArray[i];
        }
    }
    return maxNumber;
}
double getMinInArray(double[] incomingArray)
{
    double minNumber = incomingArray[0];
    for (int i = 1; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] < minNumber)
        {
            minNumber = incomingArray[i];
        }
    }
    return minNumber;
}
double getSubstractionBetweenMaxAndMinNumbers(double[] incomingArray)
{
    double substraction = 0;
    double maxNumber = getMaxInArray(incomingArray);
    double minNumber = getMinInArray(incomingArray);
    substraction = maxNumber - minNumber;
    return substraction;
}

Console.Write($"Задайте длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] currentArray = getRandomArray(length, 0, 100);
printArray(currentArray);
double substractionBetweenNumbers = getSubstractionBetweenMaxAndMinNumbers(currentArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом = {substractionBetweenNumbers}");