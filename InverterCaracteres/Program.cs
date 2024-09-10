namespace InverterCaracteres
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite a palavra que deseja inverter:");
            string? input = Console.ReadLine();

            // Verifica se a entrada não está vazia ou apenas espaços em branco
            if (!string.IsNullOrWhiteSpace(input))
            {
                // Faz a inversão chamando o método e obtém a tupla
                (string original, string reversed) = StringUtils.ReverseString(input);

                Console.WriteLine("\nPalavra original: " + original);
                Console.WriteLine("Palavra invertida: " + reversed);
            }
            else
            {
                Console.WriteLine("Erro: A entrada não pode estar vazia ou ser apenas espaços em branco.");
            }
        }
    }
}
