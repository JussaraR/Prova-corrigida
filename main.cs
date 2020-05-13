using System;

class MainClass {
  public static void Main (string[] args) {
      // letra a
      string[,]  cidadao = new string [20,2];
      for(int i= 0; i<20)
      {

        Console.WriteLine("Digite seu nome:");
        cidadao[i,0] = Console.ReadLine();
        Console.WriteLine("Digite sua idade");
        cidadao= [i,1] = Console.ReadLine();
      }
      // letra b
    string[] nome = new string[20];
    int[] idade  = new int[20];

    for (int i=0; i<20; i++)
    {
      nome[i]= cidadao[i,0];
      idade[i]= Convert.ToInt32(cidadao[i,1]);
    }
    //letra c
    Console.WriteLine("NOME     IDADE");
    for (int i=0; i<20; i++)
    {
      Console.WriteLine(cidadao[i,0] + "   "+ cidadao[i,1]);
    }

    // letra d
    string busca;
    Console.WriteLine("Digite o nome de quem você quer saber idade!");
    busca = Console.ReadLIne();

    for( int i=0; i<20; i++)
    {

      if(busca== cidadao[i,0])
      {
        Console.WriteLine(cidadao[i,1]);
        i=20;//apenas para saida apos encontrar
      }

    }

    //letra e
    int idVelho=0, idNovo= 0, iVelho=0, iNovo=0;
    idNovo= idade[0];
    IdVelho= idade[0];

    for(int i=1; i<20; i++)
    {
      if (idade[i]> idVelho)
      {
        IdVelho= idade[i];
        iVelho=i;

      }else if (idade[i]<idNovo)
      {
        idNovo= idade[i];
        iNovo = i;
      }
      Console.WriteLine("O mais velho é: "+cidadao[iVelho,0]+ "  "+cidadao[iVelho,1]);
      Console.WriteLine("O mais novo é: "+cidadao[iNovo,0]+ "  "+cidadao[iNovo,1]);

    }

    //letra f
    int media=0;
    for(int i=0; i<20, i++) 
    {
      media= media+idade[i];
      
    }
    Console.WriteLine
  }
} 