using System;

class Program{
    public static void Main(string [] args){
        string [] bussola = new string[4];
        bussola [0] = "norte";
        bussola [1] = "oeste";
        bussola [2] = "sul";
        bussola [3] = "leste";

        string [] entrada = Console.ReadLine().Split(" ");

        int local = Array.IndexOf(bussola, entrada[0]);
        int direcao = Array.IndexOf(bussola, entrada[1]);
        int resp = 0;

        if (local < direcao){
            resp = (direcao - local)* 90;
        }
        else if (local > direcao){
            resp = (direcao - local)* 90;
        }
        else{
            resp = 0;
        }
        Console.WriteLine(resp);
    }
}