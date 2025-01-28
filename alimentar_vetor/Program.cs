// alimentar um vetor, somar e mostrar na tela
class Program
{
    static void Main ()
    {
        int[] vetor = new int[5];
        int soma = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = 0;
        }

        for (int i = 0; i <  vetor.Length; i++) 
        {
            Console.Write($"{vetor[i]}");
            soma = soma + vetor[i];
        }
        Console.WriteLine("");
        Console.WriteLine($"Soma é {soma}");
    }
}
