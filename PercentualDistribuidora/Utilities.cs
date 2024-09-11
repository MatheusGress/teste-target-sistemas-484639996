// File: FaturamentoUtils.cs
namespace PercentualDistribuidora
{
    public class State
    {
        public string? Name { get; set; }
        public double Value { get; set; }
    }
    public static class FaturamentoCalculator
    {
        public static void CalculateAndDisplayPercentages(State[] states)
        {
            float invoicingTotal = 0;

            // Calcula o faturamento total
            foreach (var state in states)
            {
                invoicingTotal += (float)state.Value;
            }

            // Calcula e exibe o percentual de cada estado
            foreach (var state in states)
            {
                float percentageState = (float)state.Value / invoicingTotal * 100;
                Console.WriteLine($"O percentual de faturamento de {state.Name} foi: {percentageState:F1}%");
            }
        }
    }
}
