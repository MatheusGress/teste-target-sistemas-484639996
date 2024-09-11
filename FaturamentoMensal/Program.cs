namespace FaturamentoMensal
{
    static class Program
    {
        static void Main()
        {
            // Caminho para o arquivo JSON
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "data", "Dados.json");

            // Verifica se o arquivo existe 
            if (File.Exists(filePath))
            {
                List<DailyRecord> records = Utilities.DeserializeJsonToRecords(filePath);

                var filteredRecords = records.Where(record => record.Value > 0).ToList();

                if (filteredRecords.Count > 0)
                {
                    float totalValue = filteredRecords.Sum(record => record.Value);
                    float averageRevenue = totalValue / filteredRecords.Count;
                    
                    // calcula os valores de saida
                    int daysAboveAverage = filteredRecords.Count(record => record.Value > averageRevenue);
                    float minValue = filteredRecords.Min(record => record.Value);
                    float maxValue = filteredRecords.Max(record => record.Value);

                    Console.WriteLine($"O valor mínimo faturado em um dia do mês foi de: {minValue}");
                    Console.WriteLine($"O valor máximo faturado em um dia do mês foi de: {maxValue}");
                    Console.WriteLine($"O total de dias no mês que superaram a média foi de: {daysAboveAverage}");
                }
                else
                {
                    Console.WriteLine("Nenhum registro válido encontrado após a filtragem.");
                }
            }
            else
            {
                Console.WriteLine($"Arquivo não encontrado: {filePath}");
            }
        }
    }
}
