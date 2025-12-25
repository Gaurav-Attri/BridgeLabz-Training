using System;
class MatrixManipulation{
    static void Main(string[] args){
        Console.WriteLine("Enter rows and columns for first matrix");
        int rowsA = int.Parse(Console.ReadLine());
        int colsA = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter rows and columns for second matrix");
        int rowsB = int.Parse(Console.ReadLine());
        int colsB = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of first matrix");
        double[,] matrixA = ReadMatrix(rowsA, colsA);

        Console.WriteLine("Enter elements of second matrix");
        double[,] matrixB = ReadMatrix(rowsB, colsB);

        Console.WriteLine("Matrix A");
        DisplayMatrix(matrixA);
        Console.WriteLine("Matrix B");
        DisplayMatrix(matrixB);

        if (rowsA == rowsB && colsA == colsB)
        {
            Console.WriteLine("A + B");
            DisplayMatrix(AddMatrices(matrixA, matrixB));

            Console.WriteLine("A - B");
            DisplayMatrix(SubtractMatrices(matrixA, matrixB));
        }

        if (colsA == rowsB)
        {
            Console.WriteLine("A * B");
            DisplayMatrix(MultiplyMatrices(matrixA, matrixB));
        }

        Console.WriteLine("Transpose of A");
        DisplayMatrix(TransposeMatrix(matrixA));

        if (rowsA == 2 && colsA == 2)
        {
            double det2A = Determinant2x2(matrixA);
            Console.WriteLine("Determinant of 2x2 A: " + det2A);
            Console.WriteLine("Inverse of 2x2 A (if exists)");
            DisplayMatrix(Inverse2x2(matrixA));
        }

        if (rowsA == 3 && colsA == 3)
        {
            double det3A = Determinant3x3(matrixA);
            Console.WriteLine("Determinant of 3x3 A: " + det3A);
            Console.WriteLine("Inverse of 3x3 A (if exists)");
            DisplayMatrix(Inverse3x3(matrixA));
        }
    }

    static double[,] ReadMatrix(int rows, int cols)
    {
        double[,] matrix = new double[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = double.Parse(Console.ReadLine()); 
            }
        }

        return matrix;
    }

    static double[,] AddMatrices(double[,] first, double[,] second)
    {
        int rows = first.GetLength(0);
        int cols = first.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                result[row, col] = first[row, col] + second[row, col]; 
            }
        }

        return result;
    }

    static double[,] SubtractMatrices(double[,] first, double[,] second)
    {
        int rows = first.GetLength(0);
        int cols = first.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                result[row, col] = first[row, col] - second[row, col];
            }
        }

        return result;
    }

    static double[,] MultiplyMatrices(double[,] first, double[,] second)
    {
        int rows = first.GetLength(0);
        int cols = second.GetLength(1);
        int common = first.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                double value = 0;
                for (int index = 0; index < common; index++)
                {
                    value += first[row, index] * second[index, col];
                }
                result[row, col] = value;
            }
        }

        return result;
    }

    static double[,] TransposeMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] transpose = new double[cols, rows];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                transpose[col, row] = matrix[row, col];
            }
        }

        return transpose;
    }

    static double Determinant2x2(double[,] matrix)
    {
        double a = matrix[0, 0];
        double b = matrix[0, 1];
        double c = matrix[1, 0];
        double d = matrix[1, 1];
        return a * d - b * c;
    }

    static double Determinant3x3(double[,] matrix)
    {
        double a = matrix[0, 0];
        double b = matrix[0, 1];
        double c = matrix[0, 2];
        double p = matrix[1, 0];
        double q = matrix[1, 1];
        double r = matrix[1, 2];
        double x = matrix[2, 0];
        double y = matrix[2, 1];
        double z = matrix[2, 2];

        double determinant = a * (q * z - r * y)
                           - b * (p * z - r * x)
                           + c * (p * y - q * x); 

        return determinant;
    }

    static double[,] Inverse2x2(double[,] matrix)
    {
        double determinant = Determinant2x2(matrix); 
        double[,] inverse = new double[2, 2];

        if (determinant == 0)
        {
            return inverse;
        }

        double a = matrix[0, 0];
        double b = matrix[0, 1];
        double c = matrix[1, 0];
        double d = matrix[1, 1];

        inverse[0, 0] = d / determinant;
        inverse[0, 1] = -b / determinant;
        inverse[1, 0] = -c / determinant;
        inverse[1, 1] = a / determinant;

        return inverse;
    }

    static double[,] Inverse3x3(double[,] matrix)
    {
        double determinant = Determinant3x3(matrix);
        double[,] inverse = new double[3, 3];

        if (determinant == 0)
        {
            return inverse;
        }

        double a = matrix[0, 0];
        double b = matrix[0, 1];
        double c = matrix[0, 2];
        double d = matrix[1, 0];
        double e = matrix[1, 1];
        double f = matrix[1, 2];
        double g = matrix[2, 0];
        double h = matrix[2, 1];
        double i = matrix[2, 2];

        double A = (e * i - f * h);
        double B = -(d * i - f * g);
        double C = (d * h - e * g);
        double D = -(b * i - c * h);
        double E = (a * i - c * g);
        double F = -(a * h - b * g);
        double G = (b * f - c * e);
        double H = -(a * f - c * d);
        double I = (a * e - b * d);

        double[,] adjoint = new double[3, 3];

        adjoint[0, 0] = A;
        adjoint[0, 1] = D;
        adjoint[0, 2] = G;
        adjoint[1, 0] = B;
        adjoint[1, 1] = E;
        adjoint[1, 2] = H;
        adjoint[2, 0] = C;
        adjoint[2, 1] = F;
        adjoint[2, 2] = I;

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                inverse[row, col] = adjoint[row, col] / determinant;
            }
        }

        return inverse;
    }

    static void DisplayMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row, col] + "\t");
            }
            Console.WriteLine();
        }
    }
}

