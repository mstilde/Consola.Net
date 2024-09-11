// Clase 3 - Resolución de consignas

// 1.a - Definir una variable numérica, asignarle un valor y sumarle 5.

using System.Drawing;
using System.Text.RegularExpressions;

int num = 3;
num += 5;

// 1.b - Definir dos variables de cadenas, asignarles valores y concatenarlas.

string lugar = "la floreria";
string emocion = "¡Que alegría! ¡Que alegría!";
string frase = $"Mambrú se fué a {lugar}, {emocion}";

Console.WriteLine(frase);

// 2 - Evaluar si dos números son iguales, diferentes, mayor o menor.

const int corte = 0;

if (num == corte)
{
    Console.WriteLine($"El numero ingresado es igual al corte: {corte}.");
}
else if (num != corte) {

    Console.WriteLine(
        num > corte ?
          $"El numero ingresado supera al corte por un valor de {num - corte}"
        : $"El numero ingresado es inferior al corte por un valor de {corte - num}");

}

// 3 - Definir una variable numérica. Asignarle un valor entre 1 y 10. Mostrar a que grupo pertenece: Grupo 1: del 1 al 3 / Grupo 2: del 4 al 6 / Grupo 3: del 7 al 10

int num2 = 8;

    switch (num2) {
        case < 4:
        Console.WriteLine("Grupo 1");
        break;
        case < 7:
        Console.WriteLine("Grupo 2");
        break;
        case < 10:
        Console.WriteLine("Grupo 3");
        break;
    };

// 4 - Realizar la sumatoria de 0 a 10 y devolver el valor de la misma.

int num3 = 0;

for (int i = 1; i <= 10; i++)
{
    num3 += 1;
}

Console.WriteLine(num3);

// 5 - Generar un array con 10 números, recorrerlo e ir multiplicando todos los elementos, finalmente obtener el producto total.

int[] numeros = new int[10] {2,3,5,7,11,13,17,19,23,29};

int num4 = 3;
int producto = num4;

for (int i = 0; i < numeros.Length; i++)
{
    producto *= numeros[i];
}

Console.WriteLine($"El resultado de multiplicar el número {num4} con los diez primeros números primos es: {producto}");