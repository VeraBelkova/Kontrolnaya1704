// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.

void FillArray (string[]message)
{
  int length = message.Length;
  
  for (int i = 0; i < length; i++)
  {
    Console.WriteLine("Ввдите символ");
    message[i] = Console.ReadLine();
  }
}

void PrintArray(string[] array)
{
  int count = array.Length;
  int index = 0;
  while (index < count)
  {
    Console.Write(array[index]);
    index++;
  }
  Console.WriteLine();
}

string[]array = new string[5];
FillArray(array);
PrintArray(array);

string[]array2 = new string[3];

int count = array2.Length;
for (int i = 0; i < count; i++)
{
  array2[i] = array[i];
}

PrintArray(array2);