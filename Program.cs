using ReverseString.Util;

while (true)
{
    Console.Write("\nDigite um texto para ser invertido: ");
    string input = Console.ReadLine();

    string stringInvertida = StringFormatter.InverterString(input);

    Console.WriteLine("String invertida: " + stringInvertida);
    
    Console.WriteLine("\nDeseja continuar? (S/N)");
    string resposta = Console.ReadLine().ToUpper();

    if (resposta != "S")
    {
        Console.WriteLine("\nObrigado por utilizar o programa!");
        break;
    }
}