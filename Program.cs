// Clase 3 - Resolución de consignas
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("Ejercicios clase 3");
Console.WriteLine();
// 1.a - Definir una variable numérica, asignarle un valor y sumarle 5.
int num = 3;
num += 5;

// 1.b - Definir dos variables de cadenas, asignarles valores y concatenarlas.
string lugar = "la floreria";
string emocion = "¡Que alegría! ¡Que alegría!";
string frase = $"Mambrú se fué a {lugar}, {emocion}";

Console.WriteLine("1.b) " + frase);

// 2 - Evaluar si dos números son iguales, diferentes, mayor o menor.
const int corte = 0;

if (num == corte)
{
    Console.WriteLine($"2) El numero ingresado es igual al corte: {corte}.");
}
else if (num != corte) {

    Console.WriteLine(
        num > corte ?
          $"2) El numero ingresado supera al corte por un valor de {num - corte}"
        : $"2) El numero ingresado es inferior al corte por un valor de {corte - num}");

}

// 3 - Definir una variable numérica. Asignarle un valor entre 1 y 10. Mostrar a que grupo pertenece: Grupo 1: del 1 al 3 / Grupo 2: del 4 al 6 / Grupo 3: del 7 al 10
int num2 = 8;

    switch (num2) {
        case < 4:
        Console.WriteLine("3) Grupo 1");
        break;
        case < 7:
        Console.WriteLine("3) Grupo 2");
        break;
        case < 10:
        Console.WriteLine("3) Grupo 3");
        break;
    };

// 4 - Realizar la sumatoria de 0 a 10 y devolver el valor de la misma.
int num3 = 0;

for (int i = 1; i <= 10; i++)
{
    num3 += 1;
}

Console.WriteLine("4) " + num3);

// 5 - Generar un array con 10 números, recorrerlo e ir multiplicando todos los elementos, finalmente obtener el producto total.
int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,10};

int num4 = 2;
int producto = num4;

for (int i = 0; i < numeros.Length; i++)
{
    producto *= numeros[i];
}

Console.WriteLine($"5) El resultado de multiplicar el número {num4} con los diez primeros números decimales es: {producto}");

//--------------------------------------------------------------------------------------------------------->
// Clase 5 - Practica métodos
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("Ejercicios clase 5");
Console.WriteLine();
// 1) Crear un método que recibas dos valores, y muestre la suma de ambos.
int num5 = 4;
int num6 = 3;

Sumar(num5, num6);


// 2) Crear una función que reciba dos cadenas de texto y retorne la concatenación de las mismas.
string str1 = "abc";
string str2 = "def";

Console.WriteLine($"2) El resultado de concatenar {str1} con {str2} es {Concatenar(str1, str2)}");

// 3) Crear una función que reciba dos valores: cantidad y precio unitario. Si el total del ítem es mayor a 1000, aplicar un 10% de descuento. Devolver el valor total del ítem.
int cant = 30;
double pUnit = 35.5;

Console.WriteLine(
    MayorAMil(cant, pUnit) ?
    $"3) Precio total {(cant * pUnit) * .9}" :
    $"3) Precio total {cant * pUnit}"
    );

// 4) Crear una función que reciba un número y muestre tantos asteriscos como la cantidad de veces que se pasó como parámetro.
Console.WriteLine($"4) Cantidad de asteriscos: {Asteriscos(num6)}");

















// Metodos

static void Sumar(int num1, int num2)
{
    Console.WriteLine($"1) El resultado de sumar {num1} con {num2} es igual a {num1 + num2}");
}

static string Concatenar(string str1, string str2)
{
    return str1 + " " + str2;
}

static bool MayorAMil(int cant, double pUnit)
{
    return (cant * pUnit) > 1000;
}

static string Asteriscos(int cant)
{
    string ret = "";

    for (int i = 1; i <= cant; i++)
    {
        ret += "*";
    }  

    return ret;
}