int side = 0;

Console.WriteLine("ingrese medida de un lado: ");
string line = Console.ReadLine();
side = (Convert.ToInt32(line) * 4);

Console.WriteLine("El perimetro del cuadrado es: " + side);
