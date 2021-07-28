using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondday9_7_21
{
    interface INormalCal
    {
        // Public and abstract
        int Add(int x, int y);

        int Sub(int x, int y);
    }
    interface ISciCal
    {
        int Add(int x, int y);
        int Mul(int x, int y);
    }

    class Calculator: INormalCal,ISciCal
    {
        int INormalCal.Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x,int y)
        {
            return x - y;
        }

        int ISciCal.Add(int x,int y)
        {
            return x + y;
        }
        public int Mul(int x,int y)
        {
            return x * y;
        }
    }
    class InterfaceEg
    {
        static void Main()
        {
            INormalCal ncal = new Calculator();
            Console.WriteLine("Addition of Normal Calculator:{0}", ncal.Add(5, 7));
            Console.WriteLine("Subtraction of Normal Calculator:{0}", ncal.Sub(98, 7));
            ISciCal scical = new Calculator();
            Console.WriteLine("Addition of Scientific Calculator:{0}", scical.Add(5, 7));
            Console.WriteLine("Subtraction of Scientific Calculator:{0}", scical.Mul(5, 10));


        }
    }
}
