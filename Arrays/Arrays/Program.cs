/* 
  • 1. Crear un array de 10 números enteros y mostrar la suma de todos sus elementos.
*/

int[] enteros = [10, 4, 10, 1, 1, 1, 1, 1, 2, 3];
sumaElementosArray(enteros);
void sumaElementosArray(int[] enteros)
{
    int suma = 0;
    for(int i = 0; i < enteros.Length; i++)
    {
        suma += enteros[i];
    } 

    Console.WriteLine($"La suma de los enteros del array da: {suma} \n");
}

/*  
• 2. Leer 5 nombres desde teclado, almacenarlos en un array y mostrarlos en orden inverso.
*/
string[] nombres = new string[5];

for(int i = 0;i < nombres.Length;i++)
{
    Console.WriteLine("Ingrese el nombre de la persona: ");
    string nuevoNombre = Console.ReadLine();

    // nombres[i] = nuevoNombre;
    nombres.SetValue(nuevoNombre, i);
}

Console.WriteLine("El array nombres: " + string.Join(",", nombres));

/* 
  • 3. Dado un array de enteros, encontrar el valor máximo y el mínimo.
*/
int[] iMaximoMinimo = [10, 1, 12, 4, 11];

int maximo = enteros[0];
int minimo = enteros[0];

encontrarMaximo(iMaximoMinimo);
encontrarMinimo(iMaximoMinimo);

void encontrarMaximo(int[] enteros)
{
    for (int i = 0; i < enteros.Length; i++)
    {
        if (enteros[i] > maximo)
        {
            maximo = enteros[i];
        }
    }

    Console.WriteLine($"El valor maximo es: {maximo}");
}
void encontrarMinimo(int[] enteros)
{
    for (int i = 0; i < enteros.Length; i++)
    {
        if (enteros[i] < minimo)
        {
            minimo = enteros[i];
        }
    }

    Console.WriteLine($"El valor minimo es: {minimo}");
}
