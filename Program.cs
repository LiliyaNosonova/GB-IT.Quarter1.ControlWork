// Задача. Написать программу, 
// которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа.

string[] array = { "Hello", "2", "world", ":-)" };

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
        count++;
    }
}

string[] result = new string[count];
count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
        result[count] = array[i];
        count++;
    }
}

void PrintArray(string[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.WriteLine($"{j} элемент искомого массива: {array[j]}");
    }
}
PrintArray(result);

