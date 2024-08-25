
using System.Runtime.Intrinsics.X86;

namespace ProgAvanSistema_TratamentoErro_Aula04_Exercicios
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa que receba n números e some esses números enquanto a soma não for superior a 100. O programa deverá 
            imprimir o valor somado (antes de atingir o número maior que 100) e deverá informar quantos números foram somados e qual a média.*/

            /*  a) Utilize os tratamentos de exceção para lidar com a entrada de dados.
                b) Quando a soma for superior a 100, o programa deverá gerar uma exceção
                   criada pelo programador, com nome ExcecaoAcimaDeCem.
                c) Lance essa exceção, com o uso de throws.*/

            double soma = 0;
            int contador = 0;

            while (true)
            {
                try
                {
                    Console.Write("Entre com o número: ");
                    double input = double.Parse(Console.ReadLine()!);
                    soma += input;

                    contador++;

                    if (soma > 100)
                    {
                        contador--;
                        soma -= input;
                        throw new ExcecaoAcimaDeCem();
                    }

                    Console.WriteLine($"Soma: {soma}");
                }
                catch (ExcecaoAcimaDeCem )
                {                    
                    break;
                }
            }

            double media = soma / contador;
            Console.WriteLine($"\nSoma total antes de exeder 100: {soma}");
            Console.WriteLine($"Quantidade de números somados: {contador}");
            Console.WriteLine($"Média dos números: {media:F2}");


        }
    }

}