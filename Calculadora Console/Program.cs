namespace CalculadoraConsole;

class Program
{
    static void Main(string[] args)
    {
        int resultado = 0;

        Console.WriteLine("digite o primeiro numero");
        string valor1texto = Console.ReadLine();
        int valor1 = Int32.Parse(valor1texto); 

        Console.WriteLine("digite o segundo numero");
        string valor2texto = Console.ReadLine();
        int valor2 = Int32.Parse(valor2texto); 

        Console.WriteLine("Resultado da Soma");

        resultado = valor1 + valor2;

        Console.WriteLine(resultado);
    }
}
