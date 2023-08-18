using System;


public class Jogador{

      public int energia;
      public bool situacao;
      public string nome;
             public Jogador(string n){
        energia = 10;
        situacao = true;
        nome = n;

      }

   }

      class teste{
        static void Main (){

          Jogador j1=new Jogador("Messi");
          Jogador j2=new Jogador("Neymar");
          Jogador j3=new Jogador("Cristiano Ronaldo");

           Console.WriteLine("Nome do melhor jogador do mundo é {0}", j1.nome);

           Console.WriteLine("    ");

           Console.WriteLine("Nome do segundo melhor jogador do mundo é {0}", j3.nome);

           Console.WriteLine("    ");

            Console.WriteLine("Nome do terceiro melhor jogador do mundo é {0}", j2.nome);

            Console.ReadLine();
            Console.Clear();






        }


      }
    
    



    

