

string[] arr1 = {"Hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};
		
int max = 3;
string[] GetShortWordsArray(string[] array)
{
string[] result = new string[array.Length];
int count = 0;
	for (int i = 0; i < array.Length; i++)
		{
		if(array[i].Length <= max)
		 {
			result[count] = array[i];
			count++;
         }
		}
Array.Resize(ref result, count);
		return result;
}
void PrintArray(string[] array)
{
	if(array.Length == 0)
	{
	  Console.WriteLine("[]");
	}
	else
	{
      Array.ForEach(array, (str) => Console.Write($"{str}, "));
    }
		}
		void PrintTask(string[] array)
		{
			PrintArray(array);
			string[] shortArray = GetShortWordsArray(array);
			Console.Write($"=> ");
			PrintArray(shortArray);
			Console.WriteLine();
		}
		
		PrintTask(arr1);
		PrintTask(arr2);
		PrintTask(arr3);
