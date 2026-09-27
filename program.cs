Console.WriteLine("digite a primeira nota:");
decimal nota1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("digite a segunda nota:");
decimal nota2 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("digite a terceira nota:");
decimal nota3 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("digite a quarta nota:");
decimal nota4 = Convert.ToDecimal(Console.ReadLine());
decimal total = nota1 + nota2 + nota3 + nota4;
decimal media = total / 4;
Console.WriteLine($"A média das notas é: {media}");
Console.WriteLine($"A soma das notas é: {total}");

if (media == 6)
{
    Console.WriteLine("Aprovado na média de 6!");
}
else if (media <= 5)
{
    Console.WriteLine("Reprovado!");
}
else
{
    Console.WriteLine("Aprovado!");
}
