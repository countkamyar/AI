using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{//Kamyar Rostami AI exercise(HillclimbingAlgorithm) Mr. sheikolharam SN. 9311214023
    class HillclimbingAlgorithm
    {//in class tanha baraye peyda kardane global minimum tabe y=x^2 [yani 0] az tarighe algorithm "HillClimbing" tarahi shode ast

        public void climb ()
        {
            Double Cpy,Cpx;
            Random r = new Random();
            Cpx = r.Next();
            Cpy = Cpx * Cpx;
            //entekhabe noghte aval be soorate random

           for(int i = 0; i < 1000; i++)
            { 
            Double rand = r.NextDouble();
            rand = rand * 10000000;
                //entekhabe yek adade random beonvane delta
            Double pp = Cpx + rand;
            Double np = Cpx - rand;
                //ezafe va kam kardan adad be x feli
            Double y1 = np * np;
            Double y2 = pp * pp;
                //mohasebe y har do noghte
            if (y1 < Cpy)
            {
                Cpy = y1;
                    Cpx = np;
            }
            if (y2 < Cpy)
            {
                Cpy = y2;
                    Cpx = pp;
            }//moghayese y har do noghte va entekhab minimum tarin
            Console.WriteLine("Current y is:  "+Cpy + "\n\t");
                Console.WriteLine("Kamyar Rostami AI exercise (HillclimbingAlgorithm) Mr.sheikolharam SN. 9311214023" + "\n\t");
                //namayeshe noghte entekhab shode va bazgashte mojadad be marahele ghabl ba noghte jadid be onvan current position
                if(i==999)
                    Console.WriteLine("lastlocation"+Cpy + "\n\t");
            }
        }
    }
}
