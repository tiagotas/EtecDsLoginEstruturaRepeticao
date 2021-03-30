using System;

namespace EtecDsLoginEstruturaRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario_correto = "charlinho";
            string senha_correta = "batata";

            string usuario_digitado;
            string senha_digitada;

            int MAX_NUM_TENTATIVAS = 3;


            for(int i=1; i <= MAX_NUM_TENTATIVAS; i++)
            {
                Console.Clear();
                Console.WriteLine("LOGIN DO SISTEMA");
                Console.WriteLine("TENTATIVA {0} DE {1}", i, MAX_NUM_TENTATIVAS);

                Console.WriteLine("Digite seu usuário: ");
                usuario_digitado = Console.ReadLine();

                Console.WriteLine("Digite sua senha: ");
                senha_digitada = Console.ReadLine();


                if(usuario_digitado == usuario_correto && senha_correta == senha_digitada)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Parabéns! Deu certo! Bem vindo ao sistema.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;

                } else
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Dados incorretos :) ");
                    Console.BackgroundColor = ConsoleColor.Black;


                    // Se o usuário estiver na ultima tentativa, nem pergunta se quer sair.
                    if (i != MAX_NUM_TENTATIVAS)
                    {
                        Console.WriteLine("Sair do Sistema? S/n");

                        if (Console.ReadLine().ToUpper() == "S")
                            break;
                    }                    
                }








                /*if(usuario_digitado == usuario_correto)
                {
                    if(senha_digitada == senha_correta)
                    {
                        // deu certo, é o usuário.
                    } else
                    {
                        // deu errado, dados incorrentos (senha incorreta).
                    }
                } else
                {
                    // deu errado, dados incorrentos (usuário incorreto).
                }*/
            }


            Console.WriteLine("saiu do lopping for");
            


            Console.ReadKey();
        }
    }
}
