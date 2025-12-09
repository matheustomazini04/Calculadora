namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region switch case
            //int escolha = 1;    
            //switch (escolha)
            //{
            //    default:
            //        Console.WriteLine("Opção padrão selecionada.");
            //        break;  
            //    case 1:
            //        Console.WriteLine("Opção 1 selecionada.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Opção 2 selecionada.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Opção inválida.");
            //        break;
            //}

            #endregion

            Console.Write("Digite o primeiro numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo numero: "); 
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação: ( + - / x)");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {
                default:
                    Console.WriteLine("Operação inválida.");
                    return;
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine($"O resultado da soma é: {resultado}");
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine($"O resultado da subtração é: {resultado}");
                    break;
                case '/':
                case ':':
                    
                    if (num2 == 0)
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        return;
                    }   
                    resultado = num1 / num2;
                    Console.WriteLine($"O resultado da divisão é: {resultado}");
                    break;
                case 'x':
                case 'X':
                case '*':
                    resultado = num1 * num2;
                    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
                    break;
            }   
        }
    }
}
