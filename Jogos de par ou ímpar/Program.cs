using System;

class Program{
    static void Main(string[] args){
        int R = int.Parse(Console.ReadLine());
        for (int i = 0; i < R;i++){
            string [] linha = Console.ReadLine().Split(' ');
            int P = int.Parse(linha[0]);
            int D_1 = int.Parse(linha[1]);
            int D_2 = int.Parse(linha[2]);
            int confere = (D_1 + D_2) % 2;

            if (confere == P){
                Console.WriteLine("0");
            }
            else if(confere != P){
                Console.WriteLine("1");
            }
        }
    }
}