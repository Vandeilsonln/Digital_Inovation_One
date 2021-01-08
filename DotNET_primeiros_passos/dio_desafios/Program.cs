using System;
using System.Linq;
using System.Collections.Generic;

namespace dio_desafios
{
    class MinhaClasse {
    public static void Main (string[] args) {
        string[] inputData = Console.ReadLine().Split(" ");

        int people = Int32.Parse(inputData[0]);
        int possibleDates = Int32.Parse(inputData[1]);

        List<List<string>> dateAndAvailability = new List<List<string>>();

        for (int i = 0; i < possibleDates; i++)
        {
            var row = Console.ReadLine().Split(" ");
            var date = row[0];
            foreach (var person in row.Skip(1))
            {  
                if (person == "0")
                {
                    Console.WriteLine("This person can not go on ths date.");
                    break;
                }
                Console.WriteLine(date);
                break;
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