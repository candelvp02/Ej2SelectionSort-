public static class InventarioSelectionSort
{
    // Ordena y muestra el proceso de seleccion.
    public static void Ejecutar()
    {
        int[] precios = { 250, 120, 75, 300, 100, 180, 90, 220 };
        int comparaciones = 0;
        int intercambios = 0;

        Console.WriteLine("Precios iniciales: " + Formatear(precios));
        Console.WriteLine();

        for (int i = 0; i < precios.Length - 1; i++)
        {
            int indiceMinimo = i;

            for (int j = i + 1; j < precios.Length; j++)
            {
                comparaciones++;

                if (precios[j] < precios[indiceMinimo])
                {
                    indiceMinimo = j;
                }
            }

            Console.WriteLine($"Iteracion {i + 1}: indice minimo = {indiceMinimo}");

            if (indiceMinimo != i)
            {
                int temporal = precios[i];
                precios[i] = precios[indiceMinimo];
                precios[indiceMinimo] = temporal;
                intercambios++;
            }

            Console.WriteLine("Arreglo: " + Formatear(precios));
        }

        Console.WriteLine();
        Console.WriteLine("Precios ordenados: " + Formatear(precios));
        Console.WriteLine("Comparaciones: " + comparaciones);
        Console.WriteLine("Intercambios: " + intercambios);
    }

    // Convierte el arreglo a texto para mostrarlo.
    private static string Formatear(int[] precios)
    {
        return "{" + string.Join(", ", precios) + "}";
    }
}
