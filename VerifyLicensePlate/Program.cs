// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite a placa do carro:");
var licensePlate = Console.ReadLine();

if(licensePlate == null)
{
    Console.WriteLine("Nenhuma placa foi fornecida.");
    return;
}
if(licensePlate.Length == 7
    && licensePlate.All(char.IsLetterOrDigit)
    && licensePlate.Take(3).All(char.IsLetter)
    && licensePlate.TakeLast(4).All(char.IsNumber)
)
{
    Console.WriteLine("Verdadeiro");
}
else
{
    Console.WriteLine("Falso");
}

