using System;

namespace Codigos
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Exercícios Estrutura de Dados ===");
                Console.WriteLine("1) Imprimir ímpares entre 0 e 200");
                Console.WriteLine("2) Soma de ímpares até N");
                Console.WriteLine("3) Potência (A^B) com repetição");
                Console.WriteLine("4) Produto usando soma");
                Console.WriteLine("5) Fatorial");
                Console.WriteLine("6) Verificar primo");
                Console.WriteLine("7) Primos entre A e B");
                Console.WriteLine("8) Fibonacci (n-ésimo termo)");
                Console.WriteLine("9) Número reverso");
                Console.WriteLine("10) Verificar palíndromo");
                Console.WriteLine("11) Classificação por código de produto");
                Console.WriteLine("12) Consumo médio de combustível");
                Console.WriteLine("13) Conceito do aluno");
                Console.WriteLine("14) Imposto sobre produto");
                Console.WriteLine("15) IMC");
                Console.WriteLine("16) Conversão de dólar para real");
                Console.WriteLine("17) Hipotenusa (triângulo retângulo)");
                Console.WriteLine("18) Desconto de 27% (produto)");
                Console.WriteLine("19) Divisão de prêmio entre 3 ganhadores");
                Console.WriteLine("20) Média da raiz quadrada (MRQ)");
                Console.WriteLine("0) Sair");
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                    Exercicio1();
                else if (opcao == 2)
                    Exercicio2();
                else if (opcao == 3)
                    Exercicio3();
                else if (opcao == 4)
                    Exercicio3_1();
                else if (opcao == 5)
                    Exercicio4();
                else if (opcao == 6)
                    Exercicio5();
                else if (opcao == 7)
                    Exercicio6();
                else if (opcao == 8)
                    Exercicio7();
                else if (opcao == 9)
                    Exercicio8();
                else if (opcao == 10)
                    Exercicio9();
                else if (opcao == 11)
                    Exercicio10();
                else if (opcao == 12)
                    Exercicio11();
                else if (opcao == 13)
                    Exercicio12();
                else if (opcao == 14)
                    Exercicio13();
                else if (opcao == 15)
                    Exercicio14();
                else if (opcao == 16)
                    Exercicio15();
                else if (opcao == 17)
                    Exercicio16();
                else if (opcao == 18)
                    Exercicio17();
                else if (opcao == 19)
                    Exercicio18();
                else if (opcao == 20)
                    Exercicio19();
                else if (opcao == 0)
                    return;
            }
        }

        static void Exercicio1()
        {
            Console.Clear();
            Console.WriteLine("1) Números ímpares entre 0 e 200\n");
            for (int i = 1; i <= 200; i += 2)
            {
                Console.WriteLine(i);
            }
            Pause();
        }

        static void Exercicio2()
        {
            Console.Clear();
            Console.WriteLine("2) Soma dos ímpares até N\n");
            Console.Write("Digite um número inteiro positivo (N): ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= n; i += 2)
            {
                soma += i;
            }

            Console.WriteLine("Soma dos ímpares de 0 até " + n + ": " + soma);
            Pause();
        }

        static void Exercicio3()
        {
            Console.Clear();
            Console.WriteLine("3) Potência (A^B) usando laço\n");
            Console.Write("Digite a (base, inteiro positivo): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite b (expoente, inteiro não-negativo): ");
            int b = int.Parse(Console.ReadLine());

            long resultado = 1;
            for (int i = 0; i < b; i++)
            {
                resultado *= a;
            }

            Console.WriteLine(a + " elevado a " + b + " = " + resultado);
            Pause();
        }

        static void Exercicio3_1()
        {
            Console.Clear();
            Console.WriteLine("3.1) Produto entre A e B usando apenas soma\n");
            Console.Write("Digite A (inteiro não-negativo): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite B (inteiro não-negativo): ");
            int b = int.Parse(Console.ReadLine());

            int produto = 0;
            for (int i = 0; i < b; i++)
            {
                produto += a;
            }

            Console.WriteLine(a + " x " + b + " (somando A, B vezes) = " + produto);
            Pause();
        }

        static void Exercicio4()
        {
            Console.Clear();
            Console.WriteLine("4) Fatorial\n");
            Console.Write("Digite um número inteiro não-negativo: ");
            int n = int.Parse(Console.ReadLine());

            long fatorial = 1;
            for (int i = 2; i <= n; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine(n + "! = " + fatorial);
            Pause();
        }

        static void Exercicio5()
        {
            Console.Clear();
            Console.WriteLine("5) Verificar número primo");
            Console.Write("Digite um número inteiro positivo: ");
            int n = int.Parse(Console.ReadLine());

            bool primo = true;
            if (n == 1)
                primo = false;
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }
            }

            if (primo)
                Console.WriteLine(n + " é primo.");
            else
                Console.WriteLine(n + " não é primo.");

            Pause();
        }

        static void Exercicio6()
        {
            Console.Clear();
            Console.WriteLine("6) Primos entre A e B");
            Console.Write("Digite A (inteiro positivo): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite B (inteiro positivo): ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine("Primos entre " + a + " e " + b + ":");
            for (int n = a; n <= b; n++)
            {
                bool primo = true;
                if (n == 1)
                    primo = false;
                else
                {
                    for (int i = 2; i <= n / 2; i++)
                    {
                        if (n % i == 0)
                        {
                            primo = false;
                            break;
                        }
                    }
                }

                if (primo)
                    Console.WriteLine(n);
            }

            Pause();
        }

        static void Exercicio7()
        {
            Console.Clear();
            Console.WriteLine("7) Fibonacci (n-ésimo termo)\n");
            Console.Write("Digite n (inteiro positivo): ");
            int n = int.Parse(Console.ReadLine());

            long f1 = 1, f2 = 1;
            if (n == 1 || n == 2)
            {
                Console.WriteLine("F" + n + " = 1");
                Pause();
                return;
            }

            for (int i = 3; i <= n; i++)
            {
                long next = f1 + f2;
                f1 = f2;
                f2 = next;
            }

            Console.WriteLine("F" + n + " = " + f2);
            Pause();
        }

        static void Exercicio8()
        {
            Console.Clear();
            Console.WriteLine("8) Número reverso\n");
            Console.Write("Digite um número inteiro positivo: ");
            long n = long.Parse(Console.ReadLine());

            long original = n;
            long reverso = 0;
            while (n > 0)
            {
                reverso = reverso * 10 + (n % 10);
                n /= 10;
            }

            Console.WriteLine("Reverso de " + original + " = " + reverso);
            Pause();
        }

        static void Exercicio9()
        {
            Console.Clear();
            Console.WriteLine("9) Verificar palíndromo\n");
            Console.Write("Digite um número inteiro (>= 10): ");
            long n = long.Parse(Console.ReadLine());

            long original = n;
            long reverso = 0;
            while (n > 0)
            {
                reverso = reverso * 10 + (n % 10);
                n /= 10;
            }

            bool palindromo = original == reverso;
            if (palindromo)
                Console.WriteLine(original + " é palíndromo.");
            else
                Console.WriteLine(original + " não é palíndromo.");
            Pause();
        }

        static void Exercicio10()
        {
            Console.Clear();
            Console.WriteLine("10) Classificação por código de produto\n");
            Console.Write("Digite o código do produto (inteiro): ");
            int codigo = int.Parse(Console.ReadLine());

            string classificacao = codigo switch
            {
                1 => "Alimento não-perecível",
                2 or 3 => "Alimento perecível",
                4 or 5 or 6 => "Vestuário",
                7 or 8 or 9 => "Limpeza",
                10 => "Utensílios domésticos",
                11 or 12 => "Eletrônicos",
                _ => "Código inválido",
            };

            Console.WriteLine("Classificação: " + classificacao);
            Pause();
        }

        static void Exercicio11()
        {
            Console.Clear();
            Console.WriteLine("11) Consumo médio de combustível\n");
            Console.Write("Distância percorrida (km): ");
            double distancia = double.Parse(Console.ReadLine());

            Console.Write("Litros consumidos: ");
            double litros = double.Parse(Console.ReadLine());

            double consumo = distancia / litros;
            Console.WriteLine("Consumo médio: " + consumo.ToString("F2") + " km/l");

            if (consumo < 8)
                Console.WriteLine("Venda o carro agora!");
            else if (consumo <= 12)
                Console.WriteLine("Pense em vender o carro!");
            else
                Console.WriteLine("Relativamente econômico!");

            Pause();
        }

        static void Exercicio12()
        {
            Console.Clear();
            Console.WriteLine("12) Conceito do aluno\n");
            Console.Write("Média final: ");
            double media = double.Parse(Console.ReadLine());

            Console.Write("Número de faltas: ");
            int faltas = int.Parse(Console.ReadLine());

            string conceito;
            if (media >= 9.0)
                conceito = faltas > 14 ? "B" : "A";
            else if (media >= 7.5)
                conceito = faltas > 14 ? "C" : "B";
            else if (media >= 6.0)
                conceito = faltas > 14 ? "D" : "C";
            else if (media >= 4.0)
                conceito = faltas > 14 ? "E" : "D";
            else
                conceito = "E";

            Console.WriteLine("Conceito final: " + conceito);
            Pause();
        }

        static void Exercicio13()
        {
            Console.Clear();
            Console.WriteLine("13) Imposto sobre produto\n");
            Console.Write("Digite o preço do produto (R$): ");
            double preco = double.Parse(Console.ReadLine());

            double imposto = preco < 250 ? 0.15 : 0.25;
            double novoPreco = preco * (1 + imposto);

            Console.WriteLine("Novo preço com imposto: R$ " + novoPreco.ToString("F2"));
            Pause();
        }

        static void Exercicio14()
        {
            Console.Clear();
            Console.WriteLine("14) IMC\n");
            Console.Write("Peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            string classificacao = imc >= 30 ? "Muito acima do peso"
                : imc >= 25 ? "Acima do peso"
                : imc >= 18.5 ? "Peso esperado"
                : "Abaixo do peso";

            Console.WriteLine("IMC = " + imc.ToString("F2") + " -> " + classificacao);
            Pause();
        }

        static void Exercicio15()
        {
            Console.Clear();
            Console.WriteLine("15) Conversão de Dólar para Real\n");
            Console.Write("Valor em US$ (dólar): ");
            double dolar = double.Parse(Console.ReadLine());

            Console.Write("Cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine());

            double real = dolar * cotacao;
            Console.WriteLine("Valor em R$ = " + real.ToString("F2"));
            Pause();
        }

        static void Exercicio16()
        {
            Console.Clear();
            Console.WriteLine("16) Hipotenusa de um triângulo retângulo\n");
            Console.Write("Cateto 1: ");
            double cat1 = double.Parse(Console.ReadLine());

            Console.Write("Cateto 2: ");
            double cat2 = double.Parse(Console.ReadLine());

            double hip = Math.Sqrt(cat1 * cat1 + cat2 * cat2);
            Console.WriteLine("Hipotenusa = " + hip.ToString("F2"));
            Pause();
        }

        static void Exercicio17()
        {
            Console.Clear();
            Console.WriteLine("17) Desconto de 27%\n");
            Console.Write("Digite o valor do produto (R$): ");
            double valor = double.Parse(Console.ReadLine());

            double comDesconto = valor * (1 - 0.27);
            Console.WriteLine("Valor com desconto: R$ " + comDesconto.ToString("F2"));
            Pause();
        }

        static void Exercicio18()
        {
            Console.Clear();
            Console.WriteLine("18) Divisão de prêmio entre 3 ganhadores\n");
            Console.Write("Valor total do prêmio (R$): ");
            double premio = double.Parse(Console.ReadLine());

            double primeiro = premio * 0.47;
            double segundo = premio * 0.34;
            double terceiro = premio * 0.19;

            Console.WriteLine("Primeiro lugar: R$ " + primeiro.ToString("F2"));
            Console.WriteLine("Segundo lugar: R$ " + segundo.ToString("F2"));
            Console.WriteLine("Terceiro lugar: R$ " + terceiro.ToString("F2"));
            Pause();
        }

        static void Exercicio19()
        {
            Console.Clear();
            Console.WriteLine("19) Média da Raiz Quadrada (MRQ)\n");
            Console.Write("Digite o número de valores (n): ");
            int n = int.Parse(Console.ReadLine());

            double somaQuadrados = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Valor " + i + ": ");
                double x = double.Parse(Console.ReadLine());
                somaQuadrados += x * x;
            }

            double mrq = Math.Sqrt(somaQuadrados / n);
            Console.WriteLine("MRQ = " + mrq.ToString("F4"));
            Pause();
        }

        static void Pause()
        {
            Console.ReadLine();
        }
    }
}
