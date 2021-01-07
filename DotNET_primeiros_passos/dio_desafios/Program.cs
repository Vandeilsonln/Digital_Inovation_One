using System;

namespace dio_desafios
{
    class Desafio {
        static int semServico = 0;
    static void Main() {
        string[] available = Console.ReadLine().Split(" ");
        int Pa = Int32.Parse(available[0]);
        int Sa = Int32.Parse(available[1]);
        int Ma = Int32.Parse(available[2]);
        
        string[] requested = Console.ReadLine().Split(" ");
        int Pb = Int32.Parse(requested[0]);
        int Sb = Int32.Parse(requested[1]);
        int Mb = Int32.Parse(requested[2]);

        
        for (int i = 0; i < available.Length; i++)
        {
            if (Int32.Parse(requested[i]) > Int32.Parse(available[i]))
            {
                Desafio.semServico += Int32.Parse(requested[i]) - Int32.Parse(available[i]);
            }
        }
        Console.WriteLine(Desafio.semServico);        
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