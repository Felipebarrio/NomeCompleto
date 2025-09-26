string nome, sobrenome;
Console.Write("digite seu primeiro nome: ");
nome = Console.ReadLine();
Console.Write("digite seu sobrenome: ");
sobrenome = Console.ReadLine();
Console.Write("nome completo: ");
Console.WriteLine($"{nome} {sobrenome}");
Console.Write("nome de catálogo: ");
Console.WriteLine($"{sobrenome.ToUpper()} {nome}");