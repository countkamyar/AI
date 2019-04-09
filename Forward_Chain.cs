using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forward_Chaining_Algorithm
{
    class Forward_Chain
    
    {
        public  Forward_Chain(char[,]se,int ab,int ac,string [] bb)
        {
            char[,] sentt = new char[ab, ac+1];
            char[] s2 = new char[bb.Length+ab];

            for (int i = 0; i < ab; i++)
            {
                for (int j = 0; j < ac+1; j++)
                {
                    sentt[i, j] = se[i, j];

                }

            }//ایجاد ماتریسی از گزاره های دریافتی
            for (int k = 0; k < bb.Length ; k++)
            {
                s2[k] = Convert.ToChar(bb[k]);

            }//ایجاد آرایه ای از حقایق دریافتی
            int id = 0;
            for (int m=0;m< ab; m++)
            {
                int cc=0;
                
                for(int n=0;n< ac; n++)
                {//دو شرط اول برای حرکت روی ماتریس و شرط سوم برای 
                 //مقایسه مقدار ماتریس با تک تک مقادیر آرایه حقایق است و در صورت برابر بودن یک واحد به شمارنده افزوده می گردد
                    bool b = false;
                    for (int o = 0; o <s2.Length; o++)
                    {
                        
                        if (s2[o] == sentt[m, n])
                        {
                            b = true;
                            cc++;

                        }
                    }
                  //  if (b == false)
                  //      break;
                }
                if (cc == ac)
                {
                    //درصورت برابر بودن مقدار شمارنده با تعداد شرط ها (صحیح بودن تمامی شروط) برنامه
                    //مشخص می کند که این قانون جدید از کدام جمله استنتاج شده است و به مجموعه قوانین برای استنتاج مراحل بعد اضافه می کند
                    s2[bb.Length + id] = sentt[m, ac];
                    Console.WriteLine(sentt[m,ac]+"literal has been concluded from"+m+"sentence"+"\t\n"+"نتیجه شده است"+m + "از جمله" + sentt[m, ac] );
                    id++;

                }
            }
            
        }
     

    }
}
