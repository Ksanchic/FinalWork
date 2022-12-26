// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

string[] array = NewArray();
string[] result = FindLessThan(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindLessThan(string[] input, int n) 
{
    string[] output = new string[CountLessThan(input, n)];
    for(int i = 0, j = 0; i < 3; i++) 
    {
        if(input[i].Length <= n)
         {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}

int CountLessThan(string[] input, int n) 
{
    int count = 0;
    for(int i = 0; i < 3; i++) 
    {
      count++;
    }
    return count;
}
string[] NewArray() 
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}
