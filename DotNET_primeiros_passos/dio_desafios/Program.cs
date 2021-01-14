using System;
using System.Linq;
using System.Collections.Generic;

namespace dio_desafios
{
    class MinhaClasse 
    {
    public static void Main (string[] args)
        {
            int R = Int32.Parse(Console.ReadLine());
            int V = 0;
            int contaDigitos = 1;

            while (V <= R)
            {
                V = Int32.Parse(Console.ReadLine());
            }
            
            while(R <= V)
            {
                contaDigitos++;
                R = R + (R+1);
            }
            Console.WriteLine(contaDigitos);
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