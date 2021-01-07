using System;

namespace dio_desafios
{

    class MinhaClasse {
    public static void Main (string[] args) {
        int tempoSegundos = Int32.Parse(Console.ReadLine());
        int horas = tempoSegundos / 3600;
        int minutos = (tempoSegundos % 3600) / 60;
        int segundos =  (tempoSegundos - (horas * 3600)) % 60;

        Console.WriteLine($"{horas}:{minutos}:{segundos}");
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