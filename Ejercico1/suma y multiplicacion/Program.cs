using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
string line = string.Empty;

int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;

Console.WriteLine("ingrese primer numero: ");
line = Console.ReadLine();
num1 = Convert.ToInt32(line);

Console.WriteLine("ingrese segundo numero: ");
line = Console.ReadLine();
num2 = Convert.ToInt32(line);

Console.WriteLine("ingrese tercer numero: ");
line = Console.ReadLine();
num3 = Convert.ToInt32(line);

Console.WriteLine("ingrese cuarto numero: ");
line = Console.ReadLine();
num4 = Convert.ToInt32(line);

Console.WriteLine("la suma del primer y segundo numero es igual a: " +  (num1 + num2));
Console.WriteLine("el producto del tercer y segundo numero es: " + (num3 * num4));