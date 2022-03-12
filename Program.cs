string nome, sobrenome, SOBRENOME;

Console.WriteLine("digite seu primeiro nome:");
nome=Console.ReadLine()!;

Console.WriteLine("digite seu sobrenome:");
sobrenome=Console.ReadLine()!;

SOBRENOME=sobrenome.ToUpper();

Console.WriteLine($"Nome completo: {nome} {sobrenome}"!);
Console.WriteLine($"Nome de catalogo: {SOBRENOME} {nome} "!);
