using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelLikeProgram
{
    internal class Program
    {
        static int rows = 5; // Número de linhas na planilha
        static int cols = 5; // Número de colunas na planilha
        static string[,] spreadsheet = new string[rows, cols];

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                DisplaySpreadsheet();

                Console.WriteLine("1. Inserir valor");
                Console.WriteLine("2. Visualizar planilha");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InsertValue();
                        break;
                    case 2:
                        DisplaySpreadsheet();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 3:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void DisplaySpreadsheet()
        {
            Console.WriteLine("Planilha:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    string value = spreadsheet[i, j] ?? ""; // Trata valores nulos
                    Console.Write($"{value}\t");
                }
                Console.WriteLine();
            }
        }


        static void InsertValue()
        {
            Console.Write("Informe a linha: ");
            int row;
            if (!int.TryParse(Console.ReadLine(), out row) || row < 1 || row > rows)
            {
                Console.WriteLine("Linha inválida.");
                return;
            }
            row--; // Ajuste para índice da matriz

            Console.Write("Informe a coluna: ");
            int col;
            if (!int.TryParse(Console.ReadLine(), out col) || col < 1 || col > cols)
            {
                Console.WriteLine("Coluna inválida.");
                return;
            }
            col--; // Ajuste para índice da matriz

            Console.Write("Informe o valor: ");
            string value = Console.ReadLine();

            spreadsheet[row, col] = value;
            Console.WriteLine("Valor inserido com sucesso.");
        }

    }
}
