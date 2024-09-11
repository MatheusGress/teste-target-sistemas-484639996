using System.Text.Json;
using System.Text.Json.Serialization;

namespace FaturamentoMensal
{
    public static class Utilities
    {
        public static List<DailyRecord> DeserializeJsonToRecords(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<DailyRecord>>(jsonString) ?? [];
        }
    }

    public class DailyRecord
    {
        // Mapeia o nome do JSON para a propriedade
        [JsonPropertyName("dia")] 
        public int Day { get; set; }

        [JsonPropertyName("valor")]
        public float Value { get; set; }
    }
}
