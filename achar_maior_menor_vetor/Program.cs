//achar o menor e maior dentro do vetor

class Program
{
    static void Main()
    {
        int[] vetor = new int[5];
        int menor, maior;

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Digite o valor do vetor na posição {i+1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        menor = vetor[0];
        maior = vetor[0];

        for (int i = 0; i < vetor.Length; i++)
        {
            if(vetor[i]>maior)
            {
                maior = vetor[i];
            }
            else if(vetor[i]<menor)
            {
                menor = vetor[i];
            }
        }
        Console.WriteLine($"O valor maior é {maior} e o menor é {menor}");
    }
}