System.Console.WriteLine("Введите количество строк и столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[ , ] matrix = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == 0 || i == m-1) matrix[i,j] = 1;
        else if (j == 0 || j == n-1) matrix[i,j] = 1;
        else matrix[i,j] = 0;
        System.Console.Write(matrix[i,j] + " ");
    }
    System.Console.WriteLine();
}