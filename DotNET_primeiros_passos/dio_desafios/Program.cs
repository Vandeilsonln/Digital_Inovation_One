using System;
using System.Text.RegularExpressions;

namespace dio_desafios
{
    class MinhaClasse {
    public static void Main (string[] args) {
        Regex padraoPlaca = new Regex (@"[A-Z]{3}\-\d{4}", RegexOptions.Compiled);

        int quantidadeTeste = Int32.Parse(Console.ReadLine());
        string[] placas = new string[quantidadeTeste];

        for (int i = 0; i < placas.Length; i++)
        {
            placas[i] = Console.ReadLine();
        }

        foreach (string placa in placas)
        {
            MatchCollection matches = padraoPlaca.Matches(placa);

            if (matches.Count == 0)
            {
                Console.WriteLine("FALHA");
            }
            else
            {
                Console.WriteLine("DIA DA SEMANA");
            }
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