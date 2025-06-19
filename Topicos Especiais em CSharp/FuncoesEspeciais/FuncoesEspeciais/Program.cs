namespace FuncoesEspeciais;
class Program
{
    static void Main(string[] args)
    {
        string fraseOriginal = "abcde FGHIJ ABC abc DEFG";

        string fraseAtualizadaMaiuscula = fraseOriginal.ToUpper();
        string fraseAtualizadaMinususcula = fraseOriginal.ToLower();
        string fraseAtualizadaSemEspacos = fraseOriginal.Trim();

        int n1 = fraseOriginal.IndexOf("bc");
        int n2 = fraseOriginal.LastIndexOf("bc");
        string s1 = fraseOriginal.Substring(3);
        string s2 = fraseOriginal.Substring(3, 5);
        string s3 = fraseOriginal.Replace('a', 'x');
        string s4 = fraseOriginal.Replace("abc", "xy");
        bool b1 = String.IsNullOrEmpty(fraseOriginal);
        bool b2 = String.IsNullOrWhiteSpace(fraseOriginal);

        Console.WriteLine($"Frase original {fraseOriginal}");
        Console.WriteLine($"Frase modificada para maiuscula {fraseAtualizadaMaiuscula}");
        Console.WriteLine($"Frase modificada para minuscula {fraseAtualizadaMinususcula}");
        Console.WriteLine($"Frase modificada sem espacos {fraseAtualizadaSemEspacos}");
        Console.WriteLine($"IndexOf (bc) {n1}");
        Console.WriteLine($"LastIndexOf (bc) {n2}");
        Console.WriteLine($"Substring (string recortada em 3) (bc) {s1}");
        Console.WriteLine($"Substring (string recortada em 3 e 5) (bc) {s2}");
        Console.WriteLine("Replace('a', 'x'): -" + s3 + "-");
        Console.WriteLine("Replace('abc', 'xy'): -" + s4 + "-");
        Console.WriteLine("IsNullOrEmpty: " + b1);
        Console.WriteLine("IsNullOrWhiteSpace: " + b2);
    }
}