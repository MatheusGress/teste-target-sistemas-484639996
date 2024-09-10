namespace PercentualDistribuidora
{
    static class Program
    {
        static void Main()
        {
            var states = new[]
            {
            new { State = "SP", Value = 67836.43m },
            new { State = "RJ", Value = 36678.66m },
            new { State = "MG", Value = 29229.88m },
            new { State = "ES", Value = 27165.48m },
            new { State = "Outros", Value = 19849.53m }
        };

            decimal invoicingTotal = 0;

            // Calcula o faturamento total
            foreach (var state in states)
            {
                invoicingTotal += state.Value;
            }

            // Calcula e exibe o percentual de cada estado
            foreach (var state in states)
            {
                decimal percentageState = state.Value / invoicingTotal * 100;
                Console.WriteLine($"O percentual de faturamento de {state.State} foi: {percentageState.ToString("F1")}%");
            }
        }
    }
}
