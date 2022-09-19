string[] somearray = new string[]  {};


{
  int n = InputNumbers("введите число элементов массива: ");
  somearray  = new string[n];
  for (int i = 0; i < somearray .Length; i++)
  {
    Console.Write($" введите строку{i+1}: ");
    somearray  [i] = Console.ReadLine();
  }
}

void FillArray(string[] oldArray, string[] newArray, int lengthLimit)
{
  int temp = 0;
  for (int i = 0; i < oldArray.Length; i++)
  {
    if (oldArray[i].Length <= lengthLimit)
    {
      newArray[temp] = oldArray[i];
      temp++;
    }
  }
}

int CheckArray(string[] array, int lengthLimit)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= lengthLimit) result++;
  }
  return result;
}


string PrintArray(string[] array)
{ 
  string result = string.Empty;
  result = "[ ";
  for (int i = 0; i < array.Length; i++)
  {
    result += $"{array[i],1}";
    if (i < array.Length - 1) result += ", ";
  }
  result += " ]";
  return result;
}


int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int lengthLimit = 3;

int numItems = CheckArray(somearray , lengthLimit);

string[] newSomeArrayOfStrings = new string[numItems];

FillArray(somearray , newSomeArrayOfStrings, lengthLimit);

Console.WriteLine($"{PrintArray(newSomeArrayOfStrings)}");