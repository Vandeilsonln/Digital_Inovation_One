using System;
using System.Linq;

namespace dio_desafios
{
    class MinhaClasse {
    public static void Main (string[] args) {
        string[] inputData = Console.ReadLine().Split(" ");
        string[] dateAndPerson = Console.ReadLine().Split(" ");

        int people = Int32.Parse(inputData[0]);
        int possibleDates = Int32.Parse(inputData[1]);

        string[] info = new string[possibleDates];

        for (int i = 0; i < possibleDates; i++)
        {
            
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