//string[,] table = new string[2,5];

// String.Empty
// table[0,0]   table[0,1]  ... table[0,4]  
// table[1,0]   table[1,1]  ... table[1,4]


//table[1,2] = "слово";

/*for (int rows = 0; rows<2; rows++)
{
    for (int columns = 0; columns<5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}*/


/*int[,] matrix = new int[3,4];
for (int i = 0; i<3; i++)
{
    for (int j = 0; j<4; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}*/

/*int[,] matrix = new int[3,4];

void PrintArray(int[,] matr)
{
for (int i = 0; i<matr.GetLength(0); i++)
{
    for (int j = 0; j<matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
    for (int i = 0; i<matr.GetLength(0); i++)
    {
        for(int j = 0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);*/


/*int[,] pic = new int[,]; // Можно не указывать размер массива, если он прописан вручную

void PrintImage(int[,] image) // Метод который выводит массив
{
    for (int i = 0; i<image.GetLength(0); i++)
    {
        for(int j = 0; j<image.GetLength(1); j++)
        {
            if (image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage (int row, int col) // Метод который закрашивает картинку
{
    if (pic[row,col] == 0)
    {
        pic[row,col] = 1;
        FillImage(row-1,col);
        FillImage(row,col-1);
        FillImage(row+1,col);
        FillImage(row,col+1);
    }
}

PrintImage(pic);
FillImage(13,13);
PrintImage(pic); */


// Поиск факториала через рекурсию

/* double Factorial (int n)
{
    if (n == 1) return n;
    else return n * Factorial(n - 1);
}
for (int i = 1; i<40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
} */

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fib (int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fib(n-1) + Fib(n-2);
}
for (int i = 1; i<10; i++)
{
    Console.WriteLine(Fib(i));
} 