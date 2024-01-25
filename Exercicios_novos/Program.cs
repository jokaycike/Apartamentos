using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_novos
{
    internal class Program
    {
        public struct Apartamento
        {
            public string numero;
            public string cor;
            public string tamanho;
            public string morador;
            public string quantidade;
        }
        static void Main(string[] args)
        {
            const int TAM = 10;
            Apartamento[] a = new Apartamento[TAM];
            int op;
            bool sair = false;
            while (sair == false)
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastrar Apartamento");
                Console.WriteLine("2 - Numero do Apartamento");
                Console.WriteLine("3 - Cor do Apartamento");
                Console.WriteLine("4 - Tamanho do Apartamento");
                Console.WriteLine("5 - Nome do morador");
                Console.WriteLine("6 - Quantidade de moradores");
                Console.WriteLine("7 - Exibir todos Aps cadastrados");
                Console.WriteLine("8 - Alterar Informações dos Aps");
                Console.WriteLine("9 - Excluir um dos dados");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nEscolha uma opção: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        CadastroApartamento(a);
                        break;
                    case 2:
                        NumeroApartamento(a); 
                        break;
                    case 3:
                        CorApartamento(a);
                        break;
                    case 4:
                        TamanhoApartamento(a);
                        break;
                    case 5:
                        NomeMorador(a);
                        break;
                    case 6:
                        QuantidadeMoradores(a); 
                        break;
                    case 7:
                        ExibirTodosApsCadastrados(a);
                        break;
                    case 8:
                        AlterarInfAps(a);
                        break;
                    case 9:
                        ExcluirApartamento(a);
                        break;
                    case 0:
                        Console.Write("\nPressione qualquer tecla para sair...");
                        Console.ReadKey();
                        sair = true;
                        break;
                }
            }
        }

        static void CadastroApartamento(Apartamento[] a)
        {
            const int TAM = 5;
            Console.Clear();
            Console.WriteLine("**** Cadastramento do Apartamento ****");
            for (int i = 0; i < TAM; i++)
            {
                Console.WriteLine("Qual é o número do apartamento?");
                a[i].numero = Console.ReadLine();
                Console.WriteLine("Qual é a cor do apartamento?");
                a[i].cor = Console.ReadLine();
                Console.WriteLine("Qual o tamanho do apartamento em m²?");
                a[i].tamanho = Console.ReadLine();
                Console.WriteLine("Qual o nome do morador do apartamento?");
                a[i].morador = Console.ReadLine();
                Console.WriteLine("Quantos moradores no apartamento?");
                a[i].quantidade = Console.ReadLine();
            }
            Console.Write("\nPressione enter para retornar ao menu principal");
            Console.ReadKey();
        }

        static void NumeroApartamento(Apartamento[] a)
        {
            string numero;
            const int TAM = 5;
            Console.Clear();
            Console.WriteLine("**** Consulta por número do apartamento ****\n");
            Console.Write("Informe o número do apartamento desejado:");
            numero = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("NÚMERO // COR // TAMANHO // MORADOR // QUANTIDADE\n");
            for (int i = 0; i < TAM; i++)
            {
                if (a[i].numero == numero)
                {
                    Console.WriteLine(a[i].numero + " " + a[i].cor + " " + a[i].tamanho + " " + a[i].morador + " " + a[i].quantidade);
                }
            }
            Console.Write("\nPressione enter para retornar ao menu principal");
            Console.ReadKey();
        }


        static void CorApartamento(Apartamento[] a)
        {
            string cor;
            const int TAM = 5;
            Console.Clear();
            Console.WriteLine("**** Consultar por cor do Apartamento ****\n");
            Console.Write("Informe a cor desejada:");
            cor = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("NÚMERO // COR // TAMANHO // MORADOR // QUANTIDADE\n");
            for (int i = 0; i < TAM; i++)
            {
                if (a[i].cor == cor)
                {
                    Console.WriteLine(a[i].numero + " " + a[i].cor + " " + a[i].tamanho + " " + a[i].morador + " " + a[i].quantidade);
                }
            }
            Console.Write("\nPressione enter para retornar ao menu principal");
            Console.ReadKey();
        }

        static void TamanhoApartamento(Apartamento[] a)
        {
            string tamanho;
            const int TAM = 5; 
            Console.Clear();
            Console.WriteLine("**** Consulte o tamanho em m² do Ap ****\n");
            Console.Write("Informe o tamanho desejado: ");
            tamanho = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("NÚMERO // COR // TAMANHO // MORADOR // QUANTIDADE\n");
            for (int i = 0; i < TAM; i++)
            {
                if (a[i].tamanho  == tamanho)
                {
                    Console.WriteLine(a[i].numero + " " + a[i].cor + " " + a[i].tamanho + " " + a[i].morador + " " + a[i].quantidade);
                }
            }
            Console.Write("\nPressione Enter para retornar ao menu principal");
            Console.ReadKey();
        }

        static void NomeMorador(Apartamento[] a)
        {   
            string morador;
            const int TAM = 5;
            Console.Clear();
            Console.WriteLine("**** Consulta por nome do morador ****\n");
            Console.Write("Informe o nome desejado:");
            morador = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("NÚMERO // COR // TAMANHO // MORADOR // QUANTIDADE\n");
            for (int i = 0;i < TAM; i++)
            {
                if (a[i].morador == morador)
                {
                    Console.WriteLine(a[i].numero + " " + a[i].cor + " " + a[i].tamanho + " " + a[i].morador + " " + a[i].quantidade);
                }
            }
            Console.Write("\nPressione Enter para retornar ao menu principal");
            Console.ReadKey();
        }

        static void QuantidadeMoradores(Apartamento[] a)
        {
            string quantidade;
            const int TAM = 5; 
            Console.Clear();
            Console.WriteLine("**** Consultar Aps pela quantidade de moradores que pode ter ****\n");
            Console.Write("Informe a quantidade desejada:");
            quantidade = Console.ReadLine();
            Console.WriteLine();
            for (int i = 0; i < TAM; i++)
            {
                if (a[i].quantidade == quantidade)
                {
                    Console.WriteLine(a[i].numero + " " + a[i].cor + " " + a[i].tamanho + " " + a[i].morador + " " + a[i].quantidade);
                }
            }
            Console.Write("\nPressione Enter para retornar ao menu principal");
            Console.ReadKey();
        }

        static void ExibirTodosApsCadastrados(Apartamento[] a)
        {
            const int TAM = 5;
            Console.Clear();
            Console.WriteLine("NÚMERO // COR // TAMANHO // MORADOR // QUANTIDADE\n");
            for (int i = 0;i < TAM; i++)
            {
                Console.WriteLine(a[i].numero + " " + a[i].cor + " " + a[i].tamanho + " " + a[i].morador + " " + a[i].quantidade + " ");
            }
            Console.Write("\nPressione Enter para retornar ao menu principal");
            Console.ReadKey();
        }

        static void AlterarInfAps(Apartamento[] a)
        {
            const int TAM = 5;
            string numero;
            int op;
            Console.Clear();
            Console.Write("Informe o número do Apartamento (formato 999):");
            numero = Console.ReadLine();
            for (int i = 0; i < TAM; i++)
            {
                if (a[i].numero == numero)
                {
                    Console.WriteLine(a[i].numero + " " + a[i].cor + " " + a[i].tamanho + " " + a[i].morador + " " + a[i].quantidade + " ");
                    Console.Write("Qual dado do Apartamento deseja alterar (1 - numero, 2 - cor, 3 - tamanho, 4 - morador, 5 - quantidade de moradores)? ");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.Write("Novo número? ");
                            a[i].numero = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Nova cor? ");
                            a[i].cor = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("Novo tamanho? ");
                            a[i].tamanho = Console.ReadLine();
                            break;
                        case 4:
                            Console.Write("Novo morador? ");
                            a[i].morador = Console.ReadLine();
                            break;
                        case 5:
                            Console.Write("Nova quantidade? ");
                            a[i].quantidade = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }
                    break;
                }
                else
                Console.WriteLine("Número não encontrado\n");
            }
            Console.Write("\nPressione enter para retornar ao menu principal");
            Console.ReadKey();
        }

        static void ExcluirApartamento(Apartamento[] a)
        {
            string numero;
            const int TAM = 5;
            Console.Clear();
            Console.WriteLine("***** Consulta por placa *****\n");
            Console.Write("Informe a placa desejada: ");
            numero = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("NÚMERO // COR // TAMANHO // MORADOR // QUANTIDADE\n");
            for (int i = 0; i < TAM; i++)
            {
                if (a[i].numero == numero)
                {
                    a[i].numero = "";
                    a[i].cor  = "";
                    a[i].tamanho = "";
                    a[i].morador    = "";
                    a[i].quantidade    = "";
                    Console.WriteLine("Apartamento excluído!");
                }
            }
            Console.Write("\nPressioneEnter para retornar ao menu principal");
            Console.ReadKey();
        }
    }
}
