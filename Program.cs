/*public class Ex1
{
    public static void calcularMedia(double nota1, double nota2, double nota3, double nota4)
    {
        double media = (nota1 + nota2 + nota3 + nota4) / 4.0;
        Console.WriteLine($"média das notas {media}: ");
    }

    public static void Main(String[] args)
    {
        double nota1 = 5.0;
        double nota2 = 10.0;
        double nota3 = 7.5;           //Kaue Fernandes
        double nota4 = 8.0;
        calcularMedia(nota1, nota2, nota3, nota4);
    }
}*/
/*
class Program
{
    static void Contag(int x)
    {
        if (x <= 0)
        {
            Console.WriteLine("Fim da contagem.");
        }
        else
        {
            Console.WriteLine(x);
            Contag(x - 1);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor");
        int v = Convert.ToInt32(Console.ReadLine());
        int valorX = v;
        Console.WriteLine($"Contagem decrescente a partir de {valorX}:"); //Kaue Fernandes
        Contag(valorX);
    }
}*/

/*class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[30];
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 200);
        }
        foreach (int numero in array)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();

        int menorValor = array[0];
        int posicaoMenorValor = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < menorValor)
            {
                menorValor = array[i];
                posicaoMenorValor = i;                  //Kaue Fernnades
            }
        }
        int maiorValor = array[0];
        int posicaoMaiorValor = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maiorValor)
            {
                maiorValor = array[i];
                posicaoMaiorValor = i;
            }
        }
        int soma = 0;
        foreach (int numero in array)
        {
            soma += numero;
        }
        double valorMedio = (double)soma / array.Length;

        Console.WriteLine($"Menor valor: {menorValor} Posição:{posicaoMenorValor}");
        Console.WriteLine($"Maior valor: {maiorValor} Posição: {posicaoMaiorValor} ");
        Console.WriteLine($"Valor médio: {valorMedio}");
    }
}
*/

/*class Program
{
    static void Main(string[] args)
    {
        int[] primeiroArray = new int[10];
        double media = 0;

        for (int i = 0; i < primeiroArray.Length; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            primeiroArray[i] = int.Parse(Console.ReadLine());
            media += primeiroArray[i];
        }

        media /= primeiroArray.Length;

        double[] segundoArray = new double[10];
        for (int i = 0; i < segundoArray.Length; i++)
        {
            segundoArray[i] = primeiroArray[i] * media;
        }
        Console.WriteLine("Valores do primeiro array:");
        foreach (int numero in primeiroArray)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Valores do segundo array:"); //Kaue Fernandes
        foreach (double numero in segundoArray)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}/*

/*class Program
{
    static void Main(string[] args)
    {
        int[] vetorOriginal = new int[20];
        int[] vetorTrocado = new int[20];

        for (int i = 0; i < vetorOriginal.Length; i++)
        {
            Console.Write($"Digite o valor {i + 1} : ");
            vetorOriginal[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 10; i++)
        {
            vetorTrocado[i] = vetorOriginal[19 - i];
            vetorTrocado[19 - i] = vetorOriginal[i];
        }
        Console.WriteLine("Vetor Original:");
        foreach (int valor in vetorOriginal)
        {
            Console.Write(valor + " ");
        }                                                             //kaue fernandes
        Console.WriteLine();
        Console.WriteLine("Vetor Trocado:");
        foreach (int valor in vetorTrocado)
        {
            Console.Write(valor + " ");
        }
        Console.WriteLine();
    }
}
*/

/*class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantidade de números ");
        int n = int.Parse(Console.ReadLine());
        int[] numeros = new int[n];
        int Par = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] % 2 == 0)
            {
                Par++;
            }
        }
        Console.WriteLine("Números pares:"); //KAue fernandes
        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                Console.Write(numero + " ");
            }
        }
        Console.WriteLine($"Quantidade de números pares: {Par}");
    }
}
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o tamanho dos vetores: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetorA = new int[n];
        int[] vetorB = new int[n];
        int[] vetorC = new int[n];

        Console.WriteLine("Preencha o vetor A:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite o elemento " + (i + 1) + " de A: ");
            vetorA[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Preencha o vetor B:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite o elemento " + (i + 1) + " de B: ");
            vetorB[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            vetorC[i] = vetorA[i] + vetorB[i];
        }

        Console.WriteLine("Vetor C (soma de A e B):");
        for (int i = 0; i < n; i++)
        {
            Console.Write(vetorC[i] + " ");
        }
        Console.WriteLine();
    }
}
