using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace dio_desafios
{
    class MinhaClasse 
    {
    public static void Main (string[] args)
        {
            NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;

            double nota1 = 0;
            double nota2 = 0;
            while (true)
            {
                nota1 = Double.Parse(Console.ReadLine(), new NumberFormatInfo() { NumberDecimalSeparator = "." });
                if (nota1 < 0 | nota1 > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else 
                {
                    break;
                }
            }

            while (true)
            {
                nota2 = Double.Parse(Console.ReadLine(), new NumberFormatInfo() { NumberDecimalSeparator = "." });
                if (nota2 < 0 | nota2 > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else 
                {
                    break;
                }
            }

            double media = (nota1 + nota2) / 2;

            Console.WriteLine("media = " + media.ToString("N2", nfi));
        }
    }
}

    

    
// for (int i = 0; i < limit; i++) 
//         {
//             string[] line = Console.ReadLine().Split(" ");
//             double X = double.Parse(line[0]);
//             double Y = double.Parse(line[1]);
//             if (Y == 0) {
//                 Console.WriteLine("divisao impossivel");
//             } else {
//                 double divisao = X / Y; // Digite aqui o calculo da divisao
//                 Console.WriteLine(divisao.ToString("N1", nfi));
//             }
//         }