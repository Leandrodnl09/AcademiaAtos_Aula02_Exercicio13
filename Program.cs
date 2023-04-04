using System.Drawing;

namespace Aula02Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
            // preço de custo de cada bicicleta vendida.Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas
            // vendidas pelo vendedor, calcule e mostre: o salário do empregado

            // Solicita ao usuário o valor do salário mínimo
            Console.Write("Digite o valor do salário mínimo: ");
            double salarioMinimo = double.Parse(Console.ReadLine());

            // Solicita ao usuário o preço de custo de cada bicicleta
            Console.Write("Digite o preço de custo de cada bicicleta: ");
            double precoCusto = double.Parse(Console.ReadLine());

            // Solicita ao usuário o número de bicicletas vendidas pelo vendedor
            Console.Write("Digite o número de bicicletas vendidas pelo vendedor: ");
            int numeroBicicletas = int.Parse(Console.ReadLine());

            // Calcula o valor do acréscimo de 50% sobre o preço de custo
            double acrescimo = precoCusto * 0.5;

            // Calcula o valor do salário do vendedor (2 salários mínimos + comissão)
            double salarioVendedor = (2 * salarioMinimo) + (numeroBicicletas * (precoCusto + acrescimo) * 0.15);

            // Exibe o salário do vendedor
            Console.WriteLine("O salário do vendedor é: R$" + salarioVendedor.ToString("F2"));
        }
    }
}