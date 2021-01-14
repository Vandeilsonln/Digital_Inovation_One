using System;
using System.Linq;
using System.Collections.Generic;

namespace dio_desafios
{
    class MinhaClasse 
    {
    public static void Main (string[] args)
        {
            int qtdTartarugas = Int32.Parse(Console.ReadLine());
            int [] velocidadeTartarugas = Array.ConvertAll(Console.ReadLine().Split(" "), Int32.Parse);
            int maior = 0;
            for (int i = 0; i < qtdTartarugas; i++)
            {
                if (velocidadeTartarugas[i] > maior)
                {
                    maior = velocidadeTartarugas[i];
                }
            }
            
            if (maior < 10)
            {
                Console.WriteLine(1);
            }
            else if (maior < 20)
            {
                Console.WriteLine(2);
            }
            else 
            {
                Console.WriteLine(3);
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