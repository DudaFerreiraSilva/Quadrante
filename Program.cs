double x, y;
string local;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("--- Quadrante Cartesiano ---\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Entre com o ponto desejado.");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Coordenada x: ");
x = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Coordenada y: ");
y = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

if (x == 0 && y == 0) local = "a origem";
else if (x == 0) local = "o eixo das ordenadas";
else if (y == 0) local = "o eixo das abscissas";
else if (y > 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    if (x > 0)
    local = "o quadrante 1";
    else
    local = "o quadrante 2";
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    if (x < 0)
    local = "o quadrante 3";
    else
    local = "o quadrante 4";
    Console.ResetColor();
}
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"\nO ponto ({x}, {y}) fica n{local}.");
Console.ResetColor();