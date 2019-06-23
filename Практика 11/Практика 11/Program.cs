using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_11
{

    class Program
    {
        public static char Proverka(out char l)
        {
            bool ok = false;
            do
            {
                string buf = Console.ReadLine();
                    ok = char.TryParse(buf, out l);
                if (!ok) Console.WriteLine("Нужно вводить по одномому символу");
            } while (!ok);
            return l;
        }
       
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите текст из 121 сивола");
            string kod = Console.ReadLine();
            //   Console.WriteLine("Заполните матрицу");
               char[,] ar = new char[11, 11];
            int global = 0;
            //for (int i = 0; i < 11; i++)
            //{
            //    for (int j = 0; j < 11; j++)
            //    {

            //        ar[i, j] = kod[global];
            //        global++;
            //    }
            //}
            bool da = false;
            int sto = 116;
            int global2 = 0;
                for (int j = 6; j < 11; j++)
                {
                  
                ar[6, j] = kod[global];
                global++;
                global2++;
            }
                for (int j=0;j<6;j++)
            {
                ar[6, j] = kod[sto];
                sto++;
            }
            global2 = global2 + 11;
            for (int i=7;i<11;i=i+2)
            {
                for  (int j=10;j>=0;j--)
                {
                    ar[i, j] = kod[global];
                    global++;
                }
                global = global + 11;
            }
            for (int i=8;i<11;i=i+2)
            {
                for (int j = 0; j <11; j++)
                {
                    ar[i, j] = kod[global2];
                    global2++;
                }
                global2 = global2 + 11;
            }
            for (int i =0; i <= 5; i = i + 2)
                {
                    for (int j = 10; j >=0; j--)
                    {
                        ar[i, j] = kod[global];
                        global++;
                    }
                global = global + 11;
                }
            for (int i=1;i<=5;i=i+2)
            {
                for (int j=0;j<11;j++)
                {
                    ar[i, j] = kod[global2];
                    global2++;
                }
                global2 = global2 + 11;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            char[] final = new char[122]; 
             global2 = 0;
            sto = 116;
            global = 0;
            for (int j = 6; j < 11; j++)
            {

                final[global] = ar[6, j];
                global++;
                global2++;
            }
            for (int j = 0; j < 6; j++)
            {
                  final[sto]= ar[6, j];
                sto++;
            }
            global2 = global2 + 11;
            for (int i = 7; i < 11; i = i + 2)
            {
                for (int j = 10; j >= 0; j--)
                {
                    final[global]= ar[i, j];
                    global++;
                }
                global = global + 11;
            }
            for (int i = 8; i < 11; i = i + 2)
            {
                for (int j = 0; j < 11; j++)
                {
                   final[global2]= ar[i, j] ;
                    global2++;
                }
                global2 = global2 + 11;
            }
            for (int i = 0; i <= 5; i = i + 2)
            {
                for (int j = 10; j >= 0; j--)
                {
                   final[global]= ar[i, j];
                    global++;
                }
                global = global + 11;
            }
            for (int i = 1; i <= 5; i = i + 2)
            {
                for (int j = 0; j < 11; j++)
                {
                    final[global2] = ar[i, j];
                    global2++;
                }
                global2 = global2 + 11;
            }
            Console.WriteLine("Ваша матрица");
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.Write(ar[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(final);
            Console.Read();
            
        }
    }
}
