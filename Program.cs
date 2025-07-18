using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            oneD();
            twoD();
            jagged();
        }
        public static void oneD()
        {
            int [] a=new int[4];
            a[0] = 10;
            a[1] = 20;
            a[2] = 30;
            a[3] = 40;
            Console.WriteLine(a.Length);

            int[] b = new int[] { 10, 20, 30, 10 };
            Console.WriteLine(b.Length);
             
        }
        static void twoD()
        {
            int[,] a = new int[3, 4];
            a[0, 0] = 10;
            a[0, 1] = 20;
            a[0, 2] = 30;
            a[0, 3] = 40;
            a[1, 0] = 10;
            a[1, 1] = 20;
            a[1, 2] = 30;
            a[1, 3] = 40;
            a[2, 0] = 10;
            a[2, 1] = 20;
            a[2, 2] = 30;
            a[2, 3] = 40;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+"   ");
                }
                Console.WriteLine();
            }

        }
        static void jagged()
        {
            int[][] a = new int[3][];
            a[0] = new int[3];
            a[1] = new int[2];
            a[2] = new int[3];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.WriteLine("enter a["+i+"]["+j+"]");
                    a[i][j] = int.Parse(Console.ReadLine());
                    
                 
                }
                Console.WriteLine();
                
                
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j]+"   ");

                }
                Console.WriteLine();


            }
            
        }
       

    }
}
