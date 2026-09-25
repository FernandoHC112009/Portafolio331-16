using System;
// Espacio de nombres
namespace CS1
{
    // Clase principal
    class Program
    {
        // Funcion Principal 
        Static void Main(string[] args)
        {
             // Sesion 6:Operadores
             // Declaracion e inicializacion
             double a = 0;
             double b = 1;
             double resultado = 0; 
             // 1. Operadores aritmeticos 
             // a. Suma: +
             resultado = a + b;            
             Console.WriteLine($"Suma: {resultado}");
             // b. Resta: -
             resultado = a - b;            
             Console.WriteLine($"Resta: {resultado}");
             // c. Multiplicacion: *
             resultado = a * b;           
             Console.WriteLine($"Multiplicacion: {resultado}");
             // d. Division: /
             resultado = a / b;          
             Console.WriteLine($"Division: {resultado}");
             // e. Resto (Modulo): %
             resultado = a % b;            
             Console.WriteLine($"Resto: {resultado}");
             
             //Incrementacion y decrementacion
             resultado += 9;
             resultado -= 9;
             Console.WriteLine("$ Resultado: {resultado}");
             //2. Operadores comparativos 
             //a. Igualdad: ==
             //b. Diferencia !=
             //c. Menor que <
             //d. Mayor que >
             //e. Menor o igual que <=
             //f. Mayor o igual que >=
             bool m = false;
             m = 4 == 10;
            Console.WriteLine($"Igualdad: {m}");
             m = 5 != 5;
            Console.WriteLine($"Diferencia: {m}");
             m = 5 > 4 
            Console.WriteLine($"Mayor que: {m}");
             m = 4 < 5
            Console.WriteLine($"Menor que: {m}");
            // Operadores logicos
            // Y (AND): &&
            // O (OR): ||
            bool e = false; // Entrada 1
            bool f = true; // Entrada 2 
            bool d = false; // Entrada 3  
            d = e && f;
            Console.WriteLine($"Y: {d}");
            d = e || f;
            Console.WriteLine($"O: {d}")
        } 
    }
}