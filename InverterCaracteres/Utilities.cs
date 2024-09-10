namespace InverterCaracteres
{
    public static class StringUtils
    {
        // Retorna uma tupla 
        public static (string original, string reversed) ReverseString(string s)
        {
            // Converte a string em um array
            char[] characters = s.ToCharArray();

            int start = 0;
            int end = characters.Length - 1;

            while (start < end)
            {
                (characters[end], characters[start]) = (characters[start], characters[end]);
                start++;
                end--;
            }

            // Converte o array de volta para uma string
            string reversed = new string(characters);

            // Retorna uma tupla com a string original e a invertida
            return (s, reversed);
        }
    }
}
