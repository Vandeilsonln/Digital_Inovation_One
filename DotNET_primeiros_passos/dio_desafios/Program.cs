using System;
using System.Globalization;

namespace dio_desafios
{
    class Desafio {
    static void Main() {
        int limit = Int32.Parse(Console.ReadLine());
        NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;
        for (int i = 0; i < limit; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if (Y == 0) {
                Console.WriteLine("divisao impossivel");
            } else {
                double divisao = X / Y; // Digite aqui o calculo da divisao
                Console.WriteLine(divisao.ToString("N1", nfi));
            }
        }
        }
    }
}
