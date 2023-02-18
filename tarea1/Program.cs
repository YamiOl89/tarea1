
byte edad;
byte num1, num2;
ushort resultado;
long num3, num4, suma, resta, producto;

Console.WriteLine("Ingrese suu edad?");
edad = Convert.ToByte(Console.ReadLine());
Console.WriteLine("No aparentas tener: " + edad + " Años.");

//Ejercicio #2

Console.WriteLine("Escriba dos Numeros de dos cifras para Multiplicar:");
Console.WriteLine("Num1:");
num1 = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Num2:");
num2 = Convert.ToByte(Console.ReadLine());
resultado = Convert.ToUInt16(num1 * num2);
Console.WriteLine("El Resultado es:" + resultado);


//Ejercicio  #3
Console.WriteLine("ingrese dos numeros enteros largos para \n");
Console.WriteLine("num3");
num3 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("num4");
num4 = Convert.ToInt64(Console.ReadLine());
suma = num3 + num4;
resta = num3 - num4;
producto= num3 * num4;
Console.WriteLine("La suma es: " + suma + "\n");
Console.WriteLine("La resta es: " + resta + "\n");
Console.WriteLine("El producto es: " + producto + "\n\n");
