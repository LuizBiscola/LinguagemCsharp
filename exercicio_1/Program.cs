class Program
{
    static void Main()
    {
        float resultado, numero, numero1;
        char operacao, opcao;
        
        resultado = 0;
        do
        {
            Console.WriteLine("Digite o primeiro numero: ");
            numero = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a aoperção (+, -, /, *)");
            operacao = char.Parse(Console.ReadLine());

            switch (operacao)
            {
                case '+':
                    resultado = numero + numero1;
                    break;
                case '-':
                    resultado = numero - numero1;
                    break;
                case '*': 
                    resultado = numero * numero1;
                    break;
                case '/':
                    resultado = numero / numero1;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"O resultado é {resultado}");
                
            Console.WriteLine("Deseja realizar uma nova operação?(S/N)");
            opcao = char.Parse(Console.ReadLine());   

        } while (opcao == 'S' || opcao == 's');
    }
}