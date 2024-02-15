using System;

class Dijkstra
{
    public static void Main(string[] args)
    {
        Random rand = new Random();
        int m = rand.Next(5, 10);
        int[,] matrice = new int[m, m];


        for (int i = 0; i < m; i++)
        {
            for (int j = i + 1; j < m; j++)
            {
                matrice[i, j] = rand.Next(0, 10);
            }
        }


        for (int i = 0; i < m; i++)
        {
            for (int j = i + 1; j < m; j++)
            {
                matrice[j, i] = matrice[i, j];
            }
        }
        Console.WriteLine("Grafo generato :");
        Console.Write(" " + " ");



        for (int i = 0; i < m; i++)
        {
            Console.Write((char)('A' + i) + " ");

        }
        Console.WriteLine();

        for (int i = 0; i < m; i++)
        {
            Console.Write((char)('A' + i) + " ");
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrice[i, j] + " ");
            }
            Console.WriteLine();
        }



        int s = 0;
        do
        {
            Console.WriteLine("Inserire il nodo di partenza: ");
            s = int.Parse(Console.ReadLine());
        } while (s > m);

        int d = 0;
        do
        {
            Console.WriteLine("Inserire il nodo di destinazione: ");
            d = int.Parse(Console.ReadLine());
        } while (d > m - 1);



    }



}