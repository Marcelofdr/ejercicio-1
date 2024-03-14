
//Ejercicio 1: Division entre cero

//Ya que no se puede dividir un número por cero, deberá controlar la división alertando al usuario.
//No se podra usar función While, ni Switch. Tampoco se podra usar uso de otros metodos
//hola mundo hola mundo
//hello word, gev

double x;
double divisor;
string operador;
double resultado;


    Console.WriteLine("\r\n ingrese el numero"); // \r\n es para hacer un salto de linea en consola
    x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("ingrese el numero");
    divisor= Convert.ToDouble(Console.ReadLine());
if (divisor == 0) {
    Console.WriteLine("no se puede dividir por cero");
}
else 
{
    resultado = x / divisor;
    Console.WriteLine("" );
    Console.WriteLine($"este es el resultado {resultado}");

    resultado = x * divisor;
    Console.WriteLine("" );
    Console.WriteLine($"este es el resultado {resultado}");
}



Console.ReadKey();
