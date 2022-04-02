System.Console.WriteLine("Введите количество элементов массива");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
int result = 0;
System.Console.WriteLine("Заполните массив:");

for (int i = 0; i < M; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i]>0) result = result + 1; 
}

System.Console.WriteLine($"Ответ: {result}");