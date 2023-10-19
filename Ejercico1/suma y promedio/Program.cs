

int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;

Console.WriteLine("ingrese primer numero: ");
string line = Console.ReadLine();
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

Console.WriteLine("El resultado de la suma de estos numeros es igual a: " + (num1 + num2 + num3 + num4)); 
Console.WriteLine("Elpromedo de estos numeros es igual a: " + ((num1 + num2 + num3 + num4) / 4));

