/* * Desarrollar un programa en C# que permita registrar y analizar las notas de varios estudiantes de una materia.
El sistema debe cumplir con los siguientes requisitos:

🔹 1. Ingreso de datos

El programa debe pedir por teclado:
La cantidad de estudiantes a evaluar.
Para cada estudiante:
Su nombre.
Tres notas numéricas (valores entre 0 y 10).

🔹 2. Cálculos
Por cada estudiante, el programa debe:
Calcular el promedio de las tres notas.
Determinar su condición académica según el promedio:
Promedio mayor o igual a 7 → “Aprobado”.
Promedio entre 4 y 6.99 → “Regular”.
Promedio menor a 4 → “Desaprobado”.

🔹 3. Resultados generales
Una vez ingresados todos los estudiantes, el programa debe:
Mostrar la lista completa de alumnos con:
Nombre, notas, promedio y condición.

Calcular y mostrar:
El promedio general del curso.
La cantidad de aprobados, regulares y desaprobados.
El mejor promedio y el nombre del estudiante que lo obtuvo. */
using System;


// Ingreso de datos
Console.WriteLine("Ingrese la cantidad de estudiantes que desea: ");
int cantEstudiantes = Convert.ToInt32(Console.ReadLine());
double promedio = 0;
string nombreEstudiante = "";
int nota1 = 0, nota2 = 0, nota3 = 0;
int cantAprobados = 0;
int cantRegular = 0;
int cantDesaprobados = 0;
double promedioGeneral = 0;

for (int i = 0; i < cantEstudiantes; i++)
{
    Console.Write("Ingrese el nombre del alumno: ");
    nombreEstudiante = Console.ReadLine();
    bool esNotaValida;


    Console.WriteLine("Ingrese la primer nota: ");
    do
    {
        nota1 = Convert.ToInt32(Console.ReadLine());
        esNotaValida = validarRangoNumericoNota(nota1);
        if (!esNotaValida) Console.WriteLine("Ingrese la primer nota: ");
    } while (!esNotaValida);


    Console.WriteLine("Ingrese la segunda nota: ");
    do
    {
        nota2 = Convert.ToInt32(Console.ReadLine());
        esNotaValida = validarRangoNumericoNota(nota2);
        if (!esNotaValida) Console.WriteLine("Ingrese la segunda nota: ");
    } while (!esNotaValida);

    Console.WriteLine("Ingrese la tercer nota: ");
    do
    {
        nota3 = Convert.ToInt32(Console.ReadLine());
        esNotaValida = validarRangoNumericoNota(nota3);
        if (!esNotaValida) Console.WriteLine("Ingrese la tercer nota: ");
    } while (!esNotaValida);


    promedio = calcularPromedioNotas(nota1, nota2, nota3);
    Console.WriteLine($"El nombre del estudiante es: {nombreEstudiante}");
    Console.WriteLine($"Nota 1: {nota1}");
    Console.WriteLine($"Nota 2: {nota2}");
    Console.WriteLine($"Nota 3: {nota3}");


    if (promedio >= 7.00)
    {
        cantAprobados++;
        Console.WriteLine($"{nombreEstudiante} --> Promedio: {promedio} | Condicion: APROBADO");
    }

    if (promedio < 7 && promedio >= 4)
    {
        cantRegular++;
        Console.WriteLine($"{nombreEstudiante} --> Promedio: {promedio} | Condicion: REGULAR");
    }

    if (promedio < 4)
    {
        cantDesaprobados++;
        Console.WriteLine($"{nombreEstudiante} --> Promedio: {promedio} | Condicion: DESAPROBADO");
    }

    promedioGeneral += promedio;
}

Console.WriteLine($"El promedio general es {calcularPromedioGeneral(promedioGeneral)}");
Console.WriteLine($"Aprobados: {cantAprobados}");
Console.WriteLine($"Regulares: {cantRegular}");
Console.WriteLine($"Desaprobados: {cantDesaprobados}");

// Calcular promedio general
double calcularPromedioGeneral(double promedioGeneral)
{
    return promedioGeneral / cantEstudiantes;
}

// Validar rango del valor de la nota entre 0 y 10
bool validarRangoNumericoNota(int nota)
{
    if (nota < 0 || nota > 10) return false;
    else return true;
}

// Hacer promedio de notas
double calcularPromedioNotas(int nota1, int nota2, int nota3)
{
    int sumaTotal = nota1 + nota2 + nota3;
    double promedio = (double)sumaTotal / 3;
    return promedio;
}