using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Graph
{
    class Program
    {
        static int[,] a;
        static int n;
        public static void ReadGraph(string fileName)
        {
            // mở file

            StreamReader sr = new StreamReader(fileName);

            // đọc số đỉnh n

            n = int.Parse(sr.ReadLine());

            // tạo ma trận a

            a = new int[n + 1, n + 1];

            // đọc ma trận a

            for (int i = 1; i <= n; i++)
            {
                string[] Lines = sr.ReadLine().Split();
                for (int j = 1; j <= n; j++)
                {
                    a[i, j] = int.Parse(Lines[j - 1]);
                }
            }

            // đóng file 
            sr.Close();
        }
        public static void WriteGraph()
        {
            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.ReadLine();

            }
        }
        static void Main(string[] args)

        {
            ReadGraph("Graph.inp");
            WriteGraph();
            Console.ReadKey();
        }
    }
}
