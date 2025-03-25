
namespace Exercicio5
{
    internal class Aluno
    {
        public string? Nome;
        public double NotaPrimeiroTrimestre;
        public double NotaSegundoTrimestre;
        public double NotaTerceiroTrimestre;

        public double MediaFinal()
        {
            return NotaPrimeiroTrimestre + NotaSegundoTrimestre + NotaTerceiroTrimestre; 
        }

        public double NotaRestante()
        {
            return 60.0 - MediaFinal();
        }
    }
}
