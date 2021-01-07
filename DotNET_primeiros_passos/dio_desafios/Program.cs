using System;

namespace dio_desafios
{

    class MinhaClasse {
    public static void Main (string[] args) {
        int minutosRestantes = Int32.Parse(Console.ReadLine());
        string[] minutosFabricacao = Console.ReadLine().Split(" ");

        int presente1 = Int32.Parse(minutosFabricacao[0]);
        int presente2 = Int32.Parse(minutosFabricacao[1]);

        if ((presente1 + presente2) > minutosRestantes)
        {
            Console.WriteLine("Deixa para amanha!");
        }
        else
        {
            Console.WriteLine("Farei hoje!");
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