using System;

class Program

{
  public static void Main(string[] args){
    // Entrada de dados
    int ArrLenth;
    int nEtiquetas;
    int TamEtiqueta;
    // tamanho da fita, qtd etiquetas e tamanho etiqueta
    string[] entrada = Console.ReadLine().Split(' ');
    ArrLenth = int.Parse(entrada[0]);
    nEtiquetas = int.Parse(entrada[1]);
    TamEtiqueta = int.Parse(entrada[2]);
  
    string[] arrString = Console.ReadLine().Split(' ');
    int[] array = new int[ArrLenth];
    //preenche o vetor array conforme entrada de dados, valores da fita
    for (int i = 0; i < ArrLenth; i++){
      array[i] = int.Parse(arrString[i]);
    }

    int menor = 10001, indice = -1;

    for (int j = 0; j < nEtiquetas; j++){  
      for (int i = 0; i < array.Length - (TamEtiqueta - 1); i++){
        if (somatorio(array, TamEtiqueta, i) < menor){
          menor = somatorio(array, TamEtiqueta, i);
          indice = i;
        }
      }
      for (int k = 0; k < TamEtiqueta; k++){
        array[indice++] = 10001;
      }
      menor = 10001;
    }     
    int res=0;
    for(int i = 0; i < ArrLenth; i++){
      if (array[i] == 10001){
        array[i] = 0;
      }
      res += array[i];
    }
    Console.WriteLine(res);
  }
  static int somatorio(int[] array, int TamEtiqueta, int i){
    int soma = 0;
    for(int j = i; j < TamEtiqueta+i; j++){
      soma += array[j];
    }
    return soma;
  }
}
//impossivel com essa configuação, aceita em apenas um modelo de entrada
/*using System;

class Program

{
  public static void Main(string[] args){
    // Entrada de dados
    int ArrLenth;
    int nEtiquetas;
    int TamEtiqueta;
    // tamanho da fita, qtd etiquetas e tamanho etiqueta
    string[] entrada = Console.ReadLine().Split(' ');
    ArrLenth = int.Parse(entrada[0]);
    nEtiquetas = int.Parse(entrada[1]);
    TamEtiqueta = int.Parse(entrada[2]);
  
    string[] arrString = Console.ReadLine().Split(' ');
    int[] array = new int[ArrLenth];
    //preenche o vetor array conforme entrada de dados, valores da fita
    for (int i = 0; i < ArrLenth; i++){
      array[i] = int.Parse(arrString[i]);
    }
    //cria vetor para guardar somatorio de posições
    int[] etiqueta = new int[ArrLenth-(TamEtiqueta-1)];
      
    for (int l = 0; l < ArrLenth - (TamEtiqueta - 1); l++){
      for (int i = 0; i < TamEtiqueta; i++){
        etiqueta[l] += array[l+i];
      }
    }// guarda somatorio

    int menor = etiqueta[0], indice = -1, indiceneg = 0;

    for (int j = 0; j < nEtiquetas; j++){
      
      for (int i = 0; i < etiqueta.Length; i++){
        if (etiqueta[i] < menor){
          menor = etiqueta[i];
          indice = i;
          indiceneg = i;
        }
      }
      for (int k = 0; k < TamEtiqueta; k++){
        array[indice] = 0;
        etiqueta[indice++] = 10001;
        etiqueta[indiceneg--] = 10001;
      }
      menor = etiqueta[0];
    }
    int res=0;
    for(int i = 0; i < ArrLenth; i++){
      res += array[i];
    }
    Console.WriteLine(res);
  }
}*/