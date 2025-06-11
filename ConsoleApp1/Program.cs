Console.WriteLine("Digite Seu Nome!");
string? userRead = Console.ReadLine();

if (userRead is null)
{
    Console.WriteLine("Informe um nome valido!");
    return;
}

Console.WriteLine($"Olá, {userRead}! Seja muito bem vindo!");
