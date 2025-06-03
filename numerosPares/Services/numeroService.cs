namespace numerosPares.Services
{
    public class NumerosService : INumerosService
    {
        public string VerificarParImpar(int numero)
        {
            return numero % 2 == 0 ? "par" : "impar";
        }
    }
}
