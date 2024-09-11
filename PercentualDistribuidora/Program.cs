// File: Program.cs
namespace PercentualDistribuidora
{
    static class Program
    {
        static void Main()
        {
            var states = new[]
            {
                new State { Name = "SP", Value = 67836.43 },
                new State { Name = "RJ", Value = 36678.66 },
                new State { Name = "MG", Value = 29229.88 },
                new State { Name = "ES", Value = 27165.48 },
                new State { Name = "Outros", Value = 19849.53 }
            };

            // Usa a classe utilitária para calcular e exibir 
            FaturamentoCalculator.CalculateAndDisplayPercentages(states);
        }
    }
}
