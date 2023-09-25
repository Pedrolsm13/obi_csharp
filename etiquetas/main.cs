using System;

class Program

{
    public static void Main(string[] args)
    {
      // Entrada de dados
        int ArrLenth;
        int nEtiquetas;
        int TamEtiqueta;
 
        string[] entrada = Console.ReadLine().Split(' ');
        ArrLenth = int.Parse(entrada[0]);
        nEtiquetas = int.Parse(entrada[1]);
        TamEtiqueta = int.Parse(entrada[2]);
      
        string[] arrString = Console.ReadLine().Split(' ');
        int[] array = new int[ArrLenth];
      
        for (int i = 0; i < arrString.Length; i++)
          {
            array[i] = int.Parse(arrString[i]);
          }
      
        int[] etiqueta = new int[TamEtiqueta];
        //  testes
        for (int i = 0; i < nEtiquetas; i++)
          {
            for (int l = 0; l < array.Length - (TamEtiqueta - 1); l++)
            {

            }
          }
    }
}