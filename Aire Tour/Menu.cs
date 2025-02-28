// See https://aka.ms/new-console-template for more information

using AireTour;

Cliente cliente = new Cliente();

string? Contra; 
int val=1;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("           AIRE TOUR");
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("        Presentado por:");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(" Duvan Camilo Rodriguez Urrego");
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("             Curso:");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("     Estructura de datos");
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("-------------------------------");
Console.WriteLine("Por favor ingrese la contraseña");
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("» ");
Contra = Console.ReadLine();

if (Contra == "123")
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("        BIENVENIDO A AIRE TOUR");
    Console.ForegroundColor = ConsoleColor.White;
    cliente.mostCli(val);
}
else
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("La contraseña no es correcta");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("      Acceso denegado");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("Saliendo de la aplicación");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("...");
}

