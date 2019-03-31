using System;
using System.Collections.Generic;
using System.Text;

namespace practise1.practise.Exception
{
    class Finally04
    {
        static int Divide(int divisor, int dividend)
        {
            try
            {
                Console.WriteLine("Divide() start");
                return divisor / dividend;
            }catch(DivideByZeroException e)
            {
                Console.WriteLine("Divide() occur exception");
                throw e;
            }
            finally
            {
                Console.WriteLine("Divide() end");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("제수 입력 : ");
                String temp = Console.ReadLine();
                int divisor = Convert.ToInt32(temp);

                Console.WriteLine("피제수 입력 : ");
                temp = Console.ReadLine();
                int dividend = Convert.ToInt32(temp); //Translate

                Console.WriteLine("{0}/{1} = {2}", divisor, dividend, Divide(divisor, dividend));
            }catch(FormatException e)
            {
                Console.WriteLine("error : " + e.Message);
            }catch(DivideByZeroException e)
            {
                Console.WriteLine("error : " + e.Message);
            }
            finally
            {
                Console.WriteLine("program exit");
            }
        }
    }
}
