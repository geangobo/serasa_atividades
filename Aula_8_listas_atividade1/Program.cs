using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8_listas_e_repeticao
{
    class Program
    {

        static void Main(string[] args)
        {
            //Atividade - 1: Cadastro de usuários
            while(true){
                
                //Variáveis
                string escolha;
                string usuarios;
                int x = 0;

                //Mensagens de boas vindas e instruções
                Console.WriteLine("Cadastro de usuários: \n1 - Cadastrar\n2 - Buscar\nDigite uma opção:");

                //Entrada de dados e lista
                List<string> nomes = new List<string>();

                escolha = Console.ReadLine();
                

                if (escolha == "1")
                {
                    Console.WriteLine("\nDigite o nome que deseja cadastrar: ");
                    usuarios = Console.ReadLine();
                    nomes.Add(usuarios);
                }else if (escolha == "2")
                {
                    Console.WriteLine("\nDigite a posição que deseja buscar: ");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("nome: "+ nomes[x]);

                }
                else
                {
                    Console.WriteLine("\nEscolha inválida. Re-incie o programa.");
                }






                Console.ReadLine();
            }
            





            
        }
    }
}
