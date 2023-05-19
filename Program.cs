using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the row number of Pascal's triangle: ");
        int rowNumber = int.Parse(Console.ReadLine());

        if (rowNumber < 0)
        {
            Console.WriteLine("Invalid Pascal's triangle row number.");
            Console.Write("Enter the row number of Pascal's triangle: ");
            rowNumber = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Pascal's triangle:");
        for (int i = 0; i <= rowNumber; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(CalculatePascalValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }

    static int CalculatePascalValue(int row, int column)
    {
        if (column == 0 || column == row)
        {
            return 1;
        }
        else
        {
            return CalculatePascalValue(row - 1, column - 1) + CalculatePascalValue(row - 1, column);
        }
    }
}
