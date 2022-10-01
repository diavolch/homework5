/*
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и 
предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint+1);
    }
    return resultArray;
}
void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
int[] getMultiplicateOfArray(int[] incomingArray)
{   
    int length = incomingArray.Length;
    int ostatok = length % 2;
    int lengthNewArray = length / 2;
    int[] resultOfArray = new int[lengthNewArray + ostatok];
    
    for (int i = 0; i < lengthNewArray + ostatok; i++)
    {
        resultOfArray[i] = incomingArray[i] * incomingArray[length - 1 - i];
    }
    if (ostatok != 0)
    {
        resultOfArray[lengthNewArray] = incomingArray[lengthNewArray];
    }
    return resultOfArray;
}


int[] randomArray = getRandomArray(7, 1, 5);
int[] currentArray = getMultiplicateOfArray(randomArray);
printArray(randomArray);
printArray(currentArray);