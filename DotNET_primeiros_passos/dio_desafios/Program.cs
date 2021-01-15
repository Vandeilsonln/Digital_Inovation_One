using System;
using System.Linq;
using System.Collections.Generic;

namespace dio_desafios
{
    class MinhaClasse 
    {
    public static void Main (string[] args)
        {
            string joia = Console.ReadLine();
            List<string> joias = new List<string> {};
            while (joia != null)
            {
                joias.Add(joia);
                joia = Console.ReadLine();
            }
            var quantidadeJoias = joias.Distinct().Count();
            Console.WriteLine(quantidadeJoias);
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