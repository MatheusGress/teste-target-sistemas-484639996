namespace SequenciaFibonacci
{
    static class Program
    {
        static bool IsPerfectSquare(int x)
        {
            int square = (int)Math.Sqrt(x);
            return square * square == x;
        }

        static void Main()
        {
            Console.WriteLine("Digite o valor que deseja verificar na lista:");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Erro: A entrada não pode estar vazia ou ser apenas espaços em branco.");
            }
            else
            {
                // Tenta converter a entrada para um número inteiro
                if (!int.TryParse(input, out int number))
                {
                    Console.WriteLine("Erro: A entrada não é um número inteiro válido.");
                }
                else
                {
                    // Verifica se o valor é uma raiz exata
                    int sumCheck = 5 * number * number + 4;
                    int subCheck = 5 * number * number - 4;

                    if (IsPerfectSquare(sumCheck) || IsPerfectSquare(subCheck))
                    {
                        Console.WriteLine($"\nO número {number} pertence à sequência Fibonacci");
                    }
                    else
                    {
                        Console.WriteLine($"\nO número {number} não pertence à sequência Fibonacci");
                    }
                }
            }
        }
    }
}
