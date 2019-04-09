using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forward_Chaining_Algorithm
{
    class Program
    { //Kamyar_Rostami_AIProject_S.N:9311214023
        static void Main(string[] args)
        {
            Console.WriteLine("Kamyar_Rostami_AIProject_S.N:9311214023_Mr.sheikholharam" + "\r\n");
            Boolean b = false;
            
              //  Console.WriteLine("Menu" + "\r\n" + "press the number to choose" + "\r\n" + "1.Add Sentence(Horn Clause)" + "\r\n" + "2.Add literal(fact)" + "\r\n" + "3.Infer" + "\r\n");
               // int a = Convert.ToInt32(Console.ReadLine());
               
                    Console.WriteLine("enter the number of sentences you want to add:" + "\r\n" + " تعداد گزاره های دریافتی را وارد نمایید");
                    int ab = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter the number of premise literals of the sentences you want to add:" + "\r\n" + " تعداد فرض های دریافتی را وارد نمایید");
                    int ii = 0;
                    int ac = Convert.ToInt32(Console.ReadLine());
                   
                    
                    char[,] aa = new char[ab,ac + 1];
                    while (ii < ab)
                    {
                        Console.WriteLine("enter the" + ii + "sentence literas one by one then hit enter");

                        for (int j = 0; j < ac + 1; j++)
                        {
                            aa[ii,j] = Convert.ToChar(Console.ReadLine());

                        }
                        ii++;
                    }
                
                
                        Console.WriteLine("enter the number of facts you want to add:" + "\r\n" );
                        int ba= Convert.ToInt32(Console.ReadLine());
                   
                    string[] bb = new string[ba];
                        for (int n=0; n < ba;n++)
                        {
                            Console.WriteLine("enter the" + n + "fact");

                                bb[n] = Console.ReadLine();

                        
                           
                        }
            Forward_Chain s1 = new Forward_Chain(aa, ab, ac,bb);






        }
    }
}
