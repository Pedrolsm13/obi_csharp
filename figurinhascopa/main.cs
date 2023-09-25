using System;

class Program {
  public static void Main (string[] args) {
    int fig = 0, figCarimbada = 0, figComprada = 0;
    string [] Figurinhas = Console.ReadLine().Split(" ");
    fig = int.Parse(Figurinhas[0]);
    figCarimbada = int.Parse(Figurinhas[1]);
    figComprada = int.Parse(Figurinhas[2]);

    int [] carimbada = new int [figCarimbada];
    string [] carimb = Console.ReadLine().Split(" ");

    for (int i = 0; i < figCarimbada; i++){
      carimbada[i] = int.Parse(carimb[i]);
    }

    string [] figurinhasCompradas = Console.ReadLine().Split(" ");
    int [] compradas = new int [figComprada];
    
    int resp = figCarimbada;
    
    for (int i = 0; i < figComprada; i++){
      compradas [i] = int.Parse(figurinhasCompradas[i]);
      for (int j = 0; j < carimbada.Length; j++){
        if (compradas [i] == carimbada[j]){
          carimbada[j] = 0;
          resp--;
        }
      }
      /*foreach (int c in carimbada){
        if (c == compradas[i]){
          figCarimbada--;
        }
      }*/
    }
    Console.WriteLine(resp);
  }
}