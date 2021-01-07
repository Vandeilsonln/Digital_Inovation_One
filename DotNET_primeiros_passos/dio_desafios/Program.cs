using System;

namespace dio_desafios
{
    class Desafio {
    static void Main() {
        string[] line = Console.ReadLine().Split(" ");
        int a = Int32.Parse(line[0]);
        int n = Int32.Parse(line[1]);
        

        for(double progresso = 1; progresso <= 9; progresso++)
        {
            double parcialPlacas = Math.Ceiling(Convert.ToDouble(a * n * (progresso / 10)));
            Console.Write(parcialPlacas + " ");
        }
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