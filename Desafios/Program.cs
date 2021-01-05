using System;

class Desafio {
    static void Main() {
        let chico = 300 * Int32.Parse(Console.ReadLine());
        let bento = 1500 * Int32.Parse(Console.ReadLine());
        let bernardo = 600 * Int32.Parse(Console.ReadLine());
        let marina = 1000 * Int32.Parse(Console.ReadLine());
        let iara = 150 * Int32.Parse(Console.ReadLine());
        let marlene = 225;
        let total = let chico + let bento + let bernardo + let marina + let iara + let marlene; // Digite aqui o calculo total
        Console.WriteLine(total);
    }
}