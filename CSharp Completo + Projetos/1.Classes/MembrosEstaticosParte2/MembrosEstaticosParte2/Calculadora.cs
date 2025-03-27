
namespace MembrosEstaticosParte2
{
    internal class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circufenrencia(double raioInit)
        {
            return 2.0 * Pi * raioInit;
        }

        public static double Volume(double raioInit)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raioInit, 3);
        }
    }
}
