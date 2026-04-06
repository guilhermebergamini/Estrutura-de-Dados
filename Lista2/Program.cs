using System;
using System.Diagnostics;

class Programa
{
    static void Main()
    {
        Console.Write("Digite o número do exercício (1-13): ");
        int numeroExercicio = int.Parse(Console.ReadLine());
        string nomeExercicio = ObterNomeDoExercicio(numeroExercicio);
        Console.WriteLine($"Exercício {numeroExercicio}: {nomeExercicio}");
        ExecutarExercicio(numeroExercicio);
    }

    static string ObterNomeDoExercicio(int numeroExercicio)
    {
        switch (numeroExercicio)
        {
            case 1: return "Imprimir vetor em ordem inversa";
            case 2: return "Encontrar o maior número e sua posição";
            case 3: return "Encontrar o menor número e sua posição";
            case 4: return "Encontrar os dois maiores números e suas posições";
            case 5: return "Encontrar maior e menor em um único laço";
            case 6: return "Classificar idades";
            case 7: return "Soma e multiplicação dos números pares";
            case 8: return "Multiplicar vetor por constante real";
            case 9: return "Somar salários";
            case 10: return "Média das temperaturas";
            case 11: return "Quadrado e cubo em novos vetores";
            case 12: return "Soma dos quadrados";
            case 13: return "Média da raiz quadrada";
            default: return "Exercício não encontrado";
        }
    }

    static void ExecutarExercicio(int numeroExercicio)
    {
        switch (numeroExercicio)
        {
            case 1: ImprimirVetorOrdemInversa(); break;
            case 2: EncontrarMaiorNumeroPosicao(); break;
            case 3: EncontrarMenorNumeroPosicao(); break;
            case 4: EncontrarDoisMaioresNumerosPosicoes(); break;
            case 5: EncontrarMaiorMenorUnicoLaco(); break;
            case 6: ClassificarIdades(); break;
            case 7: SomaMultiplicacaoNumerosPares(); break;
            case 8: MultiplicarVetorConstanteReal(); break;
            case 9: SomarSalarios(); break;
            case 10: MediaTemperaturas(); break;
            case 11: QuadradoCuboNovosVetores(); break;
            case 12: SomaQuadrados(); break;
            case 13: MediaRaizQuadrada(); break;
            default: Console.WriteLine("Exercício não implementado."); break;
        }
    }

    static void ImprimirVetorOrdemInversa()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine());
        int[] vetorNumeros = new int[tamanhoVetor];
        Console.WriteLine("Digite os números:");
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            vetorNumeros[contador] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Ordem inversa:");
        for (int contador = tamanhoVetor - 1; contador >= 0; contador--)
        {
            Console.Write(vetorNumeros[contador] + " ");
        }
        Console.WriteLine();
    }

    static void EncontrarMaiorNumeroPosicao()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine());
        int[] vetorNumeros = new int[tamanhoVetor];
        Console.WriteLine("Digite os números:");
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            vetorNumeros[contador] = int.Parse(Console.ReadLine());
        }
        int maiorNumero = vetorNumeros[0];
        int posicaoMaior = 0;
        for (int contador = 1; contador < tamanhoVetor; contador++)
        {
            if (vetorNumeros[contador] > maiorNumero)
            {
                maiorNumero = vetorNumeros[contador];
                posicaoMaior = contador;
            }
        }
        Console.WriteLine($"Maior: {maiorNumero}, Posição: {posicaoMaior}");
    }

    static void EncontrarMenorNumeroPosicao()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine());
        int[] vetorNumeros = new int[tamanhoVetor];
        Console.WriteLine("Digite os números:");
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            vetorNumeros[contador] = int.Parse(Console.ReadLine());
        }
        int menorNumero = vetorNumeros[0];
        int posicaoMenor = 0;
        for (int contador = 1; contador < tamanhoVetor; contador++)
        {
            if (vetorNumeros[contador] < menorNumero)
            {
                menorNumero = vetorNumeros[contador];
                posicaoMenor = contador;
            }
        }
        Console.WriteLine($"Menor: {menorNumero}, Posição: {posicaoMenor}");
    }

    static void EncontrarDoisMaioresNumerosPosicoes()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine());
        int[] vetorNumeros = new int[tamanhoVetor];
        Console.WriteLine("Digite os números:");
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            vetorNumeros[contador] = int.Parse(Console.ReadLine());
        }
        int maiorNumero1 = int.MinValue;
        int maiorNumero2 = int.MinValue;
        int posicaoMaior1 = -1;
        int posicaoMaior2 = -1;
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            if (vetorNumeros[contador] > maiorNumero1)
            {
                maiorNumero2 = maiorNumero1;
                posicaoMaior2 = posicaoMaior1;
                maiorNumero1 = vetorNumeros[contador];
                posicaoMaior1 = contador;
            }
            else if (vetorNumeros[contador] > maiorNumero2)
            {
                maiorNumero2 = vetorNumeros[contador];
                posicaoMaior2 = contador;
            }
        }
        Console.WriteLine($"Maior1: {maiorNumero1}, Posição: {posicaoMaior1}");
        Console.WriteLine($"Maior2: {maiorNumero2}, Posição: {posicaoMaior2}");
    }

    static void EncontrarMaiorMenorUnicoLaco()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine());
        int[] vetorNumeros = new int[tamanhoVetor];
        Console.WriteLine("Digite os números:");
        int maiorNumero = int.MinValue;
        int menorNumero = int.MaxValue;
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            vetorNumeros[contador] = int.Parse(Console.ReadLine());
            if (vetorNumeros[contador] > maiorNumero) maiorNumero = vetorNumeros[contador];
            if (vetorNumeros[contador] < menorNumero) menorNumero = vetorNumeros[contador];
        }
        Console.WriteLine($"Maior: {maiorNumero}, Menor: {menorNumero}");
    }

    static void ClassificarIdades()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine());
        int[] vetorIdades = new int[tamanhoVetor];
        Console.WriteLine("Digite as idades:");
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            vetorIdades[contador] = int.Parse(Console.ReadLine());
        }
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            string categoriaIdade;
            if (vetorIdades[contador] >= 1 && vetorIdades[contador] <= 9) categoriaIdade = "criança";
            else if (vetorIdades[contador] >= 10 && vetorIdades[contador] <= 12) categoriaIdade = "pré-adolescente";
            else if (vetorIdades[contador] >= 13 && vetorIdades[contador] <= 17) categoriaIdade = "adolescente";
            else if (vetorIdades[contador] >= 18 && vetorIdades[contador] <= 59) categoriaIdade = "adulto";
            else categoriaIdade = "idoso";
            Console.WriteLine($"Idade {vetorIdades[contador]}: {categoriaIdade}");
        }
    }

    static void SomaMultiplicacaoNumerosPares()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine());
        int[] vetorNumeros = new int[tamanhoVetor];
        Console.WriteLine("Digite os números:");
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            vetorNumeros[contador] = int.Parse(Console.ReadLine());
        }
        int somaPares = 0;
        long multiplicacaoPares = 1;
        int quantidadePares = 0;
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            if (vetorNumeros[contador] % 2 == 0)
            {
                somaPares += vetorNumeros[contador];
                multiplicacaoPares *= vetorNumeros[contador];
                quantidadePares++;
            }
        }
        Console.WriteLine($"Soma pares: {somaPares}, Multiplicação: {multiplicacaoPares}, Quantidade: {quantidadePares}");
    }

    static void MultiplicarVetorConstanteReal()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine());
        double[] vetorNumerosReais = new double[tamanhoVetor];
        Console.WriteLine("Digite os números reais:");
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            vetorNumerosReais[contador] = double.Parse(Console.ReadLine());
        }
        Console.Write("Digite a constante real: ");
        double constanteReal = double.Parse(Console.ReadLine());
        Console.WriteLine("Resultado:");
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            Console.Write((vetorNumerosReais[contador] * constanteReal) + " ");
        }
        Console.WriteLine();
    }

    static void SomarSalarios()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine());
        double[] vetorSalarios = new double[tamanhoVetor];
        Console.WriteLine("Digite os salários:");
        double somaSalarios = 0;
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            vetorSalarios[contador] = double.Parse(Console.ReadLine());
            somaSalarios += vetorSalarios[contador];
        }
        Console.WriteLine($"Soma dos salários: {somaSalarios}");
    }

    static void MediaTemperaturas()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine());
        double[] vetorTemperaturas = new double[tamanhoVetor];
        Console.WriteLine("Digite as temperaturas:");
        double somaTemperaturas = 0;
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            vetorTemperaturas[contador] = double.Parse(Console.ReadLine());
            somaTemperaturas += vetorTemperaturas[contador];
        }
        double mediaTemperaturas = somaTemperaturas / tamanhoVetor;
        Console.WriteLine($"Média: {mediaTemperaturas}");
    }

    static void QuadradoCuboNovosVetores()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine());
        int[] vetorNumeros = new int[tamanhoVetor];
        Console.WriteLine("Digite os números:");
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            vetorNumeros[contador] = int.Parse(Console.ReadLine());
        }
        int[] vetorQuadrados = new int[tamanhoVetor];
        int[] vetorCubos = new int[tamanhoVetor];
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            vetorQuadrados[contador] = vetorNumeros[contador] * vetorNumeros[contador];
            vetorCubos[contador] = vetorNumeros[contador] * vetorNumeros[contador] * vetorNumeros[contador];
        }
        Console.WriteLine("Quadrados:");
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            Console.Write(vetorQuadrados[contador] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Cubos:");
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            Console.Write(vetorCubos[contador] + " ");
        }
        Console.WriteLine();
    }

    static void SomaQuadrados()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine());
        int[] vetorNumeros = new int[tamanhoVetor];
        Console.WriteLine("Digite os números:");
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            vetorNumeros[contador] = int.Parse(Console.ReadLine());
        }
        int somaQuadrados = 0;
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            somaQuadrados += vetorNumeros[contador] * vetorNumeros[contador];
        }
        Console.WriteLine($"Soma dos quadrados: {somaQuadrados}");
    }

    static void MediaRaizQuadrada()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine());
        int[] vetorNumeros = new int[tamanhoVetor];
        Console.WriteLine("Digite os números:");
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            vetorNumeros[contador] = int.Parse(Console.ReadLine());
        }
        double somaRaizes = 0;
        for (int contador = 0; contador < tamanhoVetor; contador++)
        {
            somaRaizes += Math.Sqrt(vetorNumeros[contador]);
        }
        double mediaRaizQuadrada = somaRaizes / tamanhoVetor;
        Console.WriteLine($"MRQ: {mediaRaizQuadrada}");
    }
}
