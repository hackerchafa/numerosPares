namespace ApiPalindromos.Services
{
    public class PalindromoService : IPalindromoService
    {
        public bool EsPalindromo(string texto)
        {
            var limpio = new string(texto
                .Where(char.IsLetterOrDigit)
                .Select(char.ToLower)
                .ToArray());

            var invertido = new string(limpio.Reverse().ToArray());

            return limpio == invertido;
        }
    }
}

