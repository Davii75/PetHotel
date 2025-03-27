// +=========================================================+
// |                 Pet Hotel "Nem um pio"                  |
// +=========================================================+
// | Espécie: ............CÃO | Raça: ............INDEFINIDA |
// +=========================================================+
// | Atende pela alcunha de: ...........................ZECA |
// | Idade: 03 ano(s) | Pelagem/cor: ...............CARAMELO |
// +=========================================================+

string especie, raca, alcunha, cor, idade;

Console.Write("Qual a espécie do seu animal? ");
especie = Console.ReadLine()!;

Console.Write("Qual a raça do seu animal? ");
raca = Console.ReadLine()!;

Console.Write("Qual a alcunha/nome do seu animal? ");
alcunha = Console.ReadLine()!;

Console.Write("Qual a cor do seu animal? ");
cor = Console.ReadLine()!;

Console.Write("Qual a idade do seu animal? ");
idade = Console.ReadLine()!;
Console.Clear();

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("+=========================================================+");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.Write("|");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("                 PetHotel Nem um pio                     ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("|");
Console.WriteLine("+=========================================================+");
Console.ResetColor();
Console.Write("|");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(" Espécie: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write(especie.Trim().ToUpper().PadLeft(17, '.').Substring(0, 17));
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.Write(" |");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(" Raça: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write(raca.Trim().ToUpper().PadLeft(20, '.').Substring(0, 20));
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(" |");
Console.ResetColor();

Console.WriteLine("+=========================================================+");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(" Atende pela alcunha de: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write(alcunha.Trim().ToUpper().PadLeft(31, '.').Substring(0, 31));
Console.ResetColor();
Console.WriteLine(" |");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(" Idade: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write(idade.Trim().ToUpper().PadLeft(19, '.').Substring(0, 19));
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.Write(" |");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(" Pelagem/cor: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write(cor.Trim().ToUpper().PadLeft(13, '.').Substring(0, 13));
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(" |");
Console.WriteLine("+=========================================================+");
Console.ResetColor();