Console.ForegroundColor = ConsoleColor.DarkMagenta; 
Console.Write("ola usuário, digite sua senha:");
Console.ResetColor();

string senha = Console.ReadLine()!;

const string senhacorreta = "1234abcd"!;
string permissaoaoacesso = Console.ReadLine()!;

permissaoaoacesso = senha == senhacorreta ? "permitido":"negado";

Console.WriteLine($"acesso {permissaoaoacesso}");