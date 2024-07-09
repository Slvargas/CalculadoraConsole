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

        Console.WriteLine("Escolha a operação: + , - , * ou /");
        string operador = Console.ReadLine();

        switch (operador)
        {
            case "+":
                resultado = valor1 + valor2;
                break;
            case "-":
                resultado = valor1 - valor2;
                break;
            case "*":
                resultado = valor1 * valor2;
                break;
            case "/":
                if (valor2 != 0)
                    resultado = valor1 / valor2;
                else
                    Console.WriteLine("Erro: Divisão por zero.");
                break;
            default:
                Console.WriteLine("VALOR INVÁLIDO");
                break ;
        }
        Console.WriteLine($"Resultado:{resultado}");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Gostaria de realizar outra operação?");
        string resposta = Console.ReadLine();
        resposta = resposta.ToLower();
        switch (resposta)
        {
            case "sim":
                Main(args); 
                break;
            case "não":
                Console.WriteLine("Obrigado por utilizar a calculadora!");  
                break;
        
        }
    }


}
