using System;
using System.Linq;
using System.Collections.Generic;

namespace dio_desafios
{
    class MinhaClasse 
    {
    public static void Main (string[] args)
        {
            string [] line = Console.ReadLine().Split(" ");
            int N = int.Parse(line[0]);
            int D = int.Parse(line[1]);

            string data = "";
            int quantidade = 0;

            bool achouData = false;

            for (int dt = 0; dt < D; dt++)
            {
                quantidade = 0;
                string [] dados = Console.ReadLine().Split(" ");

                data = dados[0];

                for (int p = 1; p < dados.Length; p++)
                {
                    quantidade += int.Parse(dados[p]);
                }
                achouData = (quantidade == N);
                if (achouData)
                {
                    break;
                }

            }
            if (achouData) {Console.WriteLine(data);}
            else {Console.WriteLine("Pizza antes de FdA");}
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