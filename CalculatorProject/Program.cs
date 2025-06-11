Console.WriteLine("Digite o primeiro numero:");
var firstIsParsed = double.TryParse(Console.ReadLine(), out double firstDouble);

Console.WriteLine("Digite o segundo numero:");
var secondIsParsed = double.TryParse(Console.ReadLine(), out double secondDouble);

if(!firstIsParsed || !secondIsParsed)
{
    Console.WriteLine("Por favor, digite números válidos.");
    return;
}

Console.WriteLine(@$"
Soma: {firstDouble + secondDouble}
Subtração: {firstDouble - secondDouble}
Multiplicação: {firstDouble * secondDouble}
Divisão: {(secondDouble != 0 ? (firstDouble / secondDouble) : 0)}
Media: {(firstDouble + secondDouble) / 2}
");